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

namespace Azure.ResourceManager.ApiManagement
{
    internal class ApiManagementPortalRevisionOperationSource : Core.IOperationSource<ApiManagementPortalRevisionResource>
    {
        private readonly ArmClient _client;

        internal ApiManagementPortalRevisionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApiManagementPortalRevisionResource Core.IOperationSource<ApiManagementPortalRevisionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApiManagementPortalRevisionData.DeserializeApiManagementPortalRevisionData(document.RootElement);
            return new ApiManagementPortalRevisionResource(_client, data);
        }

        async ValueTask<ApiManagementPortalRevisionResource> Core.IOperationSource<ApiManagementPortalRevisionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApiManagementPortalRevisionData.DeserializeApiManagementPortalRevisionData(document.RootElement);
            return new ApiManagementPortalRevisionResource(_client, data);
        }
    }
}
