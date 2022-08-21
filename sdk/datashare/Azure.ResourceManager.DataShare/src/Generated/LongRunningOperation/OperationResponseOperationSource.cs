// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    internal class OperationResponseOperationSource : IOperationSource<OperationResponse>
    {
        OperationResponse IOperationSource<OperationResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return OperationResponse.DeserializeOperationResponse(document.RootElement);
        }

        async ValueTask<OperationResponse> IOperationSource<OperationResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return OperationResponse.DeserializeOperationResponse(document.RootElement);
        }
    }
}
