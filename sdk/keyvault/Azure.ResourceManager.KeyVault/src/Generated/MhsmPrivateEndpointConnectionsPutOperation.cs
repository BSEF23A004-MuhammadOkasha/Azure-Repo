// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using KeyVaultManagementClient.Models;

namespace KeyVaultManagementClient
{
    /// <summary> Updates the specified private endpoint connection associated with the managed hsm pool. </summary>
    public partial class MhsmPrivateEndpointConnectionsPutOperation : Operation<MhsmPrivateEndpointConnection>
    {
        private readonly OperationOrResponseInternals<MhsmPrivateEndpointConnection> _operation;

        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionsPutOperation for mocking. </summary>
        protected MhsmPrivateEndpointConnectionsPutOperation()
        {
        }

        internal MhsmPrivateEndpointConnectionsPutOperation(ResourceOperationsBase operationsBase, Response<MhsmPrivateEndpointConnectionData> response)
        {
            _operation = new OperationOrResponseInternals<MhsmPrivateEndpointConnection>(Response.FromValue(new MhsmPrivateEndpointConnection(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override MhsmPrivateEndpointConnection Value => _operation.Value;

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
        public override ValueTask<Response<MhsmPrivateEndpointConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<MhsmPrivateEndpointConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
