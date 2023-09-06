// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesDataReplication.Models;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A Class representing a PolicyModel along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PolicyModelResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPolicyModelResource method.
    /// Otherwise you can get one from its parent resource <see cref="VaultModelResource" /> using the GetPolicyModel method.
    /// </summary>
    public partial class PolicyModelResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicyModelResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string policyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _policyModelPolicyClientDiagnostics;
        private readonly PolicyRestOperations _policyModelPolicyRestClient;
        private readonly ClientDiagnostics _policyOperationStatusClientDiagnostics;
        private readonly PolicyOperationStatusRestOperations _policyOperationStatusRestClient;
        private readonly PolicyModelData _data;

        /// <summary> Initializes a new instance of the <see cref="PolicyModelResource"/> class for mocking. </summary>
        protected PolicyModelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PolicyModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicyModelResource(ArmClient client, PolicyModelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyModelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyModelPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string policyModelPolicyApiVersion);
            _policyModelPolicyRestClient = new PolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyModelPolicyApiVersion);
            _policyOperationStatusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _policyOperationStatusRestClient = new PolicyOperationStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataReplication/replicationVaults/replicationPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyModelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyModelResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyModelPolicyClientDiagnostics.CreateScope("PolicyModelResource.Get");
            scope.Start();
            try
            {
                var response = await _policyModelPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyModelResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _policyModelPolicyClientDiagnostics.CreateScope("PolicyModelResource.Get");
            scope.Start();
            try
            {
                var response = _policyModelPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyModelPolicyClientDiagnostics.CreateScope("PolicyModelResource.Delete");
            scope.Start();
            try
            {
                var response = await _policyModelPolicyRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation(_policyModelPolicyClientDiagnostics, Pipeline, _policyModelPolicyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyModelPolicyClientDiagnostics.CreateScope("PolicyModelResource.Delete");
            scope.Start();
            try
            {
                var response = _policyModelPolicyRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation(_policyModelPolicyClientDiagnostics, Pipeline, _policyModelPolicyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Policy model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyModelResource>> UpdateAsync(WaitUntil waitUntil, PolicyModelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyModelPolicyClientDiagnostics.CreateScope("PolicyModelResource.Update");
            scope.Start();
            try
            {
                var response = await _policyModelPolicyRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<PolicyModelResource>(new PolicyModelOperationSource(Client), _policyModelPolicyClientDiagnostics, Pipeline, _policyModelPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Policy model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicyModelResource> Update(WaitUntil waitUntil, PolicyModelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyModelPolicyClientDiagnostics.CreateScope("PolicyModelResource.Update");
            scope.Start();
            try
            {
                var response = _policyModelPolicyRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<PolicyModelResource>(new PolicyModelOperationSource(Client), _policyModelPolicyClientDiagnostics, Pipeline, _policyModelPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tracks the results of an asynchronous operation on the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyOperationStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<Response<OperationStatus>> GetPolicyOperationStatuAsync(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _policyOperationStatusClientDiagnostics.CreateScope("PolicyModelResource.GetPolicyOperationStatu");
            scope.Start();
            try
            {
                var response = await _policyOperationStatusRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tracks the results of an asynchronous operation on the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyOperationStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual Response<OperationStatus> GetPolicyOperationStatu(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _policyOperationStatusClientDiagnostics.CreateScope("PolicyModelResource.GetPolicyOperationStatu");
            scope.Start();
            try
            {
                var response = _policyOperationStatusRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
