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

namespace Azure.ResourceManager.AppService
{
    internal class SiteSlotPrivateEndpointConnectionOperationSource : Core.IOperationSource<SiteSlotPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal SiteSlotPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteSlotPrivateEndpointConnectionResource Core.IOperationSource<SiteSlotPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(document.RootElement);
            return new SiteSlotPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<SiteSlotPrivateEndpointConnectionResource> Core.IOperationSource<SiteSlotPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(document.RootElement);
            return new SiteSlotPrivateEndpointConnectionResource(_client, data);
        }
    }
}
