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

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerServiceFleetMemberResource" /> and their operations.
    /// Each <see cref="ContainerServiceFleetMemberResource" /> in the collection will belong to the same instance of <see cref="ContainerServiceFleetResource" />.
    /// To get a <see cref="ContainerServiceFleetMemberCollection" /> instance call the GetContainerServiceFleetMembers method from an instance of <see cref="ContainerServiceFleetResource" />.
    /// </summary>
    public partial class ContainerServiceFleetMemberCollection : ArmCollection, IEnumerable<ContainerServiceFleetMemberResource>, IAsyncEnumerable<ContainerServiceFleetMemberResource>
    {
        private readonly ClientDiagnostics _containerServiceFleetMemberFleetMembersClientDiagnostics;
        private readonly FleetMembersRestOperations _containerServiceFleetMemberFleetMembersRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetMemberCollection"/> class for mocking. </summary>
        protected ContainerServiceFleetMemberCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetMemberCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerServiceFleetMemberCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceFleetMemberFleetMembersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerServiceFleet", ContainerServiceFleetMemberResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerServiceFleetMemberResource.ResourceType, out string containerServiceFleetMemberFleetMembersApiVersion);
            _containerServiceFleetMemberFleetMembersRestClient = new FleetMembersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceFleetMemberFleetMembersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerServiceFleetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerServiceFleetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceFleetMemberResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fleetMemberName, ContainerServiceFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetMemberFleetMembersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetMemberResource>(new ContainerServiceFleetMemberOperationSource(Client), _containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, _containerServiceFleetMemberFleetMembersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Create a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceFleetMemberResource> CreateOrUpdate(WaitUntil waitUntil, string fleetMemberName, ContainerServiceFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerServiceFleetMemberFleetMembersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetMemberResource>(new ContainerServiceFleetMemberOperationSource(Client), _containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, _containerServiceFleetMemberFleetMembersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Get a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual async Task<Response<ContainerServiceFleetMemberResource>> GetAsync(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetMemberFleetMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual Response<ContainerServiceFleetMemberResource> Get(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.Get");
            scope.Start();
            try
            {
                var response = _containerServiceFleetMemberFleetMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List FleetMember resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_ListByFleet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerServiceFleetMemberResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerServiceFleetMemberResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceFleetMemberFleetMembersRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceFleetMemberFleetMembersRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceFleetMemberResource(Client, ContainerServiceFleetMemberData.DeserializeContainerServiceFleetMemberData(e)), _containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, "ContainerServiceFleetMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FleetMember resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_ListByFleet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerServiceFleetMemberResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerServiceFleetMemberResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceFleetMemberFleetMembersRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceFleetMemberFleetMembersRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceFleetMemberResource(Client, ContainerServiceFleetMemberData.DeserializeContainerServiceFleetMemberData(e)), _containerServiceFleetMemberFleetMembersClientDiagnostics, Pipeline, "ContainerServiceFleetMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetMemberFleetMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual Response<bool> Exists(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerServiceFleetMemberFleetMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerServiceFleetMemberResource>> GetIfExistsAsync(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetMemberFleetMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceFleetMemberResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetMemberResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual NullableResponse<ContainerServiceFleetMemberResource> GetIfExists(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _containerServiceFleetMemberFleetMembersClientDiagnostics.CreateScope("ContainerServiceFleetMemberCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerServiceFleetMemberFleetMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceFleetMemberResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerServiceFleetMemberResource> IEnumerable<ContainerServiceFleetMemberResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerServiceFleetMemberResource> IAsyncEnumerable<ContainerServiceFleetMemberResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
