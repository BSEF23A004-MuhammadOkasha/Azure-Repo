// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a SyncGroup along with the instance operations that can be performed on it. </summary>
    public partial class SyncGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SyncGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string syncGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _syncGroupClientDiagnostics;
        private readonly SyncGroupsRestOperations _syncGroupRestClient;
        private readonly SyncGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="SyncGroup"/> class for mocking. </summary>
        protected SyncGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SyncGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SyncGroup(ArmClient client, SyncGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SyncGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SyncGroup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string syncGroupApiVersion);
            _syncGroupRestClient = new SyncGroupsRestOperations(_syncGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, syncGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/syncGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SyncGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SyncMembers in the SyncMember. </summary>
        /// <returns> An object representing collection of SyncMembers and their operations over a SyncMember. </returns>
        public virtual SyncMemberCollection GetSyncMembers()
        {
            return new SyncMemberCollection(Client, Id);
        }

        /// <summary>
        /// Gets a sync group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// Operation Id: SyncGroups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SyncGroup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.Get");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _syncGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SyncGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a sync group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// Operation Id: SyncGroups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SyncGroup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.Get");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _syncGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a sync group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// Operation Id: SyncGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.Delete");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a sync group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// Operation Id: SyncGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.Delete");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a sync group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// Operation Id: SyncGroups_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SyncGroup>> UpdateAsync(bool waitForCompletion, SyncGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.Update");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SyncGroup>(new SyncGroupOperationSource(Client), _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Updates a sync group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// Operation Id: SyncGroups_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SyncGroup> Update(bool waitForCompletion, SyncGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.Update");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation<SyncGroup>(new SyncGroupOperationSource(Client), _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Refreshes a hub database schema.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/refreshHubSchema
        /// Operation Id: SyncGroups_RefreshHubSchema
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> RefreshHubSchemaAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.RefreshHubSchema");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.RefreshHubSchemaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateRefreshHubSchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refreshes a hub database schema.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/refreshHubSchema
        /// Operation Id: SyncGroups_RefreshHubSchema
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation RefreshHubSchema(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.RefreshHubSchema");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.RefreshHubSchema(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateRefreshHubSchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a collection of hub database schemas.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/hubSchemas
        /// Operation Id: SyncGroups_ListHubSchemas
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncFullSchemaProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncFullSchemaProperties> GetHubSchemasAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SyncFullSchemaProperties>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetHubSchemas");
                scope.Start();
                try
                {
                    var response = await _syncGroupRestClient.ListHubSchemasAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SyncFullSchemaProperties>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetHubSchemas");
                scope.Start();
                try
                {
                    var response = await _syncGroupRestClient.ListHubSchemasNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a collection of hub database schemas.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/hubSchemas
        /// Operation Id: SyncGroups_ListHubSchemas
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncFullSchemaProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncFullSchemaProperties> GetHubSchemas(CancellationToken cancellationToken = default)
        {
            Page<SyncFullSchemaProperties> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetHubSchemas");
                scope.Start();
                try
                {
                    var response = _syncGroupRestClient.ListHubSchemas(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SyncFullSchemaProperties> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetHubSchemas");
                scope.Start();
                try
                {
                    var response = _syncGroupRestClient.ListHubSchemasNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a collection of sync group logs.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/logs
        /// Operation Id: SyncGroups_ListLogs
        /// </summary>
        /// <param name="startTime"> Get logs generated after this time. </param>
        /// <param name="endTime"> Get logs generated before this time. </param>
        /// <param name="type"> The types of logs to retrieve. </param>
        /// <param name="continuationToken"> The continuation token for this operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startTime"/> or <paramref name="endTime"/> is null. </exception>
        /// <returns> An async collection of <see cref="SyncGroupLogProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncGroupLogProperties> GetLogsAsync(string startTime, string endTime, SyncGroupLogType type, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(startTime, nameof(startTime));
            Argument.AssertNotNull(endTime, nameof(endTime));

            async Task<Page<SyncGroupLogProperties>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetLogs");
                scope.Start();
                try
                {
                    var response = await _syncGroupRestClient.ListLogsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SyncGroupLogProperties>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetLogs");
                scope.Start();
                try
                {
                    var response = await _syncGroupRestClient.ListLogsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a collection of sync group logs.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/logs
        /// Operation Id: SyncGroups_ListLogs
        /// </summary>
        /// <param name="startTime"> Get logs generated after this time. </param>
        /// <param name="endTime"> Get logs generated before this time. </param>
        /// <param name="type"> The types of logs to retrieve. </param>
        /// <param name="continuationToken"> The continuation token for this operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startTime"/> or <paramref name="endTime"/> is null. </exception>
        /// <returns> A collection of <see cref="SyncGroupLogProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncGroupLogProperties> GetLogs(string startTime, string endTime, SyncGroupLogType type, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(startTime, nameof(startTime));
            Argument.AssertNotNull(endTime, nameof(endTime));

            Page<SyncGroupLogProperties> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetLogs");
                scope.Start();
                try
                {
                    var response = _syncGroupRestClient.ListLogs(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SyncGroupLogProperties> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.GetLogs");
                scope.Start();
                try
                {
                    var response = _syncGroupRestClient.ListLogsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Cancels a sync group synchronization.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/cancelSync
        /// Operation Id: SyncGroups_CancelSync
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> CancelSyncAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.CancelSync");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.CancelSyncAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a sync group synchronization.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/cancelSync
        /// Operation Id: SyncGroups_CancelSync
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelSync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.CancelSync");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.CancelSync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Triggers a sync group synchronization.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/triggerSync
        /// Operation Id: SyncGroups_TriggerSync
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> TriggerSyncAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.TriggerSync");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.TriggerSyncAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Triggers a sync group synchronization.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/triggerSync
        /// Operation Id: SyncGroups_TriggerSync
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response TriggerSync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroup.TriggerSync");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.TriggerSync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
