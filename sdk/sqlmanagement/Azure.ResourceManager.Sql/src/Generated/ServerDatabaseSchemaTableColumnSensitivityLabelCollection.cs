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
    /// <summary> A class representing collection of ServerDatabaseSchemaTableColumnSensitivityLabel and their operations over its parent. </summary>
    public partial class ServerDatabaseSchemaTableColumnSensitivityLabelCollection : ArmCollection
    {
        private readonly ClientDiagnostics _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics;
        private readonly SensitivityLabelsRestOperations _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaTableColumnSensitivityLabelCollection"/> class for mocking. </summary>
        protected ServerDatabaseSchemaTableColumnSensitivityLabelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaTableColumnSensitivityLabelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerDatabaseSchemaTableColumnSensitivityLabelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerDatabaseSchemaTableColumnSensitivityLabel.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerDatabaseSchemaTableColumnSensitivityLabel.ResourceType, out string serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsApiVersion);
            _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient = new SensitivityLabelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerDatabaseSchemaTableColumn.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerDatabaseSchemaTableColumn.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerDatabaseSchemaTableColumnSensitivityLabel>> CreateOrUpdateAsync(WaitUntil waitUntil, SensitivityLabelData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerDatabaseSchemaTableColumnSensitivityLabel>(Response.FromValue(new ServerDatabaseSchemaTableColumnSensitivityLabel(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServerDatabaseSchemaTableColumnSensitivityLabel> CreateOrUpdate(WaitUntil waitUntil, SensitivityLabelData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation<ServerDatabaseSchemaTableColumnSensitivityLabel>(Response.FromValue(new ServerDatabaseSchemaTableColumnSensitivityLabel(Client, response), response.GetRawResponse()));
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
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerDatabaseSchemaTableColumnSensitivityLabel>> GetAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchemaTableColumnSensitivityLabel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerDatabaseSchemaTableColumnSensitivityLabel> Get(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchemaTableColumnSensitivityLabel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sensitivityLabelSource, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sensitivityLabelSource, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerDatabaseSchemaTableColumnSensitivityLabel>> GetIfExistsAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerDatabaseSchemaTableColumnSensitivityLabel>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchemaTableColumnSensitivityLabel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerDatabaseSchemaTableColumnSensitivityLabel> GetIfExists(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsClientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnSensitivityLabelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaTableColumnSensitivityLabelSensitivityLabelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerDatabaseSchemaTableColumnSensitivityLabel>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchemaTableColumnSensitivityLabel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
