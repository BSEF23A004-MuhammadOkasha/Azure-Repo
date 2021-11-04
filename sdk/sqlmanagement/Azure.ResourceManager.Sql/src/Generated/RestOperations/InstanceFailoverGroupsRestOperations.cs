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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal partial class InstanceFailoverGroupsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of InstanceFailoverGroupsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public InstanceFailoverGroupsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null)
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string locationName, string failoverGroupName)
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
            uri.AppendPath("/providers/Microsoft.Sql/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/instanceFailoverGroups/", false);
            uri.AppendPath(failoverGroupName, true);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public async Task<Response<InstanceFailoverGroupData>> GetAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateGetRequest(resourceGroupName, locationName, failoverGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InstanceFailoverGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((InstanceFailoverGroupData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public Response<InstanceFailoverGroupData> Get(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateGetRequest(resourceGroupName, locationName, failoverGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InstanceFailoverGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((InstanceFailoverGroupData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string locationName, string failoverGroupName, InstanceFailoverGroupData parameters)
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
            uri.AppendPath("/providers/Microsoft.Sql/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/instanceFailoverGroups/", false);
            uri.AppendPath(failoverGroupName, true);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, <paramref name="failoverGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string locationName, string failoverGroupName, InstanceFailoverGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, locationName, failoverGroupName, parameters);
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

        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, <paramref name="failoverGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string locationName, string failoverGroupName, InstanceFailoverGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, locationName, failoverGroupName, parameters);
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

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string locationName, string failoverGroupName)
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
            uri.AppendPath("/providers/Microsoft.Sql/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/instanceFailoverGroups/", false);
            uri.AppendPath(failoverGroupName, true);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, locationName, failoverGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, locationName, failoverGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByLocationRequest(string resourceGroupName, string locationName)
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
            uri.AppendPath("/providers/Microsoft.Sql/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/instanceFailoverGroups", false);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists the failover groups in a location. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="locationName"/> is null. </exception>
        public async Task<Response<InstanceFailoverGroupListResult>> ListByLocationAsync(string resourceGroupName, string locationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListByLocationRequest(resourceGroupName, locationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InstanceFailoverGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InstanceFailoverGroupListResult.DeserializeInstanceFailoverGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the failover groups in a location. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="locationName"/> is null. </exception>
        public Response<InstanceFailoverGroupListResult> ListByLocation(string resourceGroupName, string locationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListByLocationRequest(resourceGroupName, locationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InstanceFailoverGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InstanceFailoverGroupListResult.DeserializeInstanceFailoverGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateFailoverRequest(string resourceGroupName, string locationName, string failoverGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/instanceFailoverGroups/", false);
            uri.AppendPath(failoverGroupName, true);
            uri.AppendPath("/failover", false);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Fails over from the current primary managed instance to this managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public async Task<Response> FailoverAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateFailoverRequest(resourceGroupName, locationName, failoverGroupName);
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

        /// <summary> Fails over from the current primary managed instance to this managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public Response Failover(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateFailoverRequest(resourceGroupName, locationName, failoverGroupName);
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

        internal HttpMessage CreateForceFailoverAllowDataLossRequest(string resourceGroupName, string locationName, string failoverGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/instanceFailoverGroups/", false);
            uri.AppendPath(failoverGroupName, true);
            uri.AppendPath("/forceFailoverAllowDataLoss", false);
            uri.AppendQuery("api-version", "2020-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Fails over from the current primary managed instance to this managed instance. This operation might result in data loss. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public async Task<Response> ForceFailoverAllowDataLossAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateForceFailoverAllowDataLossRequest(resourceGroupName, locationName, failoverGroupName);
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

        /// <summary> Fails over from the current primary managed instance to this managed instance. This operation might result in data loss. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public Response ForceFailoverAllowDataLoss(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var message = CreateForceFailoverAllowDataLossRequest(resourceGroupName, locationName, failoverGroupName);
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

        internal HttpMessage CreateListByLocationNextPageRequest(string nextLink, string resourceGroupName, string locationName)
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

        /// <summary> Lists the failover groups in a location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="locationName"/> is null. </exception>
        public async Task<Response<InstanceFailoverGroupListResult>> ListByLocationNextPageAsync(string nextLink, string resourceGroupName, string locationName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListByLocationNextPageRequest(nextLink, resourceGroupName, locationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InstanceFailoverGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InstanceFailoverGroupListResult.DeserializeInstanceFailoverGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the failover groups in a location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="locationName"/> is null. </exception>
        public Response<InstanceFailoverGroupListResult> ListByLocationNextPage(string nextLink, string resourceGroupName, string locationName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListByLocationNextPageRequest(nextLink, resourceGroupName, locationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InstanceFailoverGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InstanceFailoverGroupListResult.DeserializeInstanceFailoverGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
