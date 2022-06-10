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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class VMwareClusterOperationSource : IOperationSource<VMwareClusterResource>
    {
        private readonly ArmClient _client;

        internal VMwareClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        VMwareClusterResource IOperationSource<VMwareClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VMwareClusterData.DeserializeVMwareClusterData(document.RootElement);
            return new VMwareClusterResource(_client, data);
        }

        async ValueTask<VMwareClusterResource> IOperationSource<VMwareClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VMwareClusterData.DeserializeVMwareClusterData(document.RootElement);
            return new VMwareClusterResource(_client, data);
        }
    }
}
