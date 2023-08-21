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

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppPlatformStorageOperationSource : IOperationSource<AppPlatformStorageResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformStorageOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformStorageResource IOperationSource<AppPlatformStorageResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppPlatformStorageData.DeserializeAppPlatformStorageData(document.RootElement);
            return new AppPlatformStorageResource(_client, data);
        }

        async ValueTask<AppPlatformStorageResource> IOperationSource<AppPlatformStorageResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppPlatformStorageData.DeserializeAppPlatformStorageData(document.RootElement);
            return new AppPlatformStorageResource(_client, data);
        }
    }
}
