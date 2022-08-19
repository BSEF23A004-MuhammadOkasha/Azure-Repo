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

namespace Azure.ResourceManager.NetApp
{
    internal class VolumeGroupDetailOperationSource : IOperationSource<VolumeGroupDetailResource>
    {
        private readonly ArmClient _client;

        internal VolumeGroupDetailOperationSource(ArmClient client)
        {
            _client = client;
        }

        VolumeGroupDetailResource IOperationSource<VolumeGroupDetailResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VolumeGroupDetailData.DeserializeVolumeGroupDetailData(document.RootElement);
            return new VolumeGroupDetailResource(_client, data);
        }

        async ValueTask<VolumeGroupDetailResource> IOperationSource<VolumeGroupDetailResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VolumeGroupDetailData.DeserializeVolumeGroupDetailData(document.RootElement);
            return new VolumeGroupDetailResource(_client, data);
        }
    }
}
