// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StorageSync
{
    internal class StorageSyncServerEndpointOperationSource : IOperationSource<StorageSyncServerEndpointResource>
    {
        private readonly ArmClient _client;

        internal StorageSyncServerEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageSyncServerEndpointResource IOperationSource<StorageSyncServerEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageSyncServerEndpointData.DeserializeStorageSyncServerEndpointData(document.RootElement);
            return new StorageSyncServerEndpointResource(_client, data);
        }

        async ValueTask<StorageSyncServerEndpointResource> IOperationSource<StorageSyncServerEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageSyncServerEndpointData.DeserializeStorageSyncServerEndpointData(document.RootElement);
            return new StorageSyncServerEndpointResource(_client, data);
        }
    }
}
