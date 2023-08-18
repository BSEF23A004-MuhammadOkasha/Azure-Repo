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
    internal class AppServiceEnvironmentOperationSource : Core.IOperationSource<AppServiceEnvironmentResource>
    {
        private readonly ArmClient _client;

        internal AppServiceEnvironmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppServiceEnvironmentResource Core.IOperationSource<AppServiceEnvironmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServiceEnvironmentData.DeserializeAppServiceEnvironmentData(document.RootElement);
            return new AppServiceEnvironmentResource(_client, data);
        }

        async ValueTask<AppServiceEnvironmentResource> Core.IOperationSource<AppServiceEnvironmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServiceEnvironmentData.DeserializeAppServiceEnvironmentData(document.RootElement);
            return new AppServiceEnvironmentResource(_client, data);
        }
    }
}
