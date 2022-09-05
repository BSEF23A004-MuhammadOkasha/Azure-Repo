// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Developer.LoadTesting.Models;

namespace Azure.Developer.LoadTesting
{
    internal partial class TestRunRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of TestRunRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public TestRunRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2022-06-01-preview")
        {
            endpoint ??= new Uri("https://<dataPlaneURL>");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteTestRunRequest(string testRunId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/", false);
            uri.AppendPath(testRunId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete a test run by its name. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public async Task<Response> DeleteTestRunAsync(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateDeleteTestRunRequest(testRunId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a test run by its name. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public Response DeleteTestRun(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateDeleteTestRunRequest(testRunId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateAndUpdateTestRequest(string testRunId, TestRunModel body, string oldTestRunId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/", false);
            uri.AppendPath(testRunId, true);
            if (oldTestRunId != null)
            {
                uri.AppendQuery("oldTestRunId", oldTestRunId, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Create and start a new test run with the given name. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="body"> Load test run model. </param>
        /// <param name="oldTestRunId"> Existing test run Id that should be rerun. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> or <paramref name="body"/> is null. </exception>
        public async Task<Response<TestRunModel>> CreateAndUpdateTestAsync(string testRunId, TestRunModel body, string oldTestRunId = null, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateCreateAndUpdateTestRequest(testRunId, body, oldTestRunId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TestRunModel.DeserializeTestRunModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create and start a new test run with the given name. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="body"> Load test run model. </param>
        /// <param name="oldTestRunId"> Existing test run Id that should be rerun. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> or <paramref name="body"/> is null. </exception>
        public Response<TestRunModel> CreateAndUpdateTest(string testRunId, TestRunModel body, string oldTestRunId = null, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateCreateAndUpdateTestRequest(testRunId, body, oldTestRunId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TestRunModel.DeserializeTestRunModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestRunRequest(string testRunId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/", false);
            uri.AppendPath(testRunId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get test run details by name. </summary>
        /// <param name="testRunId"> Unique name of load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public async Task<Response<TestRunModel>> GetTestRunAsync(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateGetTestRunRequest(testRunId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TestRunModel.DeserializeTestRunModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get test run details by name. </summary>
        /// <param name="testRunId"> Unique name of load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public Response<TestRunModel> GetTestRun(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateGetTestRunRequest(testRunId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TestRunModel.DeserializeTestRunModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestRunFileRequest(string testRunId, string fileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/", false);
            uri.AppendPath(testRunId, true);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get test run file by file name. </summary>
        /// <param name="testRunId"> Unique name of load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="fileId"> Unique identifier for test run file, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> or <paramref name="fileId"/> is null. </exception>
        public async Task<Response<FileUrl>> GetTestRunFileAsync(string testRunId, string fileId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }
            if (fileId == null)
            {
                throw new ArgumentNullException(nameof(fileId));
            }

            using var message = CreateGetTestRunFileRequest(testRunId, fileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileUrl value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileUrl.DeserializeFileUrl(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get test run file by file name. </summary>
        /// <param name="testRunId"> Unique name of load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="fileId"> Unique identifier for test run file, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> or <paramref name="fileId"/> is null. </exception>
        public Response<FileUrl> GetTestRunFile(string testRunId, string fileId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }
            if (fileId == null)
            {
                throw new ArgumentNullException(nameof(fileId));
            }

            using var message = CreateGetTestRunFileRequest(testRunId, fileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileUrl value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileUrl.DeserializeFileUrl(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListTestRunsSearchRequest(string orderBy, string continuationToken, string search, DateTimeOffset? executionFrom, DateTimeOffset? executionTo, string status, int? maxPageSize, string testId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/sortAndFilter", false);
            if (orderBy != null)
            {
                uri.AppendQuery("orderBy", orderBy, true);
            }
            if (continuationToken != null)
            {
                uri.AppendQuery("continuationToken", continuationToken, true);
            }
            if (search != null)
            {
                uri.AppendQuery("search", search, true);
            }
            if (executionFrom != null)
            {
                uri.AppendQuery("executionFrom", executionFrom.Value, "O", true);
            }
            if (executionTo != null)
            {
                uri.AppendQuery("executionTo", executionTo.Value, "O", true);
            }
            if (status != null)
            {
                uri.AppendQuery("status", status, true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            if (testId != null)
            {
                uri.AppendQuery("testId", testId, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get all test runs with given filters. </summary>
        /// <param name="orderBy"> Sort on one of the field - status, displayName, executedDateTime in (field asc/desc) format. eg: displayName asc. </param>
        /// <param name="continuationToken"> Continuation token to get the next page of response. </param>
        /// <param name="search"> Filter search based on searchable fields - description, executedUser. </param>
        /// <param name="executionFrom"> The end DateTime(ISO 8601 literal format) of test-run execution time filter range. </param>
        /// <param name="executionTo"> The start DateTime(ISO 8601 literal format) of test-run execution time filter range. </param>
        /// <param name="status">
        /// Comma separated list of test run status, value can be -  &quot;ACCEPTED&quot;, &quot;NOTSTARTED&quot;,&quot;PROVISIONING&quot;,&quot;PROVISIONED&quot;,&quot;CONFIGURING&quot;,
        /// &quot;CONFIGURED&quot;,&quot;EXECUTING&quot;,&quot;EXECUTED&quot;,&quot;DEPROVISIONING&quot;,&quot;DEPROVISIONED&quot;,&quot;DONE&quot;,&quot;CANCELLED&quot;,&quot;FAILED&quot;.
        /// </param>
        /// <param name="maxPageSize"> Number of results in response. </param>
        /// <param name="testId"> Unique name for load test, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<TestRunModelResourceList>> ListTestRunsSearchAsync(string orderBy = null, string continuationToken = null, string search = null, DateTimeOffset? executionFrom = null, DateTimeOffset? executionTo = null, string status = null, int? maxPageSize = null, string testId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListTestRunsSearchRequest(orderBy, continuationToken, search, executionFrom, executionTo, status, maxPageSize, testId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModelResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TestRunModelResourceList.DeserializeTestRunModelResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get all test runs with given filters. </summary>
        /// <param name="orderBy"> Sort on one of the field - status, displayName, executedDateTime in (field asc/desc) format. eg: displayName asc. </param>
        /// <param name="continuationToken"> Continuation token to get the next page of response. </param>
        /// <param name="search"> Filter search based on searchable fields - description, executedUser. </param>
        /// <param name="executionFrom"> The end DateTime(ISO 8601 literal format) of test-run execution time filter range. </param>
        /// <param name="executionTo"> The start DateTime(ISO 8601 literal format) of test-run execution time filter range. </param>
        /// <param name="status">
        /// Comma separated list of test run status, value can be -  &quot;ACCEPTED&quot;, &quot;NOTSTARTED&quot;,&quot;PROVISIONING&quot;,&quot;PROVISIONED&quot;,&quot;CONFIGURING&quot;,
        /// &quot;CONFIGURED&quot;,&quot;EXECUTING&quot;,&quot;EXECUTED&quot;,&quot;DEPROVISIONING&quot;,&quot;DEPROVISIONED&quot;,&quot;DONE&quot;,&quot;CANCELLED&quot;,&quot;FAILED&quot;.
        /// </param>
        /// <param name="maxPageSize"> Number of results in response. </param>
        /// <param name="testId"> Unique name for load test, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<TestRunModelResourceList> ListTestRunsSearch(string orderBy = null, string continuationToken = null, string search = null, DateTimeOffset? executionFrom = null, DateTimeOffset? executionTo = null, string status = null, int? maxPageSize = null, string testId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListTestRunsSearchRequest(orderBy, continuationToken, search, executionFrom, executionTo, status, maxPageSize, testId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModelResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TestRunModelResourceList.DeserializeTestRunModelResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopTestRunRequest(string testRunId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/", false);
            uri.AppendPath(testRunId, true);
            uri.AppendPath(":stop", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Stop test run by name. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public async Task<Response<TestRunModel>> StopTestRunAsync(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateStopTestRunRequest(testRunId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TestRunModel.DeserializeTestRunModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Stop test run by name. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public Response<TestRunModel> StopTestRun(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateStopTestRunRequest(testRunId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TestRunModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TestRunModel.DeserializeTestRunModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestRunClientMetricsRequest(string testRunId, ClientMetricsRequestModel body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/", false);
            uri.AppendPath(testRunId, true);
            uri.AppendPath("/clientMetrics", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Get all client metrics for a load test run. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="body"> Client metrics request model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> or <paramref name="body"/> is null. </exception>
        public async Task<Response<ClientMetricsResults>> GetTestRunClientMetricsAsync(string testRunId, ClientMetricsRequestModel body, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateGetTestRunClientMetricsRequest(testRunId, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientMetricsResults value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ClientMetricsResults.DeserializeClientMetricsResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get all client metrics for a load test run. </summary>
        /// <param name="testRunId"> Unique name of the load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="body"> Client metrics request model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> or <paramref name="body"/> is null. </exception>
        public Response<ClientMetricsResults> GetTestRunClientMetrics(string testRunId, ClientMetricsRequestModel body, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateGetTestRunClientMetricsRequest(testRunId, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientMetricsResults value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ClientMetricsResults.DeserializeClientMetricsResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestRunClientMetricsFiltersRequest(string testRunId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/testruns/", false);
            uri.AppendPath(testRunId, true);
            uri.AppendPath("/clientMetricsFilters", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get all filters that are supported for client metrics for a given load test run. </summary>
        /// <param name="testRunId"> Unique name for load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public async Task<Response<ClientMetricsFilters>> GetTestRunClientMetricsFiltersAsync(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateGetTestRunClientMetricsFiltersRequest(testRunId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientMetricsFilters value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ClientMetricsFilters.DeserializeClientMetricsFilters(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get all filters that are supported for client metrics for a given load test run. </summary>
        /// <param name="testRunId"> Unique name for load test run, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="testRunId"/> is null. </exception>
        public Response<ClientMetricsFilters> GetTestRunClientMetricsFilters(string testRunId, CancellationToken cancellationToken = default)
        {
            if (testRunId == null)
            {
                throw new ArgumentNullException(nameof(testRunId));
            }

            using var message = CreateGetTestRunClientMetricsFiltersRequest(testRunId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientMetricsFilters value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ClientMetricsFilters.DeserializeClientMetricsFilters(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
