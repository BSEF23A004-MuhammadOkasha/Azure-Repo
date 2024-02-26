// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    internal partial class GlobalRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GlobalRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GlobalRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-02-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetDeletedWebAppRequest(string subscriptionId, string deletedSiteId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Web/deletedSites/", false);
            uri.AppendPath(deletedSiteId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Description for Get deleted app for a subscription. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="deletedSiteId"> The numeric ID of the deleted app, e.g. 12345. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DeletedSiteData>> GetDeletedWebAppAsync(string subscriptionId, string deletedSiteId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (deletedSiteId == null)
            {
                throw new ArgumentNullException(nameof(deletedSiteId));
            }
            if (deletedSiteId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedSiteId));
            }

            using var message = CreateGetDeletedWebAppRequest(subscriptionId, deletedSiteId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeletedSiteData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeletedSiteData.DeserializeDeletedSiteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DeletedSiteData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Description for Get deleted app for a subscription. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="deletedSiteId"> The numeric ID of the deleted app, e.g. 12345. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DeletedSiteData> GetDeletedWebApp(string subscriptionId, string deletedSiteId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (deletedSiteId == null)
            {
                throw new ArgumentNullException(nameof(deletedSiteId));
            }
            if (deletedSiteId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedSiteId));
            }

            using var message = CreateGetDeletedWebAppRequest(subscriptionId, deletedSiteId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeletedSiteData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeletedSiteData.DeserializeDeletedSiteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DeletedSiteData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDeletedWebAppSnapshotsRequest(string subscriptionId, string deletedSiteId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Web/deletedSites/", false);
            uri.AppendPath(deletedSiteId, true);
            uri.AppendPath("/snapshots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Description for Get all deleted apps for a subscription. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="deletedSiteId"> The numeric ID of the deleted app, e.g. 12345. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<AppSnapshot>>> GetDeletedWebAppSnapshotsAsync(string subscriptionId, string deletedSiteId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (deletedSiteId == null)
            {
                throw new ArgumentNullException(nameof(deletedSiteId));
            }
            if (deletedSiteId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedSiteId));
            }

            using var message = CreateGetDeletedWebAppSnapshotsRequest(subscriptionId, deletedSiteId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<AppSnapshot> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<AppSnapshot> array = new List<AppSnapshot>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(AppSnapshot.DeserializeAppSnapshot(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Description for Get all deleted apps for a subscription. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="deletedSiteId"> The numeric ID of the deleted app, e.g. 12345. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="deletedSiteId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<AppSnapshot>> GetDeletedWebAppSnapshots(string subscriptionId, string deletedSiteId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (deletedSiteId == null)
            {
                throw new ArgumentNullException(nameof(deletedSiteId));
            }
            if (deletedSiteId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedSiteId));
            }

            using var message = CreateGetDeletedWebAppSnapshotsRequest(subscriptionId, deletedSiteId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<AppSnapshot> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<AppSnapshot> array = new List<AppSnapshot>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(AppSnapshot.DeserializeAppSnapshot(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
