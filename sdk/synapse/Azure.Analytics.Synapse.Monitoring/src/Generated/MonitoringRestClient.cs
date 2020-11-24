// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Monitoring.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Monitoring
{
    internal partial class MonitoringRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MonitoringRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public MonitoringRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-11-01-preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetSparkJobListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/monitoring/workloadTypes/spark/Applications", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get list of spark applications for the workspace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkJobListViewResponse>> GetSparkJobListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkJobListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobListViewResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkJobListViewResponse.DeserializeSparkJobListViewResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get list of spark applications for the workspace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkJobListViewResponse> GetSparkJobList(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkJobListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkJobListViewResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkJobListViewResponse.DeserializeSparkJobListViewResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSqlJobQueryStringRequest(string filter, string orderby, string skip)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/monitoring/workloadTypes/sql/querystring", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("filter", filter, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("skip", skip, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get SQL OD/DW Query for the workspace. </summary>
        /// <param name="filter"> The String to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="skip"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SqlQueryStringDataModel>> GetSqlJobQueryStringAsync(string filter = null, string orderby = null, string skip = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSqlJobQueryStringRequest(filter, orderby, skip);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlQueryStringDataModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlQueryStringDataModel.DeserializeSqlQueryStringDataModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get SQL OD/DW Query for the workspace. </summary>
        /// <param name="filter"> The String to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="skip"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SqlQueryStringDataModel> GetSqlJobQueryString(string filter = null, string orderby = null, string skip = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSqlJobQueryStringRequest(filter, orderby, skip);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlQueryStringDataModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlQueryStringDataModel.DeserializeSqlQueryStringDataModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
