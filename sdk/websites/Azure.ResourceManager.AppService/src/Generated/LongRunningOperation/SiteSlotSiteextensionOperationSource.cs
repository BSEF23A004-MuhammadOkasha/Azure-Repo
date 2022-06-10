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
    internal class SiteSlotSiteextensionOperationSource : IOperationSource<SiteSlotSiteextensionResource>
    {
        private readonly ArmClient _client;

        internal SiteSlotSiteextensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteSlotSiteextensionResource IOperationSource<SiteSlotSiteextensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteExtensionInfoData.DeserializeSiteExtensionInfoData(document.RootElement);
            return new SiteSlotSiteextensionResource(_client, data);
        }

        async ValueTask<SiteSlotSiteextensionResource> IOperationSource<SiteSlotSiteextensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteExtensionInfoData.DeserializeSiteExtensionInfoData(document.RootElement);
            return new SiteSlotSiteextensionResource(_client, data);
        }
    }
}
