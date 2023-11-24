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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteCircuitPeeringResource"/> and their operations.
    /// Each <see cref="ExpressRouteCircuitPeeringResource"/> in the collection will belong to the same instance of <see cref="ExpressRouteCircuitResource"/>.
    /// To get an <see cref="ExpressRouteCircuitPeeringCollection"/> instance call the GetExpressRouteCircuitPeerings method from an instance of <see cref="ExpressRouteCircuitResource"/>.
    /// </summary>
    public partial class ExpressRouteCircuitPeeringCollection : ArmCollection, IEnumerable<ExpressRouteCircuitPeeringResource>, IAsyncEnumerable<ExpressRouteCircuitPeeringResource>
    {
        private readonly ClientDiagnostics _expressRouteCircuitPeeringClientDiagnostics;
        private readonly ExpressRouteCircuitPeeringsRestOperations _expressRouteCircuitPeeringRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeeringCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeeringCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCircuitPeeringCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitPeeringClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuitPeeringResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteCircuitPeeringResource.ResourceType, out string expressRouteCircuitPeeringApiVersion);
            _expressRouteCircuitPeeringRestClient = new ExpressRouteCircuitPeeringsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCircuitPeeringApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuitResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuitResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a peering in the specified express route circuits.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitPeeringResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string peeringName, ExpressRouteCircuitPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitPeeringResource>(new ExpressRouteCircuitPeeringOperationSource(Client), _expressRouteCircuitPeeringClientDiagnostics, Pipeline, _expressRouteCircuitPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a peering in the specified express route circuits.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitPeeringResource> CreateOrUpdate(WaitUntil waitUntil, string peeringName, ExpressRouteCircuitPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitPeeringResource>(new ExpressRouteCircuitPeeringOperationSource(Client), _expressRouteCircuitPeeringClientDiagnostics, Pipeline, _expressRouteCircuitPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified peering for the express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuitPeeringResource>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified peering for the express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitPeeringResource> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all peerings in a specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitPeeringResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitPeeringResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitPeeringRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitPeeringRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitPeeringResource(Client, ExpressRouteCircuitPeeringData.DeserializeExpressRouteCircuitPeeringData(e)), _expressRouteCircuitPeeringClientDiagnostics, Pipeline, "ExpressRouteCircuitPeeringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all peerings in a specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitPeeringResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitPeeringResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitPeeringRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitPeeringRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitPeeringResource(Client, ExpressRouteCircuitPeeringData.DeserializeExpressRouteCircuitPeeringData(e)), _expressRouteCircuitPeeringClientDiagnostics, Pipeline, "ExpressRouteCircuitPeeringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<bool> Exists(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExpressRouteCircuitPeeringResource>> GetIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitPeeringResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeeringResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual NullableResponse<ExpressRouteCircuitPeeringResource> GetIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitPeeringResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuitPeeringResource> IEnumerable<ExpressRouteCircuitPeeringResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitPeeringResource> IAsyncEnumerable<ExpressRouteCircuitPeeringResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
