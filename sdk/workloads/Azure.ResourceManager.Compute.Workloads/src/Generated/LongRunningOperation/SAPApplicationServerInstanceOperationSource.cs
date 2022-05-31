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

namespace Azure.ResourceManager.Compute.Workloads
{
    internal class SAPApplicationServerInstanceOperationSource : IOperationSource<SAPApplicationServerInstanceResource>
    {
        private readonly ArmClient _client;

        internal SAPApplicationServerInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SAPApplicationServerInstanceResource IOperationSource<SAPApplicationServerInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SAPApplicationServerInstanceData.DeserializeSAPApplicationServerInstanceData(document.RootElement);
            return new SAPApplicationServerInstanceResource(_client, data);
        }

        async ValueTask<SAPApplicationServerInstanceResource> IOperationSource<SAPApplicationServerInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SAPApplicationServerInstanceData.DeserializeSAPApplicationServerInstanceData(document.RootElement);
            return new SAPApplicationServerInstanceResource(_client, data);
        }
    }
}
