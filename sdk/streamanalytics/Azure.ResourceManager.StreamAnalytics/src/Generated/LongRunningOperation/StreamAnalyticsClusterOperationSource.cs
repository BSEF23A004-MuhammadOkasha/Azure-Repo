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

namespace Azure.ResourceManager.StreamAnalytics
{
    internal class StreamAnalyticsClusterOperationSource : IOperationSource<StreamAnalyticsClusterResource>
    {
        private readonly ArmClient _client;

        internal StreamAnalyticsClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        StreamAnalyticsClusterResource IOperationSource<StreamAnalyticsClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StreamAnalyticsClusterData.DeserializeStreamAnalyticsClusterData(document.RootElement);
            return new StreamAnalyticsClusterResource(_client, data);
        }

        async ValueTask<StreamAnalyticsClusterResource> IOperationSource<StreamAnalyticsClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StreamAnalyticsClusterData.DeserializeStreamAnalyticsClusterData(document.RootElement);
            return new StreamAnalyticsClusterResource(_client, data);
        }
    }
}
