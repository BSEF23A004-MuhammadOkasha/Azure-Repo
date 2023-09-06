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
    /// A class representing a collection of <see cref="NetworkGroupStaticMemberResource" /> and their operations.
    /// Each <see cref="NetworkGroupStaticMemberResource" /> in the collection will belong to the same instance of <see cref="NetworkGroupResource" />.
    /// To get a <see cref="NetworkGroupStaticMemberCollection" /> instance call the GetNetworkGroupStaticMembers method from an instance of <see cref="NetworkGroupResource" />.
    /// </summary>
    public partial class NetworkGroupStaticMemberCollection : ArmCollection, IEnumerable<NetworkGroupStaticMemberResource>, IAsyncEnumerable<NetworkGroupStaticMemberResource>
    {
        private readonly ClientDiagnostics _networkGroupStaticMemberStaticMembersClientDiagnostics;
        private readonly StaticMembersRestOperations _networkGroupStaticMemberStaticMembersRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkGroupStaticMemberCollection"/> class for mocking. </summary>
        protected NetworkGroupStaticMemberCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkGroupStaticMemberCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkGroupStaticMemberCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkGroupStaticMemberStaticMembersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkGroupStaticMemberResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkGroupStaticMemberResource.ResourceType, out string networkGroupStaticMemberStaticMembersApiVersion);
            _networkGroupStaticMemberStaticMembersRestClient = new StaticMembersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkGroupStaticMemberStaticMembersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a static member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers/{staticMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="staticMemberName"> The name of the static member. </param>
        /// <param name="data"> Parameters supplied to the specify the static member to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="staticMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="staticMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkGroupStaticMemberResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string staticMemberName, NetworkGroupStaticMemberData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(staticMemberName, nameof(staticMemberName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkGroupStaticMemberStaticMembersClientDiagnostics.CreateScope("NetworkGroupStaticMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkGroupStaticMemberStaticMembersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticMemberName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkGroupStaticMemberResource>(Response.FromValue(new NetworkGroupStaticMemberResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a static member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers/{staticMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="staticMemberName"> The name of the static member. </param>
        /// <param name="data"> Parameters supplied to the specify the static member to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="staticMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="staticMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkGroupStaticMemberResource> CreateOrUpdate(WaitUntil waitUntil, string staticMemberName, NetworkGroupStaticMemberData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(staticMemberName, nameof(staticMemberName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkGroupStaticMemberStaticMembersClientDiagnostics.CreateScope("NetworkGroupStaticMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkGroupStaticMemberStaticMembersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticMemberName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkGroupStaticMemberResource>(Response.FromValue(new NetworkGroupStaticMemberResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified static member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers/{staticMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="staticMemberName"> The name of the static member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="staticMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="staticMemberName"/> is null. </exception>
        public virtual async Task<Response<NetworkGroupStaticMemberResource>> GetAsync(string staticMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(staticMemberName, nameof(staticMemberName));

            using var scope = _networkGroupStaticMemberStaticMembersClientDiagnostics.CreateScope("NetworkGroupStaticMemberCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkGroupStaticMemberStaticMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticMemberName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkGroupStaticMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified static member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers/{staticMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="staticMemberName"> The name of the static member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="staticMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="staticMemberName"/> is null. </exception>
        public virtual Response<NetworkGroupStaticMemberResource> Get(string staticMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(staticMemberName, nameof(staticMemberName));

            using var scope = _networkGroupStaticMemberStaticMembersClientDiagnostics.CreateScope("NetworkGroupStaticMemberCollection.Get");
            scope.Start();
            try
            {
                var response = _networkGroupStaticMemberStaticMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticMemberName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkGroupStaticMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the specified static member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkGroupStaticMemberResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkGroupStaticMemberResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkGroupStaticMemberStaticMembersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkGroupStaticMemberStaticMembersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkGroupStaticMemberResource(Client, NetworkGroupStaticMemberData.DeserializeNetworkGroupStaticMemberData(e)), _networkGroupStaticMemberStaticMembersClientDiagnostics, Pipeline, "NetworkGroupStaticMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the specified static member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkGroupStaticMemberResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkGroupStaticMemberResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkGroupStaticMemberStaticMembersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkGroupStaticMemberStaticMembersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkGroupStaticMemberResource(Client, NetworkGroupStaticMemberData.DeserializeNetworkGroupStaticMemberData(e)), _networkGroupStaticMemberStaticMembersClientDiagnostics, Pipeline, "NetworkGroupStaticMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers/{staticMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="staticMemberName"> The name of the static member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="staticMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="staticMemberName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string staticMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(staticMemberName, nameof(staticMemberName));

            using var scope = _networkGroupStaticMemberStaticMembersClientDiagnostics.CreateScope("NetworkGroupStaticMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkGroupStaticMemberStaticMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/networkGroups/{networkGroupName}/staticMembers/{staticMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="staticMemberName"> The name of the static member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="staticMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="staticMemberName"/> is null. </exception>
        public virtual Response<bool> Exists(string staticMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(staticMemberName, nameof(staticMemberName));

            using var scope = _networkGroupStaticMemberStaticMembersClientDiagnostics.CreateScope("NetworkGroupStaticMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkGroupStaticMemberStaticMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticMemberName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkGroupStaticMemberResource> IEnumerable<NetworkGroupStaticMemberResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkGroupStaticMemberResource> IAsyncEnumerable<NetworkGroupStaticMemberResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
