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
    /// A class representing a collection of <see cref="IPAllocationResource" /> and their operations.
    /// Each <see cref="IPAllocationResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="IPAllocationCollection" /> instance call the GetIPAllocations method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class IPAllocationCollection : ArmCollection, IEnumerable<IPAllocationResource>, IAsyncEnumerable<IPAllocationResource>
    {
        private readonly ClientDiagnostics _ipAllocationIPAllocationsClientDiagnostics;
        private readonly IpAllocationsRestOperations _ipAllocationIPAllocationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IPAllocationCollection"/> class for mocking. </summary>
        protected IPAllocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IPAllocationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IPAllocationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ipAllocationIPAllocationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", IPAllocationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IPAllocationResource.ResourceType, out string ipAllocationIPAllocationsApiVersion);
            _ipAllocationIPAllocationsRestClient = new IpAllocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ipAllocationIPAllocationsApiVersion);
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
        /// Creates or updates an IpAllocation in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IPAllocationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ipAllocationName, IPAllocationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipAllocationIPAllocationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<IPAllocationResource>(new IPAllocationOperationSource(Client), _ipAllocationIPAllocationsClientDiagnostics, Pipeline, _ipAllocationIPAllocationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an IpAllocation in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IPAllocationResource> CreateOrUpdate(WaitUntil waitUntil, string ipAllocationName, IPAllocationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipAllocationIPAllocationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, data, cancellationToken);
                var operation = new NetworkArmOperation<IPAllocationResource>(new IPAllocationOperationSource(Client), _ipAllocationIPAllocationsClientDiagnostics, Pipeline, _ipAllocationIPAllocationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified IpAllocation by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual async Task<Response<IPAllocationResource>> GetAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _ipAllocationIPAllocationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPAllocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified IpAllocation by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<IPAllocationResource> Get(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.Get");
            scope.Start();
            try
            {
                var response = _ipAllocationIPAllocationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPAllocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all IpAllocations in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IPAllocationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IPAllocationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ipAllocationIPAllocationsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ipAllocationIPAllocationsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new IPAllocationResource(Client, IPAllocationData.DeserializeIPAllocationData(e)), _ipAllocationIPAllocationsClientDiagnostics, Pipeline, "IPAllocationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all IpAllocations in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IPAllocationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IPAllocationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ipAllocationIPAllocationsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ipAllocationIPAllocationsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new IPAllocationResource(Client, IPAllocationData.DeserializeIPAllocationData(e)), _ipAllocationIPAllocationsClientDiagnostics, Pipeline, "IPAllocationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ipAllocationIPAllocationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.Exists");
            scope.Start();
            try
            {
                var response = _ipAllocationIPAllocationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual async Task<NullableResponse<IPAllocationResource>> GetIfExistsAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ipAllocationIPAllocationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IPAllocationResource>(response.GetRawResponse());
                return Response.FromValue(new IPAllocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/IpAllocations/{ipAllocationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpAllocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipAllocationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual NullableResponse<IPAllocationResource> GetIfExists(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipAllocationName, nameof(ipAllocationName));

            using var scope = _ipAllocationIPAllocationsClientDiagnostics.CreateScope("IPAllocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ipAllocationIPAllocationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IPAllocationResource>(response.GetRawResponse());
                return Response.FromValue(new IPAllocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IPAllocationResource> IEnumerable<IPAllocationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IPAllocationResource> IAsyncEnumerable<IPAllocationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
