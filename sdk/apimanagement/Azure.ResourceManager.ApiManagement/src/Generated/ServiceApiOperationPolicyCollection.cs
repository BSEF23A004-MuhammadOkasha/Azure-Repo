// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceApiOperationPolicyResource" /> and their operations.
    /// Each <see cref="ServiceApiOperationPolicyResource" /> in the collection will belong to the same instance of <see cref="ApiOperationResource" />.
    /// To get a <see cref="ServiceApiOperationPolicyCollection" /> instance call the GetServiceApiOperationPolicies method from an instance of <see cref="ApiOperationResource" />.
    /// </summary>
    public partial class ServiceApiOperationPolicyCollection : ArmCollection, IEnumerable<ServiceApiOperationPolicyResource>, IAsyncEnumerable<ServiceApiOperationPolicyResource>
    {
        private readonly ClientDiagnostics _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics;
        private readonly ApiOperationPolicyRestOperations _serviceApiOperationPolicyApiOperationPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceApiOperationPolicyCollection"/> class for mocking. </summary>
        protected ServiceApiOperationPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceApiOperationPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceApiOperationPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceApiOperationPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceApiOperationPolicyResource.ResourceType, out string serviceApiOperationPolicyApiOperationPolicyApiVersion);
            _serviceApiOperationPolicyApiOperationPolicyRestClient = new ApiOperationPolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceApiOperationPolicyApiOperationPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiOperationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiOperationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates policy configuration for the API Operation level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies/{policyId}
        /// Operation Id: ApiOperationPolicy_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceApiOperationPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PolicyIdName policyId, PolicyContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceApiOperationPolicyApiOperationPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceApiOperationPolicyResource>(Response.FromValue(new ServiceApiOperationPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates policy configuration for the API Operation level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies/{policyId}
        /// Operation Id: ApiOperationPolicy_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceApiOperationPolicyResource> CreateOrUpdate(WaitUntil waitUntil, PolicyIdName policyId, PolicyContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceApiOperationPolicyApiOperationPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceApiOperationPolicyResource>(Response.FromValue(new ServiceApiOperationPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get the policy configuration at the API Operation level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies/{policyId}
        /// Operation Id: ApiOperationPolicy_Get
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceApiOperationPolicyResource>> GetAsync(PolicyIdName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceApiOperationPolicyApiOperationPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceApiOperationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the API Operation level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies/{policyId}
        /// Operation Id: ApiOperationPolicy_Get
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceApiOperationPolicyResource> Get(PolicyIdName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceApiOperationPolicyApiOperationPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceApiOperationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the list of policy configuration at the API Operation level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies
        /// Operation Id: ApiOperationPolicy_ListByOperation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceApiOperationPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceApiOperationPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceApiOperationPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceApiOperationPolicyApiOperationPolicyRestClient.ListByOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiOperationPolicyResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get the list of policy configuration at the API Operation level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies
        /// Operation Id: ApiOperationPolicy_ListByOperation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceApiOperationPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceApiOperationPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceApiOperationPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceApiOperationPolicyApiOperationPolicyRestClient.ListByOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiOperationPolicyResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies/{policyId}
        /// Operation Id: ApiOperationPolicy_Get
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PolicyIdName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceApiOperationPolicyApiOperationPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/policies/{policyId}
        /// Operation Id: ApiOperationPolicy_Get
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PolicyIdName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceApiOperationPolicyApiOperationPolicyClientDiagnostics.CreateScope("ServiceApiOperationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceApiOperationPolicyApiOperationPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceApiOperationPolicyResource> IEnumerable<ServiceApiOperationPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceApiOperationPolicyResource> IAsyncEnumerable<ServiceApiOperationPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
