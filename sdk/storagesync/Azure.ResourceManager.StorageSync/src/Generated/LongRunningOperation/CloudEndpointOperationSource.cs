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
    internal class CloudEndpointOperationSource : Core.IOperationSource<CloudEndpointResource>
    {
        private readonly ArmClient _client;

        internal CloudEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        CloudEndpointResource Core.IOperationSource<CloudEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CloudEndpointData.DeserializeCloudEndpointData(document.RootElement);
            return new CloudEndpointResource(_client, data);
        }

        async ValueTask<CloudEndpointResource> Core.IOperationSource<CloudEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CloudEndpointData.DeserializeCloudEndpointData(document.RootElement);
            return new CloudEndpointResource(_client, data);
        }
    }
}
