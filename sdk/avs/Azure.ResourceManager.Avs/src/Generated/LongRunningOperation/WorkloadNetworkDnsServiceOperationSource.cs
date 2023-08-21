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

namespace Azure.ResourceManager.Avs
{
    internal class WorkloadNetworkDnsServiceOperationSource : Core.IOperationSource<WorkloadNetworkDnsServiceResource>
    {
        private readonly ArmClient _client;

        internal WorkloadNetworkDnsServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkloadNetworkDnsServiceResource Core.IOperationSource<WorkloadNetworkDnsServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WorkloadNetworkDnsServiceData.DeserializeWorkloadNetworkDnsServiceData(document.RootElement);
            return new WorkloadNetworkDnsServiceResource(_client, data);
        }

        async ValueTask<WorkloadNetworkDnsServiceResource> Core.IOperationSource<WorkloadNetworkDnsServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WorkloadNetworkDnsServiceData.DeserializeWorkloadNetworkDnsServiceData(document.RootElement);
            return new WorkloadNetworkDnsServiceResource(_client, data);
        }
    }
}
