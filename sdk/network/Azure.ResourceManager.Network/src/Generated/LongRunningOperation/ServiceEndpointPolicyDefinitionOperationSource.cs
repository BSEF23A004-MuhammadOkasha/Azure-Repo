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

namespace Azure.ResourceManager.Network
{
    internal class ServiceEndpointPolicyDefinitionOperationSource : IOperationSource<ServiceEndpointPolicyDefinition>
    {
        private readonly ArmClient _client;

        internal ServiceEndpointPolicyDefinitionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceEndpointPolicyDefinition IOperationSource<ServiceEndpointPolicyDefinition>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(document.RootElement);
            return new ServiceEndpointPolicyDefinition(_client, data);
        }

        async ValueTask<ServiceEndpointPolicyDefinition> IOperationSource<ServiceEndpointPolicyDefinition>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(document.RootElement);
            return new ServiceEndpointPolicyDefinition(_client, data);
        }
    }
}
