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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="DdosProtectionPlanResource" /> and their operations.
    /// Each <see cref="DdosProtectionPlanResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DdosProtectionPlanCollection" /> instance call the GetDdosProtectionPlans method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DdosProtectionPlanCollection : ArmCollection, IEnumerable<DdosProtectionPlanResource>, IAsyncEnumerable<DdosProtectionPlanResource>
    {
        private readonly ClientDiagnostics _ddosProtectionPlanClientDiagnostics;
        private readonly DdosProtectionPlansRestOperations _ddosProtectionPlanRestClient;

        /// <summary> Initializes a new instance of the <see cref="DdosProtectionPlanCollection"/> class for mocking. </summary>
        protected DdosProtectionPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DdosProtectionPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DdosProtectionPlanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ddosProtectionPlanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", DdosProtectionPlanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DdosProtectionPlanResource.ResourceType, out string ddosProtectionPlanApiVersion);
            _ddosProtectionPlanRestClient = new DdosProtectionPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ddosProtectionPlanApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a DDoS protection plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="data"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DdosProtectionPlanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ddosProtectionPlanName, DdosProtectionPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlanRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<DdosProtectionPlanResource>(new DdosProtectionPlanOperationSource(Client), _ddosProtectionPlanClientDiagnostics, Pipeline, _ddosProtectionPlanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a DDoS protection plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="data"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DdosProtectionPlanResource> CreateOrUpdate(WaitUntil waitUntil, string ddosProtectionPlanName, DdosProtectionPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlanRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, data, cancellationToken);
                var operation = new NetworkArmOperation<DdosProtectionPlanResource>(new DdosProtectionPlanOperationSource(Client), _ddosProtectionPlanClientDiagnostics, Pipeline, _ddosProtectionPlanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified DDoS protection plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual async Task<Response<DdosProtectionPlanResource>> GetAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified DDoS protection plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<DdosProtectionPlanResource> Get(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the DDoS protection plans in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DdosProtectionPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DdosProtectionPlanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ddosProtectionPlanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ddosProtectionPlanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DdosProtectionPlanResource(Client, DdosProtectionPlanData.DeserializeDdosProtectionPlanData(e)), _ddosProtectionPlanClientDiagnostics, Pipeline, "DdosProtectionPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the DDoS protection plans in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DdosProtectionPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DdosProtectionPlanResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ddosProtectionPlanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ddosProtectionPlanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DdosProtectionPlanResource(Client, DdosProtectionPlanData.DeserializeDdosProtectionPlanData(e)), _ddosProtectionPlanClientDiagnostics, Pipeline, "DdosProtectionPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosProtectionPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DdosProtectionPlanResource> IEnumerable<DdosProtectionPlanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DdosProtectionPlanResource> IAsyncEnumerable<DdosProtectionPlanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
