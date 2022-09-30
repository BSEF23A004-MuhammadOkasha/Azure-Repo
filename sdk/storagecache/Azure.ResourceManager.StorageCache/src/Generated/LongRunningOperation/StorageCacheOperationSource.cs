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

namespace Azure.ResourceManager.StorageCache
{
    internal class StorageCacheOperationSource : IOperationSource<StorageCacheResource>
    {
        private readonly ArmClient _client;

        internal StorageCacheOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageCacheResource IOperationSource<StorageCacheResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageCacheData.DeserializeStorageCacheData(document.RootElement);
            return new StorageCacheResource(_client, data);
        }

        async ValueTask<StorageCacheResource> IOperationSource<StorageCacheResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageCacheData.DeserializeStorageCacheData(document.RootElement);
            return new StorageCacheResource(_client, data);
        }
    }
}
