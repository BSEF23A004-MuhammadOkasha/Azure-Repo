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
    internal class HostingEnvironmentWorkerPoolOperationSource : Core.IOperationSource<HostingEnvironmentWorkerPoolResource>
    {
        private readonly ArmClient _client;

        internal HostingEnvironmentWorkerPoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        HostingEnvironmentWorkerPoolResource Core.IOperationSource<HostingEnvironmentWorkerPoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServiceWorkerPoolData.DeserializeAppServiceWorkerPoolData(document.RootElement);
            return new HostingEnvironmentWorkerPoolResource(_client, data);
        }

        async ValueTask<HostingEnvironmentWorkerPoolResource> Core.IOperationSource<HostingEnvironmentWorkerPoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServiceWorkerPoolData.DeserializeAppServiceWorkerPoolData(document.RootElement);
            return new HostingEnvironmentWorkerPoolResource(_client, data);
        }
    }
}
