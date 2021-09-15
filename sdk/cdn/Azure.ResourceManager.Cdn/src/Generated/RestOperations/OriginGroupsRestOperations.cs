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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    internal partial class OriginGroupsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of OriginGroupsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public OriginGroupsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetAllByEndpointRequest(string resourceGroupName, string profileName, string endpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/originGroups", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all of the existing origin groups within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="endpointName"/> is null. </exception>
        public async Task<Response<OriginGroupListResult>> GetAllByEndpointAsync(string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateGetAllByEndpointRequest(resourceGroupName, profileName, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OriginGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OriginGroupListResult.DeserializeOriginGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the existing origin groups within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="endpointName"/> is null. </exception>
        public Response<OriginGroupListResult> GetAllByEndpoint(string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateGetAllByEndpointRequest(resourceGroupName, profileName, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OriginGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OriginGroupListResult.DeserializeOriginGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string profileName, string endpointName, string originGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/originGroups/", false);
            uri.AppendPath(originGroupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets an existing origin group within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, or <paramref name="originGroupName"/> is null. </exception>
        public async Task<Response<OriginGroupData>> GetAsync(string resourceGroupName, string profileName, string endpointName, string originGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var message = CreateGetRequest(resourceGroupName, profileName, endpointName, originGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OriginGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OriginGroupData.DeserializeOriginGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((OriginGroupData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets an existing origin group within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, or <paramref name="originGroupName"/> is null. </exception>
        public Response<OriginGroupData> Get(string resourceGroupName, string profileName, string endpointName, string originGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var message = CreateGetRequest(resourceGroupName, profileName, endpointName, originGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OriginGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OriginGroupData.DeserializeOriginGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((OriginGroupData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupData originGroup)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/originGroups/", false);
            uri.AppendPath(originGroupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(originGroup);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates a new origin group within the specified endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroup"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="originGroupName"/>, or <paramref name="originGroup"/> is null. </exception>
        public async Task<Response> CreateAsync(string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupData originGroup, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            using var message = CreateCreateRequest(resourceGroupName, profileName, endpointName, originGroupName, originGroup);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new origin group within the specified endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroup"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="originGroupName"/>, or <paramref name="originGroup"/> is null. </exception>
        public Response Create(string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupData originGroup, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            using var message = CreateCreateRequest(resourceGroupName, profileName, endpointName, originGroupName, originGroup);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupUpdateParameters originGroupUpdateProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/originGroups/", false);
            uri.AppendPath(originGroupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(originGroupUpdateProperties);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Updates an existing origin group within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroupUpdateProperties"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="originGroupName"/>, or <paramref name="originGroupUpdateProperties"/> is null. </exception>
        public async Task<Response> UpdateAsync(string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupUpdateParameters originGroupUpdateProperties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }
            if (originGroupUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(originGroupUpdateProperties));
            }

            using var message = CreateUpdateRequest(resourceGroupName, profileName, endpointName, originGroupName, originGroupUpdateProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates an existing origin group within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroupUpdateProperties"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="originGroupName"/>, or <paramref name="originGroupUpdateProperties"/> is null. </exception>
        public Response Update(string resourceGroupName, string profileName, string endpointName, string originGroupName, OriginGroupUpdateParameters originGroupUpdateProperties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }
            if (originGroupUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(originGroupUpdateProperties));
            }

            using var message = CreateUpdateRequest(resourceGroupName, profileName, endpointName, originGroupName, originGroupUpdateProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string profileName, string endpointName, string originGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/endpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/originGroups/", false);
            uri.AppendPath(originGroupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes an existing origin group within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, or <paramref name="originGroupName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string profileName, string endpointName, string originGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, profileName, endpointName, originGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes an existing origin group within an endpoint. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, or <paramref name="originGroupName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string profileName, string endpointName, string originGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, profileName, endpointName, originGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByEndpointNextPageRequest(string nextLink, string resourceGroupName, string profileName, string endpointName)
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

        /// <summary> Lists all of the existing origin groups within an endpoint. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="endpointName"/> is null. </exception>
        public async Task<Response<OriginGroupListResult>> GetAllByEndpointNextPageAsync(string nextLink, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateGetAllByEndpointNextPageRequest(nextLink, resourceGroupName, profileName, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OriginGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OriginGroupListResult.DeserializeOriginGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the existing origin groups within an endpoint. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="endpointName"/> is null. </exception>
        public Response<OriginGroupListResult> GetAllByEndpointNextPage(string nextLink, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var message = CreateGetAllByEndpointNextPageRequest(nextLink, resourceGroupName, profileName, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OriginGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OriginGroupListResult.DeserializeOriginGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
