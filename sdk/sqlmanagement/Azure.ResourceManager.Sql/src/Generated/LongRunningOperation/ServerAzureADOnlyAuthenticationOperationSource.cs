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

namespace Azure.ResourceManager.Sql
{
    internal class ServerAzureADOnlyAuthenticationOperationSource : IOperationSource<ServerAzureADOnlyAuthenticationResource>
    {
        private readonly ArmClient _client;

        internal ServerAzureADOnlyAuthenticationOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerAzureADOnlyAuthenticationResource IOperationSource<ServerAzureADOnlyAuthenticationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerAzureADOnlyAuthenticationData.DeserializeServerAzureADOnlyAuthenticationData(document.RootElement);
            return new ServerAzureADOnlyAuthenticationResource(_client, data);
        }

        async ValueTask<ServerAzureADOnlyAuthenticationResource> IOperationSource<ServerAzureADOnlyAuthenticationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerAzureADOnlyAuthenticationData.DeserializeServerAzureADOnlyAuthenticationData(document.RootElement);
            return new ServerAzureADOnlyAuthenticationResource(_client, data);
        }
    }
}
