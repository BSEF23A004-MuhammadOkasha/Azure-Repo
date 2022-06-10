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

namespace Azure.ResourceManager.Compute
{
    internal class VirtualMachineRunCommandOperationSource : IOperationSource<VirtualMachineRunCommandResource>
    {
        private readonly ArmClient _client;

        internal VirtualMachineRunCommandOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualMachineRunCommandResource IOperationSource<VirtualMachineRunCommandResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineRunCommandData.DeserializeVirtualMachineRunCommandData(document.RootElement);
            return new VirtualMachineRunCommandResource(_client, data);
        }

        async ValueTask<VirtualMachineRunCommandResource> IOperationSource<VirtualMachineRunCommandResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineRunCommandData.DeserializeVirtualMachineRunCommandData(document.RootElement);
            return new VirtualMachineRunCommandResource(_client, data);
        }
    }
}
