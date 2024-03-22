// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ElasticSan.Models;

namespace Azure.ResourceManager.ElasticSan
{
    internal partial class VolumeSnapshotsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VolumeSnapshotsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VolumeSnapshotsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByVolumeGroupRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string filter)
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
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendPath("/snapshots", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List Snapshots in a VolumeGroup or List Snapshots by Volume (name) in a VolumeGroup using filter. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="filter"> Specify $filter='volumeName eq &lt;volume name&gt;' to filter on volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SnapshotList>> ListByVolumeGroupAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateListByVolumeGroupRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SnapshotList.DeserializeSnapshotList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Snapshots in a VolumeGroup or List Snapshots by Volume (name) in a VolumeGroup using filter. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="filter"> Specify $filter='volumeName eq &lt;volume name&gt;' to filter on volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SnapshotList> ListByVolumeGroup(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateListByVolumeGroupRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SnapshotList.DeserializeSnapshotList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName, ElasticSanSnapshotData data)
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
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(snapshotName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ElasticSanSnapshotData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a Volume Snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="data"> Snapshot object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/>, <paramref name="snapshotName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName, ElasticSanSnapshotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a Volume Snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="data"> Snapshot object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/>, <paramref name="snapshotName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName, ElasticSanSnapshotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName)
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
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(snapshotName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a Volume Snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a Volume Snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName)
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
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(snapshotName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a Volume Snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ElasticSanSnapshotData>> GetAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanSnapshotData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ElasticSanSnapshotData.DeserializeElasticSanSnapshotData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ElasticSanSnapshotData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Volume Snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ElasticSanSnapshotData> Get(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, snapshotName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanSnapshotData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ElasticSanSnapshotData.DeserializeElasticSanSnapshotData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ElasticSanSnapshotData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVolumeGroupNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string filter)
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

        /// <summary> List Snapshots in a VolumeGroup or List Snapshots by Volume (name) in a VolumeGroup using filter. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="filter"> Specify $filter='volumeName eq &lt;volume name&gt;' to filter on volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SnapshotList>> ListByVolumeGroupNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateListByVolumeGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SnapshotList.DeserializeSnapshotList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Snapshots in a VolumeGroup or List Snapshots by Volume (name) in a VolumeGroup using filter. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="filter"> Specify $filter='volumeName eq &lt;volume name&gt;' to filter on volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SnapshotList> ListByVolumeGroupNextPage(string nextLink, string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateListByVolumeGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SnapshotList.DeserializeSnapshotList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
