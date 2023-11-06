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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualClusterResource" /> and their operations.
    /// Each <see cref="VirtualClusterResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VirtualClusterCollection" /> instance call the GetVirtualClusters method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VirtualClusterCollection : ArmCollection, IEnumerable<VirtualClusterResource>, IAsyncEnumerable<VirtualClusterResource>
    {
        private readonly ClientDiagnostics _virtualClusterClientDiagnostics;
        private readonly VirtualClustersRestOperations _virtualClusterRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualClusterCollection"/> class for mocking. </summary>
        protected VirtualClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualClusterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", VirtualClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualClusterResource.ResourceType, out string virtualClusterApiVersion);
            _virtualClusterRestClient = new VirtualClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualClusterApiVersion);
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
        /// Gets a virtual cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual async Task<Response<VirtualClusterResource>> GetAsync(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualClusterName, nameof(virtualClusterName));

            using var scope = _virtualClusterClientDiagnostics.CreateScope("VirtualClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a virtual cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual Response<VirtualClusterResource> Get(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualClusterName, nameof(virtualClusterName));

            using var scope = _virtualClusterClientDiagnostics.CreateScope("VirtualClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of virtual clusters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualClusterResource(Client, VirtualClusterData.DeserializeVirtualClusterData(e)), _virtualClusterClientDiagnostics, Pipeline, "VirtualClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of virtual clusters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualClusterResource(Client, VirtualClusterData.DeserializeVirtualClusterData(e)), _virtualClusterClientDiagnostics, Pipeline, "VirtualClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualClusterName, nameof(virtualClusterName));

            using var scope = _virtualClusterClientDiagnostics.CreateScope("VirtualClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualClusterName, nameof(virtualClusterName));

            using var scope = _virtualClusterClientDiagnostics.CreateScope("VirtualClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualClusterResource>> GetIfExistsAsync(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualClusterName, nameof(virtualClusterName));

            using var scope = _virtualClusterClientDiagnostics.CreateScope("VirtualClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualClusterResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualClusterResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/virtualClusters/{virtualClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualClusterName"> The name of the virtual cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualClusterName"/> is null. </exception>
        public virtual NullableResponse<VirtualClusterResource> GetIfExists(string virtualClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualClusterName, nameof(virtualClusterName));

            using var scope = _virtualClusterClientDiagnostics.CreateScope("VirtualClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualClusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualClusterResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualClusterResource> IEnumerable<VirtualClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualClusterResource> IAsyncEnumerable<VirtualClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
