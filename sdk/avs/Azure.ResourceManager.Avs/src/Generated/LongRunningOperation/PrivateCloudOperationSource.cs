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
    internal class PrivateCloudOperationSource : IOperationSource<PrivateCloudResource>
    {
        private readonly ArmClient _client;

        internal PrivateCloudOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateCloudResource IOperationSource<PrivateCloudResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateCloudData.DeserializePrivateCloudData(document.RootElement);
            return new PrivateCloudResource(_client, data);
        }

        async ValueTask<PrivateCloudResource> IOperationSource<PrivateCloudResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateCloudData.DeserializePrivateCloudData(document.RootElement);
            return new PrivateCloudResource(_client, data);
        }
    }
}
