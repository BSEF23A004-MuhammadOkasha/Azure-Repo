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
    internal class ApplicationGatewayOperationSource : IOperationSource<ApplicationGatewayResource>
    {
        private readonly ArmClient _client;

        internal ApplicationGatewayOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApplicationGatewayResource IOperationSource<ApplicationGatewayResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApplicationGatewayData.DeserializeApplicationGatewayData(document.RootElement);
            return new ApplicationGatewayResource(_client, data);
        }

        async ValueTask<ApplicationGatewayResource> IOperationSource<ApplicationGatewayResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApplicationGatewayData.DeserializeApplicationGatewayData(document.RootElement);
            return new ApplicationGatewayResource(_client, data);
        }
    }
}
