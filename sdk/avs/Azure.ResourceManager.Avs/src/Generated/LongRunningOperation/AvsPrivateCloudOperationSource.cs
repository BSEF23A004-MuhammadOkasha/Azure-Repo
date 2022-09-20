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
    internal class AvsPrivateCloudOperationSource : IOperationSource<AvsPrivateCloudResource>
    {
        private readonly ArmClient _client;

        internal AvsPrivateCloudOperationSource(ArmClient client)
        {
            _client = client;
        }

        AvsPrivateCloudResource IOperationSource<AvsPrivateCloudResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AvsPrivateCloudData.DeserializeAvsPrivateCloudData(document.RootElement);
            return new AvsPrivateCloudResource(_client, data);
        }

        async ValueTask<AvsPrivateCloudResource> IOperationSource<AvsPrivateCloudResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AvsPrivateCloudData.DeserializeAvsPrivateCloudData(document.RootElement);
            return new AvsPrivateCloudResource(_client, data);
        }
    }
}
