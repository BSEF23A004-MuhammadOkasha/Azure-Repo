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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a SubscriptionLongTermRetentionBackup along with the instance operations that can be performed on it. </summary>
    public partial class SubscriptionLongTermRetentionBackup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionLongTermRetentionBackup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics;
        private readonly LongTermRetentionBackupsRestOperations _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient;
        private readonly LongTermRetentionBackupData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionBackup"/> class for mocking. </summary>
        protected SubscriptionLongTermRetentionBackup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionLongTermRetentionBackup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionLongTermRetentionBackup(ArmClient client, LongTermRetentionBackupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionBackup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionLongTermRetentionBackup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/longTermRetentionServers/longTermRetentionDatabases/longTermRetentionBackups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LongTermRetentionBackupData Data
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

        /// <summary>
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionLongTermRetentionBackup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionLongTermRetentionBackup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Get");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Delete");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.DeleteAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Deletes a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Delete");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Delete(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Copy an existing long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/copy
        /// Operation Id: LongTermRetentionBackups_Copy
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The parameters needed for long term retention copy request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<LongTermRetentionBackupOperationResult>> CopyAsync(WaitUntil waitUntil, CopyLongTermRetentionBackupOptions parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Copy");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CopyAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateCopyRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Copy an existing long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/copy
        /// Operation Id: LongTermRetentionBackups_Copy
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The parameters needed for long term retention copy request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<LongTermRetentionBackupOperationResult> Copy(WaitUntil waitUntil, CopyLongTermRetentionBackupOptions parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Copy");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Copy(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateCopyRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/update
        /// Operation Id: LongTermRetentionBackups_Update
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The requested backup resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<LongTermRetentionBackupOperationResult>> UpdateAsync(WaitUntil waitUntil, UpdateLongTermRetentionBackupOptions parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.UpdateAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/update
        /// Operation Id: LongTermRetentionBackups_Update
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The requested backup resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<LongTermRetentionBackupOperationResult> Update(WaitUntil waitUntil, UpdateLongTermRetentionBackupOptions parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackup.Update");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Update(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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
    }
}
