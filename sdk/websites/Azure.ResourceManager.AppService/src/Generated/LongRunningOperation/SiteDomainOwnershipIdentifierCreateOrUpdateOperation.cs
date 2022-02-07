// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier. </summary>
    public partial class SiteDomainOwnershipIdentifierCreateOrUpdateOperation : Operation<SiteDomainOwnershipIdentifier>
    {
        private readonly OperationOrResponseInternals<SiteDomainOwnershipIdentifier> _operation;

        /// <summary> Initializes a new instance of SiteDomainOwnershipIdentifierCreateOrUpdateOperation for mocking. </summary>
        protected SiteDomainOwnershipIdentifierCreateOrUpdateOperation()
        {
        }

        internal SiteDomainOwnershipIdentifierCreateOrUpdateOperation(ArmClient armClient, Response<IdentifierData> response)
        {
            _operation = new OperationOrResponseInternals<SiteDomainOwnershipIdentifier>(Response.FromValue(new SiteDomainOwnershipIdentifier(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteDomainOwnershipIdentifier Value => _operation.Value;

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
        public override ValueTask<Response<SiteDomainOwnershipIdentifier>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteDomainOwnershipIdentifier>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
