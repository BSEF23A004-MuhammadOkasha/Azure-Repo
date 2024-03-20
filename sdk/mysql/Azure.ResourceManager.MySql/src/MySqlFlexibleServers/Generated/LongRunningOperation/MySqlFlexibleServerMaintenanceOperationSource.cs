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

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    internal class MySqlFlexibleServerMaintenanceOperationSource : IOperationSource<MySqlFlexibleServerMaintenanceResource>
    {
        private readonly ArmClient _client;

        internal MySqlFlexibleServerMaintenanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlFlexibleServerMaintenanceResource IOperationSource<MySqlFlexibleServerMaintenanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlFlexibleServerMaintenanceData.DeserializeMySqlFlexibleServerMaintenanceData(document.RootElement);
            return new MySqlFlexibleServerMaintenanceResource(_client, data);
        }

        async ValueTask<MySqlFlexibleServerMaintenanceResource> IOperationSource<MySqlFlexibleServerMaintenanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlFlexibleServerMaintenanceData.DeserializeMySqlFlexibleServerMaintenanceData(document.RootElement);
            return new MySqlFlexibleServerMaintenanceResource(_client, data);
        }
    }
}
