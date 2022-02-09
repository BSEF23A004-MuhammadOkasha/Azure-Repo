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
    /// <summary> A Class representing a ReplicationLink along with the instance operations that can be performed on it. </summary>
    public partial class ReplicationLink : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ReplicationLink"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string linkId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _replicationLinkClientDiagnostics;
        private readonly ReplicationLinksRestOperations _replicationLinkRestClient;
        private readonly ReplicationLinkData _data;

        /// <summary> Initializes a new instance of the <see cref="ReplicationLink"/> class for mocking. </summary>
        protected ReplicationLink()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ReplicationLink"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ReplicationLink(ArmClient client, ReplicationLinkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ReplicationLink"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReplicationLink(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _replicationLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string replicationLinkApiVersion);
            _replicationLinkRestClient = new ReplicationLinksRestOperations(_replicationLinkClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, replicationLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/replicationLinks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ReplicationLinkData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Get
        /// <summary> Gets a replication link. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ReplicationLink>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Get");
            scope.Start();
            try
            {
                var response = await _replicationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _replicationLinkClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ReplicationLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Get
        /// <summary> Gets a replication link. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReplicationLink> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Get");
            scope.Start();
            try
            {
                var response = _replicationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _replicationLinkClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReplicationLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Delete
        /// <summary> Deletes a database replication link. Cannot be done during failover. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Delete");
            scope.Start();
            try
            {
                var response = await _replicationLinkRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Delete
        /// <summary> Deletes a database replication link. Cannot be done during failover. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Delete");
            scope.Start();
            try
            {
                var response = _replicationLinkRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}/failover
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Failover
        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> FailoverAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Failover");
            scope.Start();
            try
            {
                var response = await _replicationLinkRestClient.FailoverAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_replicationLinkClientDiagnostics, Pipeline, _replicationLinkRestClient.CreateFailoverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}/failover
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Failover
        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Failover(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Failover");
            scope.Start();
            try
            {
                var response = _replicationLinkRestClient.Failover(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_replicationLinkClientDiagnostics, Pipeline, _replicationLinkRestClient.CreateFailoverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}/forceFailoverAllowDataLoss
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_FailoverAllowDataLoss
        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. This operation might result in data loss. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> FailoverAllowDataLossAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.FailoverAllowDataLoss");
            scope.Start();
            try
            {
                var response = await _replicationLinkRestClient.FailoverAllowDataLossAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_replicationLinkClientDiagnostics, Pipeline, _replicationLinkRestClient.CreateFailoverAllowDataLossRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}/forceFailoverAllowDataLoss
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_FailoverAllowDataLoss
        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. This operation might result in data loss. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation FailoverAllowDataLoss(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.FailoverAllowDataLoss");
            scope.Start();
            try
            {
                var response = _replicationLinkRestClient.FailoverAllowDataLoss(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_replicationLinkClientDiagnostics, Pipeline, _replicationLinkRestClient.CreateFailoverAllowDataLossRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}/unlink
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Unlink
        /// <summary> Deletes a database replication link in forced or friendly way. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The required parameters for unlinking replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation> UnlinkAsync(bool waitForCompletion, UnlinkOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Unlink");
            scope.Start();
            try
            {
                var response = await _replicationLinkRestClient.UnlinkAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_replicationLinkClientDiagnostics, Pipeline, _replicationLinkRestClient.CreateUnlinkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}/unlink
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}
        /// OperationId: ReplicationLinks_Unlink
        /// <summary> Deletes a database replication link in forced or friendly way. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The required parameters for unlinking replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation Unlink(bool waitForCompletion, UnlinkOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _replicationLinkClientDiagnostics.CreateScope("ReplicationLink.Unlink");
            scope.Start();
            try
            {
                var response = _replicationLinkRestClient.Unlink(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation(_replicationLinkClientDiagnostics, Pipeline, _replicationLinkRestClient.CreateUnlinkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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
    }
}
