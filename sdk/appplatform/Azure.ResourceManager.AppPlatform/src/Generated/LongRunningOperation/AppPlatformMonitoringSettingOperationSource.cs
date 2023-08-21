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
    internal class AppPlatformMonitoringSettingOperationSource : IOperationSource<AppPlatformMonitoringSettingResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformMonitoringSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformMonitoringSettingResource IOperationSource<AppPlatformMonitoringSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppPlatformMonitoringSettingData.DeserializeAppPlatformMonitoringSettingData(document.RootElement);
            return new AppPlatformMonitoringSettingResource(_client, data);
        }

        async ValueTask<AppPlatformMonitoringSettingResource> IOperationSource<AppPlatformMonitoringSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppPlatformMonitoringSettingData.DeserializeAppPlatformMonitoringSettingData(document.RootElement);
            return new AppPlatformMonitoringSettingResource(_client, data);
        }
    }
}
