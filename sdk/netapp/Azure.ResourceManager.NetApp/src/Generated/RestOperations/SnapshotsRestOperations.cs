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
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    internal partial class SnapshotsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SnapshotsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SnapshotsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-07-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName)
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
            uri.AppendPath("/providers/Microsoft.NetApp/netAppAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/capacityPools/", false);
            uri.AppendPath(poolName, true);
            uri.AppendPath("/volumes/", false);
            uri.AppendPath(volumeName, true);
            uri.AppendPath("/snapshots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List all snapshots associated with the volume. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/> or <paramref name="volumeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/> or <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SnapshotsList>> ListAsync(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SnapshotsList.DeserializeSnapshotsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all snapshots associated with the volume. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/> or <paramref name="volumeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/> or <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SnapshotsList> List(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SnapshotsList.DeserializeSnapshotsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
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
            uri.AppendPath("/providers/Microsoft.NetApp/netAppAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/capacityPools/", false);
            uri.AppendPath(poolName, true);
            uri.AppendPath("/volumes/", false);
            uri.AppendPath(volumeName, true);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(snapshotName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get details of the specified snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetAppVolumeSnapshotData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetAppVolumeSnapshotData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NetAppVolumeSnapshotData.DeserializeNetAppVolumeSnapshotData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetAppVolumeSnapshotData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get details of the specified snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetAppVolumeSnapshotData> Get(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetAppVolumeSnapshotData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NetAppVolumeSnapshotData.DeserializeNetAppVolumeSnapshotData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetAppVolumeSnapshotData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, NetAppVolumeSnapshotData data)
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
            uri.AppendPath("/providers/Microsoft.NetApp/netAppAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/capacityPools/", false);
            uri.AppendPath(poolName, true);
            uri.AppendPath("/volumes/", false);
            uri.AppendPath(volumeName, true);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(snapshotName, true);
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

        /// <summary> Create the specified snapshot within the given volume. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="data"> Snapshot object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/>, <paramref name="snapshotName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, NetAppVolumeSnapshotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create the specified snapshot within the given volume. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="data"> Snapshot object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/>, <paramref name="snapshotName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, NetAppVolumeSnapshotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
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
            uri.AppendPath("/providers/Microsoft.NetApp/netAppAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/capacityPools/", false);
            uri.AppendPath(poolName, true);
            uri.AppendPath("/volumes/", false);
            uri.AppendPath(volumeName, true);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(snapshotName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
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

        /// <summary> Delete snapshot. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
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

        internal HttpMessage CreateRestoreFilesRequest(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, NetAppVolumeSnapshotRestoreFilesContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.NetApp/netAppAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/capacityPools/", false);
            uri.AppendPath(poolName, true);
            uri.AppendPath("/volumes/", false);
            uri.AppendPath(volumeName, true);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(snapshotName, true);
            uri.AppendPath("/restoreFiles", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Restore the specified files from the specified snapshot to the active filesystem. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="content"> Restore payload supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/>, <paramref name="snapshotName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> RestoreFilesAsync(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, NetAppVolumeSnapshotRestoreFilesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRestoreFilesRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Restore the specified files from the specified snapshot to the active filesystem. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="poolName"> The name of the capacity pool. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="snapshotName"> The name of the snapshot. </param>
        /// <param name="content"> Restore payload supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/>, <paramref name="snapshotName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="poolName"/>, <paramref name="volumeName"/> or <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response RestoreFiles(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, NetAppVolumeSnapshotRestoreFilesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRestoreFilesRequest(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
