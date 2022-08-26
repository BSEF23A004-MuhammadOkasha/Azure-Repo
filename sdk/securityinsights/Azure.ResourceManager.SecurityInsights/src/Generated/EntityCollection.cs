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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="EntityResource" /> and their operations.
    /// Each <see cref="EntityResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="EntityCollection" /> instance call the GetEntities method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class EntityCollection : ArmCollection, IEnumerable<EntityResource>, IAsyncEnumerable<EntityResource>
    {
        private readonly ClientDiagnostics _entityClientDiagnostics;
        private readonly EntitiesRestOperations _entityRestClient;
        private readonly string _workspaceName;

        /// <summary> Initializes a new instance of the <see cref="EntityCollection"/> class for mocking. </summary>
        protected EntityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EntityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal EntityCollection(ArmClient client, ResourceIdentifier id, string workspaceName) : base(client, id)
        {
            _workspaceName = workspaceName;
            _entityClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", EntityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EntityResource.ResourceType, out string entityApiVersion);
            _entityRestClient = new EntitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, entityApiVersion);
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
        /// Gets an entity.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/entities/{entityId}
        /// Operation Id: Entities_Get
        /// </summary>
        /// <param name="entityId"> entity ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityId"/> is null. </exception>
        public virtual async Task<Response<EntityResource>> GetAsync(string entityId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityId, nameof(entityId));

            using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.Get");
            scope.Start();
            try
            {
                var response = await _entityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, entityId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EntityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an entity.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/entities/{entityId}
        /// Operation Id: Entities_Get
        /// </summary>
        /// <param name="entityId"> entity ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityId"/> is null. </exception>
        public virtual Response<EntityResource> Get(string entityId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityId, nameof(entityId));

            using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.Get");
            scope.Start();
            try
            {
                var response = _entityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, entityId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EntityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all entities.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/entities
        /// Operation Id: Entities_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EntityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EntityResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EntityResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _entityRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EntityResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EntityResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _entityRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EntityResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all entities.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/entities
        /// Operation Id: Entities_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EntityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EntityResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EntityResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _entityRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EntityResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EntityResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _entityRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EntityResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/entities/{entityId}
        /// Operation Id: Entities_Get
        /// </summary>
        /// <param name="entityId"> entity ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string entityId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityId, nameof(entityId));

            using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _entityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, entityId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/entities/{entityId}
        /// Operation Id: Entities_Get
        /// </summary>
        /// <param name="entityId"> entity ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityId"/> is null. </exception>
        public virtual Response<bool> Exists(string entityId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityId, nameof(entityId));

            using var scope = _entityClientDiagnostics.CreateScope("EntityCollection.Exists");
            scope.Start();
            try
            {
                var response = _entityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, entityId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EntityResource> IEnumerable<EntityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EntityResource> IAsyncEnumerable<EntityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
