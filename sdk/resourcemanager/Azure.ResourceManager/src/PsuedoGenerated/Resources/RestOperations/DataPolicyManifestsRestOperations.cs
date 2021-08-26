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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    internal partial class DataPolicyManifestsRestOperations
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of DataPolicyManifestsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        public DataPolicyManifestsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetByPolicyModeRequest(string policyMode)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.Authorization/dataPolicyManifests/", false);
            uri.AppendPath(policyMode, true);
            uri.AppendQuery("api-version", "2020-09-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> This operation retrieves the data policy manifest with the given policy mode. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public async Task<Response<DataPolicyManifestData>> GetByPolicyModeAsync(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var message = CreateGetByPolicyModeRequest(policyMode);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataPolicyManifestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataPolicyManifestData.DeserializeDataPolicyManifestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataPolicyManifestData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation retrieves the data policy manifest with the given policy mode. </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public Response<DataPolicyManifestData> GetByPolicyMode(string policyMode, CancellationToken cancellationToken = default)
        {
            if (policyMode == null)
            {
                throw new ArgumentNullException(nameof(policyMode));
            }

            using var message = CreateGetByPolicyModeRequest(policyMode);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataPolicyManifestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataPolicyManifestData.DeserializeDataPolicyManifestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataPolicyManifestData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllRequest(string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.Authorization/dataPolicyManifests", false);
            uri.AppendQuery("api-version", "2020-09-01", true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, false);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: &quot;$filter=namespace eq &apos;{0}&apos;&quot;. If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &quot;namespace eq &apos;{value}&apos;&quot;. If $filter is not provided, no filtering is performed. If $filter=namespace eq &apos;{value}&apos; is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DataPolicyManifestListResult>> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllRequest(filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataPolicyManifestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataPolicyManifestListResult.DeserializeDataPolicyManifestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: &quot;$filter=namespace eq &apos;{0}&apos;&quot;. If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &quot;namespace eq &apos;{value}&apos;&quot;. If $filter is not provided, no filtering is performed. If $filter=namespace eq &apos;{value}&apos; is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DataPolicyManifestListResult> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllRequest(filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataPolicyManifestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataPolicyManifestListResult.DeserializeDataPolicyManifestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: &quot;$filter=namespace eq &apos;{0}&apos;&quot;. If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &quot;namespace eq &apos;{value}&apos;&quot;. If $filter is not provided, no filtering is performed. If $filter=namespace eq &apos;{value}&apos; is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<DataPolicyManifestListResult>> GetAllNextPageAsync(string nextLink, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataPolicyManifestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataPolicyManifestListResult.DeserializeDataPolicyManifestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: &quot;$filter=namespace eq &apos;{0}&apos;&quot;. If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &quot;namespace eq &apos;{value}&apos;&quot;. If $filter is not provided, no filtering is performed. If $filter=namespace eq &apos;{value}&apos; is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<DataPolicyManifestListResult> GetAllNextPage(string nextLink, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataPolicyManifestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataPolicyManifestListResult.DeserializeDataPolicyManifestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
