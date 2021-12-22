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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
    public partial class PolicyDefinitionCreateOrUpdateAtManagementGroupOperation : Operation<ManagementGroupPolicyDefinition>
    {
        private readonly OperationOrResponseInternals<ManagementGroupPolicyDefinition> _operation;

        /// <summary> Initializes a new instance of PolicyDefinitionCreateOrUpdateAtManagementGroupOperation for mocking. </summary>
        protected PolicyDefinitionCreateOrUpdateAtManagementGroupOperation()
        {
        }

        internal PolicyDefinitionCreateOrUpdateAtManagementGroupOperation(ArmResource operationsBase, Response<PolicyDefinitionData> response)
        {
            _operation = new OperationOrResponseInternals<ManagementGroupPolicyDefinition>(Response.FromValue(new ManagementGroupPolicyDefinition(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagementGroupPolicyDefinition Value => _operation.Value;

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
        public override ValueTask<Response<ManagementGroupPolicyDefinition>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagementGroupPolicyDefinition>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
