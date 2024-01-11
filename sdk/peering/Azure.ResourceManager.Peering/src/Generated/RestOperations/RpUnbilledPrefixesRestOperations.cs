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
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    internal partial class RpUnbilledPrefixesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RpUnbilledPrefixesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RpUnbilledPrefixesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Peering/peerings/", false);
            uri.AppendPath(peeringName, true);
            uri.AppendPath("/rpUnbilledPrefixes", false);
            if (consolidate != null)
            {
                uri.AppendQuery("consolidate", consolidate.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate)
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
            uri.AppendPath("/providers/Microsoft.Peering/peerings/", false);
            uri.AppendPath(peeringName, true);
            uri.AppendPath("/rpUnbilledPrefixes", false);
            if (consolidate != null)
            {
                uri.AppendQuery("consolidate", consolidate.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all of the RP unbilled prefixes for the specified peering. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The Azure resource group name. </param>
        /// <param name="peeringName"> The peering name. </param>
        /// <param name="consolidate"> Flag to enable consolidation prefixes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RpUnbilledPrefixListResult>> ListAsync(string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, peeringName, consolidate);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RpUnbilledPrefixListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RpUnbilledPrefixListResult.DeserializeRpUnbilledPrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the RP unbilled prefixes for the specified peering. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The Azure resource group name. </param>
        /// <param name="peeringName"> The peering name. </param>
        /// <param name="consolidate"> Flag to enable consolidation prefixes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RpUnbilledPrefixListResult> List(string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, peeringName, consolidate);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RpUnbilledPrefixListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RpUnbilledPrefixListResult.DeserializeRpUnbilledPrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate)
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

        /// <summary> Lists all of the RP unbilled prefixes for the specified peering. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The Azure resource group name. </param>
        /// <param name="peeringName"> The peering name. </param>
        /// <param name="consolidate"> Flag to enable consolidation prefixes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RpUnbilledPrefixListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringName, consolidate);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RpUnbilledPrefixListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RpUnbilledPrefixListResult.DeserializeRpUnbilledPrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the RP unbilled prefixes for the specified peering. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The Azure resource group name. </param>
        /// <param name="peeringName"> The peering name. </param>
        /// <param name="consolidate"> Flag to enable consolidation prefixes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RpUnbilledPrefixListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string peeringName, bool? consolidate = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringName, consolidate);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RpUnbilledPrefixListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RpUnbilledPrefixListResult.DeserializeRpUnbilledPrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
