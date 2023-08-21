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
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    internal partial class ViewsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ViewsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ViewsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2017-04-26";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByHubRequest(string subscriptionId, string resourceGroupName, string hubName, string userId)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/views", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("userId", userId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all available views for given user in the specified hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level views. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ViewListResult>> ListByHubAsync(string subscriptionId, string resourceGroupName, string hubName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateListByHubRequest(subscriptionId, resourceGroupName, hubName, userId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ViewListResult.DeserializeViewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all available views for given user in the specified hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level views. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ViewListResult> ListByHub(string subscriptionId, string resourceGroupName, string hubName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateListByHubRequest(subscriptionId, resourceGroupName, hubName, userId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ViewListResult.DeserializeViewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string hubName, string viewName, ViewResourceFormatData data)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/views/", false);
            uri.AppendPath(viewName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a view or updates an existing view in the hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ViewResourceFormatData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string hubName, string viewName, ViewResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, hubName, viewName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewResourceFormatData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ViewResourceFormatData.DeserializeViewResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a view or updates an existing view in the hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ViewResourceFormatData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string hubName, string viewName, ViewResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, hubName, viewName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewResourceFormatData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ViewResourceFormatData.DeserializeViewResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string hubName, string viewName, string userId)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/views/", false);
            uri.AppendPath(viewName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("userId", userId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a view in the hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ViewResourceFormatData>> GetAsync(string subscriptionId, string resourceGroupName, string hubName, string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, hubName, viewName, userId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewResourceFormatData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ViewResourceFormatData.DeserializeViewResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ViewResourceFormatData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a view in the hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ViewResourceFormatData> Get(string subscriptionId, string resourceGroupName, string hubName, string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, hubName, viewName, userId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewResourceFormatData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ViewResourceFormatData.DeserializeViewResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ViewResourceFormatData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string hubName, string viewName, string userId)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/views/", false);
            uri.AppendPath(viewName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("userId", userId, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a view in the specified hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string hubName, string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, hubName, viewName, userId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a view in the specified hub. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string hubName, string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, hubName, viewName, userId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByHubNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string hubName, string userId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all available views for given user in the specified hub. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level views. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ViewListResult>> ListByHubNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string hubName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateListByHubNextPageRequest(nextLink, subscriptionId, resourceGroupName, hubName, userId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ViewListResult.DeserializeViewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all available views for given user in the specified hub. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level views. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="userId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ViewListResult> ListByHubNextPage(string nextLink, string subscriptionId, string resourceGroupName, string hubName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var message = CreateListByHubNextPageRequest(nextLink, subscriptionId, resourceGroupName, hubName, userId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ViewListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ViewListResult.DeserializeViewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
