// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Monitor.Ingestion
{
    /// <summary> The IngestionUsingDataCollectionRules service client. </summary>
    [CodeGenClient("IngestionUsingDataCollectionRulesClient")]
    public partial class LogsIngestionClient
    {
        /// <summary> Initializes a new instance of LogsIngestionClient for mocking. </summary>
        protected LogsIngestionClient()
        {
        }

        // The size we use to determine whether to upload as a single PUT BLOB
        // request or stage as multiple blocks.
        private const int SingleUploadThreshold = 1000000; // 1 Mb in byte format

        internal HttpMessage CreateUploadRequest(string ruleId, string streamName, RequestContent content, string contentEncoding, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/dataCollectionRules/", false);
            uri.AppendPath(ruleId, true);
            uri.AppendPath("/streams/", false);
            uri.AppendPath(streamName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            if (contentEncoding != null)
            {
                request.Headers.Add("Content-Encoding", contentEncoding);
            }
            if (contentEncoding == "gzip")
            {
                GZipUtf8JsonRequestContent gzContent = new(content);
                request.Content = gzContent;
            }
            else
            {
                request.Content = content;
            }
            return message;
        }

        /// <summary>
        /// Hidden method for batching data - serializing into arrays of JSON no more than SingleUploadThreshold each
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logEntries"></param>
        /// <returns></returns>
        internal static IEnumerable<Tuple<List<T>, BinaryData>> Batch<T>(IEnumerable<T> logEntries)
        {
            //TODO: use Array pool instead
            MemoryStream stream = new MemoryStream(SingleUploadThreshold);
            WriteMemory(stream, BinaryData.FromString("[").ToMemory());
            int entryCount = 0;
            List<T> currentLogList = new List<T>();

            foreach (var log in logEntries)
            {
                BinaryData entry = log is BinaryData d ? d : BinaryData.FromObjectAsJson(log);
                var memory = entry.ToMemory();

                if (memory.Length > SingleUploadThreshold) // if single log is > 1 Mb send to be gzipped by itself
                {
                    MemoryStream tempStream = new MemoryStream(); // create tempStream for individual log
                    WriteMemory(tempStream, BinaryData.FromString("[").ToMemory());
                    WriteMemory(tempStream, memory);
                    WriteMemory(tempStream, BinaryData.FromString("]").ToMemory());
                    tempStream.Position = 0;
                    yield return Tuple.Create(new List<T>{log}, BinaryData.FromStream(tempStream));
                }
                else if ((stream.Length + memory.Length + 1) >= SingleUploadThreshold) // if adding this entry makes stream > 1 Mb send current stream now
                {
                    WriteMemory(stream, BinaryData.FromString("]").ToMemory());
                    stream.Position = 0; // set Position to 0 to return everything from beginning of stream
                    yield return Tuple.Create(currentLogList, BinaryData.FromStream(stream));

                    // reset stream and currentLogList
                    stream = new MemoryStream(SingleUploadThreshold); // reset stream
                    currentLogList = new List<T>(); // reset log list
                    WriteMemory(stream, memory); // add log to memory and currentLogList
                    currentLogList.Add(log);
                }
                else
                {
                    WriteMemory(stream, memory);
                    if ((entryCount + 1) == logEntries.Count())
                    {
                        // reached end of logEntries and we haven't returned yet
                        WriteMemory(stream, BinaryData.FromString("]").ToMemory());
                        stream.Position = 0;
                        currentLogList.Add(log);
                        yield return Tuple.Create(currentLogList, BinaryData.FromStream(stream));
                    }
                    else
                    {
                        WriteMemory(stream, BinaryData.FromString(",").ToMemory());
                        currentLogList.Add(log);
                    }
                }
                entryCount++;
            }
        }

        private static void WriteMemory(MemoryStream stream, ReadOnlyMemory<byte> memory)
        {
            stream.Write(memory.ToArray(), 0, memory.Length); //TODO: fix ToArray
        }

        /// <summary> Ingestion API used to directly ingest data using Data Collection Rules. </summary>
        /// <param name="ruleId"> The immutable Id of the Data Collection Rule resource. </param>
        /// <param name="streamName"> The streamDeclaration name as defined in the Data Collection Rule. </param>
        /// <param name="logEntries"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/>, <paramref name="streamName"/> or <paramref name="logEntries"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> or <paramref name="streamName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call Upload with required parameters and request content.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new LogsIngestionClient(endpoint, credential);
        ///
        /// var data = new[] {
        ///     new {}
        /// };
        ///
        /// Response response = client.Upload("<ruleId>", "<streamName>", data);
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        /// <remarks> See error response code and error response message for more detail. </remarks>
        public virtual Response<UploadLogsResult> Upload<T>(string ruleId, string streamName, IEnumerable<T> logEntries, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNullOrEmpty(streamName, nameof(streamName));
            Argument.AssertNotNullOrEmpty(logEntries, nameof(logEntries));

            using var scope = ClientDiagnostics.CreateScope("LogsIngestionClient.Upload");
            scope.Start();

            var requestContext = new RequestContext() { CancellationToken = cancellationToken };
            requestContext.AddClassifier(500, false);
            requestContext.AddClassifier(403, false);
            requestContext.AddClassifier(413, false);
            requestContext.AddClassifier(429, false);
            requestContext.AddClassifier(503, false);
            Response response = null;
            List<UploadLogsError> errors = new List<UploadLogsError>();
            try
            {
                foreach (Tuple<List<T>, BinaryData> result in Batch(logEntries))
                {
                    //TODO: catch errors and correlate with Batch.start
                    response = Upload(ruleId, streamName, result.Item2, "gzip", requestContext);
                    if (response.Status != 204) //and response.Content == 500)
                    {
                        RequestFailedException requestFailedException = new RequestFailedException(response);
                        ResponseError responseError = new ResponseError(requestFailedException.ErrorCode, requestFailedException.Message);
                        List<Object> objectLogs = new List<Object>();
                        foreach (var log in result.Item1)
                        {
                            objectLogs.Add(log);
                        }
                        errors.Add(new UploadLogsError(responseError, objectLogs));
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }

            UploadLogsResult finalResult = new UploadLogsResult(errors, Status(logEntries, errors));
            return Response.FromValue(finalResult, response);
        }

        /// <summary> Ingestion API used to directly ingest data using Data Collection Rules. </summary>
        /// <param name="ruleId"> The immutable Id of the Data Collection Rule resource. </param>
        /// <param name="streamName"> The streamDeclaration name as defined in the Data Collection Rule. </param>
        /// <param name="logEntries"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/>, <paramref name="streamName"/> or <paramref name="logEntries"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> or <paramref name="streamName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call Upload with required parameters and request content.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new LogsIngestionClient(endpoint, credential);
        ///
        /// var data = new[] {
        ///     new {}
        /// };
        ///
        /// Response response = client.Upload("<ruleId>", "<streamName>", data);
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        /// <remarks> See error response code and error response message for more detail. </remarks>
        public virtual async Task<Response<UploadLogsResult>> UploadAsync<T>(string ruleId, string streamName, IEnumerable<T> logEntries, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNullOrEmpty(streamName, nameof(streamName));
            Argument.AssertNotNullOrEmpty(logEntries, nameof(logEntries));

            using var scope = ClientDiagnostics.CreateScope("LogsIngestionClient.Upload");
            scope.Start();

            var requestContext = new RequestContext() { CancellationToken = cancellationToken };
            requestContext.AddClassifier(500, false);
            requestContext.AddClassifier(403, false);
            requestContext.AddClassifier(413, false);
            requestContext.AddClassifier(429, false);
            requestContext.AddClassifier(503, false);
            Response response = null;
            List<UploadLogsError> errors = new List<UploadLogsError>();
            try
            {
                foreach (Tuple<List<T>, BinaryData> result in Batch(logEntries))
                {
                    //TODO: catch errors and correlate with Batch.start
                    response = await UploadAsync(ruleId, streamName, result.Item2, "gzip", requestContext).ConfigureAwait(false);
                    if (response.Status != 204) //and response.Content == 500)
                    {
                        RequestFailedException requestFailedException = new RequestFailedException(response);
                        ResponseError responseError = new ResponseError(requestFailedException.ErrorCode, requestFailedException.Message);
                        List<Object> objectLogs = new List<Object>();
                        foreach (var log in result.Item1)
                        {
                            objectLogs.Add(log);
                        }
                        errors.Add(new UploadLogsError(responseError, objectLogs));
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }

            UploadLogsResult finalResult = new UploadLogsResult(errors, Status(logEntries, errors));
            return Response.FromValue(finalResult, response);
        }

        private static UploadLogsStatus Status<T>(IEnumerable<T> logEntries, List<UploadLogsError> errors)
        {
            UploadLogsStatus status;
            if (errors.Count == 0)
            {
                status = UploadLogsStatus.SUCCESS;
            }
            else if (errors.Count > logEntries.Count())
            {
                status = UploadLogsStatus.PARTIALFAILURE;
            }
            else
            {
                status = UploadLogsStatus.FAILURE;
            }

            return status;
        }
    }
}
