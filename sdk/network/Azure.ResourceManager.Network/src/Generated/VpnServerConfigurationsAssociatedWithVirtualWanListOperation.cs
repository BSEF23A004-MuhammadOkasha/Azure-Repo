// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Gives the list of VpnServerConfigurations associated with Virtual Wan in a resource group. </summary>
    public partial class VpnServerConfigurationsAssociatedWithVirtualWanListOperation : Operation<VpnServerConfigurationsResponse>, IOperationSource<VpnServerConfigurationsResponse>
    {
        private readonly ArmOperationHelpers<VpnServerConfigurationsResponse> _operation;
        internal VpnServerConfigurationsAssociatedWithVirtualWanListOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<VpnServerConfigurationsResponse>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VpnServerConfigurationsAssociatedWithVirtualWanListOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VpnServerConfigurationsResponse Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnServerConfigurationsResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnServerConfigurationsResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VpnServerConfigurationsResponse IOperationSource<VpnServerConfigurationsResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return VpnServerConfigurationsResponse.DeserializeVpnServerConfigurationsResponse(document.RootElement);
        }

        async ValueTask<VpnServerConfigurationsResponse> IOperationSource<VpnServerConfigurationsResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return VpnServerConfigurationsResponse.DeserializeVpnServerConfigurationsResponse(document.RootElement);
        }
    }
}
