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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of DdosCustomPolicy and their operations over its parent. </summary>
    public partial class DdosCustomPolicyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _ddosCustomPolicyClientDiagnostics;
        private readonly DdosCustomPoliciesRestOperations _ddosCustomPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="DdosCustomPolicyCollection"/> class for mocking. </summary>
        protected DdosCustomPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DdosCustomPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DdosCustomPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ddosCustomPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", DdosCustomPolicy.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DdosCustomPolicy.ResourceType, out string ddosCustomPolicyApiVersion);
            _ddosCustomPolicyRestClient = new DdosCustomPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ddosCustomPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a DDoS custom policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<DdosCustomPolicy>> CreateOrUpdateAsync(WaitUntil waitUntil, string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ddosCustomPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<DdosCustomPolicy>(new DdosCustomPolicyOperationSource(Client), _ddosCustomPolicyClientDiagnostics, Pipeline, _ddosCustomPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a DDoS custom policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<DdosCustomPolicy> CreateOrUpdate(WaitUntil waitUntil, string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ddosCustomPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<DdosCustomPolicy>(new DdosCustomPolicyOperationSource(Client), _ddosCustomPolicyClientDiagnostics, Pipeline, _ddosCustomPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified DDoS custom policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_Get
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual async Task<Response<DdosCustomPolicy>> GetAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _ddosCustomPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified DDoS custom policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_Get
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<DdosCustomPolicy> Get(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _ddosCustomPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_Get
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_Get
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ddosCustomPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_Get
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual async Task<Response<DdosCustomPolicy>> GetIfExistsAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ddosCustomPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DdosCustomPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}
        /// Operation Id: DdosCustomPolicies_Get
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<DdosCustomPolicy> GetIfExists(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ddosCustomPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DdosCustomPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
