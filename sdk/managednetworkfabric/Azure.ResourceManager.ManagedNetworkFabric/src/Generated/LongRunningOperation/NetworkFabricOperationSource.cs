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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricOperationSource : IOperationSource<NetworkFabricResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricResource IOperationSource<NetworkFabricResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFabricData.DeserializeNetworkFabricData(document.RootElement);
            return new NetworkFabricResource(_client, data);
        }

        async ValueTask<NetworkFabricResource> IOperationSource<NetworkFabricResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFabricData.DeserializeNetworkFabricData(document.RootElement);
            return new NetworkFabricResource(_client, data);
        }
    }
}
