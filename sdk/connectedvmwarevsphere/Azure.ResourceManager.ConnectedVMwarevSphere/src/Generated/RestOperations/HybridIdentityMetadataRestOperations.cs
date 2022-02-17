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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal partial class HybridIdentityMetadataRestOperations
    {
        private readonly string _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of HybridIdentityMetadataRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public HybridIdentityMetadataRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-10-01-preview";
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, HybridIdentityMetadataData body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata/", false);
            uri.AppendPath(metadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Create Or Update HybridIdentityMetadata. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataData>> CreateAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, HybridIdentityMetadataData body = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create Or Update HybridIdentityMetadata. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        public Response<HybridIdentityMetadataData> Create(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, HybridIdentityMetadataData body = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata/", false);
            uri.AppendPath(metadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataData>> GetAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridIdentityMetadataData)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        public Response<HybridIdentityMetadataData> Get(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridIdentityMetadataData)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata/", false);
            uri.AppendPath(metadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Implements HybridIdentityMetadata DELETE method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Implements HybridIdentityMetadata DELETE method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVmRequest(string subscriptionId, string resourceGroupName, string virtualMachineName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataList>> ListByVmAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }

            using var message = CreateListByVmRequest(subscriptionId, resourceGroupName, virtualMachineName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        public Response<HybridIdentityMetadataList> ListByVm(string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }

            using var message = CreateListByVmRequest(subscriptionId, resourceGroupName, virtualMachineName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVmNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string virtualMachineName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        public async Task<Response<HybridIdentityMetadataList>> ListByVmNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }

            using var message = CreateListByVmNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualMachineName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        public Response<HybridIdentityMetadataList> ListByVmNextPage(string nextLink, string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineName));
            }

            using var message = CreateListByVmNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualMachineName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
