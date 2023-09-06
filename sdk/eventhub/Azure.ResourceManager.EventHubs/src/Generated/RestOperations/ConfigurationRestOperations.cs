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
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    internal partial class ConfigurationRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConfigurationRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConfigurationRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-10-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreatePatchRequest(string subscriptionId, string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties clusterQuotaConfigurationProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventHub/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/quotaConfiguration/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = clusterQuotaConfigurationProperties;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Replace all specified Event Hubs Cluster settings with those contained in the request body. Leaves the settings not specified in the request body unmodified. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="clusterQuotaConfigurationProperties"> Parameters for creating an Event Hubs Cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="clusterQuotaConfigurationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ClusterQuotaConfigurationProperties>> PatchAsync(string subscriptionId, string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties clusterQuotaConfigurationProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(clusterQuotaConfigurationProperties, nameof(clusterQuotaConfigurationProperties));

            using var message = CreatePatchRequest(subscriptionId, resourceGroupName, clusterName, clusterQuotaConfigurationProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((ClusterQuotaConfigurationProperties)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Replace all specified Event Hubs Cluster settings with those contained in the request body. Leaves the settings not specified in the request body unmodified. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="clusterQuotaConfigurationProperties"> Parameters for creating an Event Hubs Cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="clusterQuotaConfigurationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ClusterQuotaConfigurationProperties> Patch(string subscriptionId, string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties clusterQuotaConfigurationProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(clusterQuotaConfigurationProperties, nameof(clusterQuotaConfigurationProperties));

            using var message = CreatePatchRequest(subscriptionId, resourceGroupName, clusterName, clusterQuotaConfigurationProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((ClusterQuotaConfigurationProperties)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string clusterName)
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
            uri.AppendPath("/providers/Microsoft.EventHub/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/quotaConfiguration/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all Event Hubs Cluster settings - a collection of key/value pairs which represent the quotas and settings imposed on the cluster. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ClusterQuotaConfigurationProperties>> GetAsync(string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all Event Hubs Cluster settings - a collection of key/value pairs which represent the quotas and settings imposed on the cluster. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ClusterQuotaConfigurationProperties> Get(string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClusterQuotaConfigurationProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ClusterQuotaConfigurationProperties.DeserializeClusterQuotaConfigurationProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
