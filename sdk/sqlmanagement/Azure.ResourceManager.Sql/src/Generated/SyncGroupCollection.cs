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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SyncGroupResource"/> and their operations.
    /// Each <see cref="SyncGroupResource"/> in the collection will belong to the same instance of <see cref="SqlDatabaseResource"/>.
    /// To get a <see cref="SyncGroupCollection"/> instance call the GetSyncGroups method from an instance of <see cref="SqlDatabaseResource"/>.
    /// </summary>
    public partial class SyncGroupCollection : ArmCollection, IEnumerable<SyncGroupResource>, IAsyncEnumerable<SyncGroupResource>
    {
        private readonly ClientDiagnostics _syncGroupClientDiagnostics;
        private readonly SyncGroupsRestOperations _syncGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="SyncGroupCollection"/> class for mocking. </summary>
        protected SyncGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SyncGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SyncGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SyncGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SyncGroupResource.ResourceType, out string syncGroupApiVersion);
            _syncGroupRestClient = new SyncGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, syncGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="data"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SyncGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string syncGroupName, SyncGroupData data, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SyncGroupResource>(new SyncGroupOperationSource(Client), _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="data"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SyncGroupResource> CreateOrUpdate(WaitUntil waitUntil, string syncGroupName, SyncGroupData data, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<SyncGroupResource>(new SyncGroupOperationSource(Client), _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual async Task<Response<SyncGroupResource>> GetAsync(string syncGroupName, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual Response<SyncGroupResource> Get(string syncGroupName, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists sync groups under a hub database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncGroupRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncGroupRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SyncGroupResource(Client, SyncGroupData.DeserializeSyncGroupData(e)), _syncGroupClientDiagnostics, Pipeline, "SyncGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists sync groups under a hub database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncGroupRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncGroupRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SyncGroupResource(Client, SyncGroupData.DeserializeSyncGroupData(e)), _syncGroupClientDiagnostics, Pipeline, "SyncGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string syncGroupName, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string syncGroupName, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<SyncGroupResource>> GetIfExistsAsync(string syncGroupName, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SyncGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SyncGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual NullableResponse<SyncGroupResource> GetIfExists(string syncGroupName, CancellationToken cancellationToken = default)
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException(nameof(syncGroupName));
            }
            if (syncGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncGroupName));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SyncGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SyncGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SyncGroupResource> IEnumerable<SyncGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SyncGroupResource> IAsyncEnumerable<SyncGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
