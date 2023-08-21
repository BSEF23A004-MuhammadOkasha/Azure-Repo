// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
    /// A class representing a collection of <see cref="ApiManagementPolicyResource" /> and their operations.
    /// Each <see cref="ApiManagementPolicyResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementPolicyCollection" /> instance call the GetApiManagementPolicies method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementPolicyCollection : ArmCollection, IEnumerable<ApiManagementPolicyResource>, IAsyncEnumerable<ApiManagementPolicyResource>
    {
        private readonly ClientDiagnostics _apiManagementPolicyPolicyClientDiagnostics;
        private readonly PolicyRestOperations _apiManagementPolicyPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPolicyCollection"/> class for mocking. </summary>
        protected ApiManagementPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementPolicyPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementPolicyResource.ResourceType, out string apiManagementPolicyPolicyApiVersion);
            _apiManagementPolicyPolicyRestClient = new PolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementPolicyPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the global policy configuration of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementPolicyPolicyClientDiagnostics.CreateScope("ApiManagementPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementPolicyPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementPolicyResource>(Response.FromValue(new ApiManagementPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the global policy configuration of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementPolicyResource> CreateOrUpdate(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementPolicyPolicyClientDiagnostics.CreateScope("ApiManagementPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementPolicyPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementPolicyResource>(Response.FromValue(new ApiManagementPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get the Global policy definition of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementPolicyResource>> GetAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPolicyPolicyClientDiagnostics.CreateScope("ApiManagementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementPolicyPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyId, format, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Global policy definition of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementPolicyResource> Get(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPolicyPolicyClientDiagnostics.CreateScope("ApiManagementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementPolicyPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyId, format, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the Global Policy definitions of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementPolicyPolicyRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ApiManagementPolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _apiManagementPolicyPolicyClientDiagnostics, Pipeline, "ApiManagementPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the Global Policy definitions of the Api Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementPolicyPolicyRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new ApiManagementPolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _apiManagementPolicyPolicyClientDiagnostics, Pipeline, "ApiManagementPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPolicyPolicyClientDiagnostics.CreateScope("ApiManagementPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementPolicyPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPolicyPolicyClientDiagnostics.CreateScope("ApiManagementPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementPolicyPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyId, format, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementPolicyResource> IEnumerable<ApiManagementPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementPolicyResource> IAsyncEnumerable<ApiManagementPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
