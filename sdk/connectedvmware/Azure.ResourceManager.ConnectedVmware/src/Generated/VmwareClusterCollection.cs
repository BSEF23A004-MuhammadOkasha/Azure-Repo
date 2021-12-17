// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVmware.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVmware
{
    /// <summary> A class representing collection of VmwareCluster and their operations over its parent. </summary>
    public partial class VmwareClusterCollection : ArmCollection, IEnumerable<VmwareCluster>, IAsyncEnumerable<VmwareCluster>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ClustersRestOperations _clustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="VmwareClusterCollection"/> class for mocking. </summary>
        protected VmwareClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of VmwareClusterCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VmwareClusterCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _clustersRestClient = new ClustersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Create
        /// <summary> Create Or Update cluster. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual ClusterCreateOperation CreateOrUpdate(string clusterName, VmwareClusterData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _clustersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body, cancellationToken);
                var operation = new ClusterCreateOperation(Parent, _clientDiagnostics, Pipeline, _clustersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Create
        /// <summary> Create Or Update cluster. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<ClusterCreateOperation> CreateOrUpdateAsync(string clusterName, VmwareClusterData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _clustersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ClusterCreateOperation(Parent, _clientDiagnostics, Pipeline, _clustersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Get
        /// <summary> Implements cluster GET method. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<VmwareCluster> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _clustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VmwareCluster(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_Get
        /// <summary> Implements cluster GET method. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<Response<VmwareCluster>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _clustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VmwareCluster(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<VmwareCluster> GetIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _clustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VmwareCluster>(null, response.GetRawResponse())
                    : Response.FromValue(new VmwareCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<Response<VmwareCluster>> GetIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _clustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VmwareCluster>(null, response.GetRawResponse())
                    : Response.FromValue(new VmwareCluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(clusterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_ListByResourceGroup
        /// <summary> List of clusters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VmwareCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VmwareCluster> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VmwareCluster> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _clustersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VmwareCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VmwareCluster> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _clustersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VmwareCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Clusters_ListByResourceGroup
        /// <summary> List of clusters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VmwareCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VmwareCluster> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VmwareCluster>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _clustersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VmwareCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VmwareCluster>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _clustersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VmwareCluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VmwareCluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VmwareCluster.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VmwareCluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VmwareClusterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VmwareCluster.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VmwareCluster> IEnumerable<VmwareCluster>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VmwareCluster> IAsyncEnumerable<VmwareCluster>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VmwareCluster, VmwareClusterData> Construct() { }
    }
}
