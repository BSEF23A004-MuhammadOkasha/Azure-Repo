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

namespace Azure.ResourceManager.Workloads
{
    internal class SapVirtualInstanceOperationSource : IOperationSource<SapVirtualInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapVirtualInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapVirtualInstanceResource IOperationSource<SapVirtualInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SapVirtualInstanceData.DeserializeSapVirtualInstanceData(document.RootElement);
            return new SapVirtualInstanceResource(_client, data);
        }

        async ValueTask<SapVirtualInstanceResource> IOperationSource<SapVirtualInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SapVirtualInstanceData.DeserializeSapVirtualInstanceData(document.RootElement);
            return new SapVirtualInstanceResource(_client, data);
        }
    }
}
