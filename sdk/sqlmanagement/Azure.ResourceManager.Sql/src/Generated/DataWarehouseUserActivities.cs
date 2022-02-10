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
    /// <summary> A Class representing a DataWarehouseUserActivities along with the instance operations that can be performed on it. </summary>
    public partial class DataWarehouseUserActivities : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataWarehouseUserActivities"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string dataWarehouseUserActivityName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataWarehouseUserActivitiesDataWarehouseUserActivitiesClientDiagnostics;
        private readonly DataWarehouseUserActivitiesRestOperations _dataWarehouseUserActivitiesDataWarehouseUserActivitiesRestClient;
        private readonly DataWarehouseUserActivitiesData _data;

        /// <summary> Initializes a new instance of the <see cref="DataWarehouseUserActivities"/> class for mocking. </summary>
        protected DataWarehouseUserActivities()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataWarehouseUserActivities"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataWarehouseUserActivities(ArmClient client, DataWarehouseUserActivitiesData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataWarehouseUserActivities"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataWarehouseUserActivities(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataWarehouseUserActivitiesDataWarehouseUserActivitiesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string dataWarehouseUserActivitiesDataWarehouseUserActivitiesApiVersion);
            _dataWarehouseUserActivitiesDataWarehouseUserActivitiesRestClient = new DataWarehouseUserActivitiesRestOperations(_dataWarehouseUserActivitiesDataWarehouseUserActivitiesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, dataWarehouseUserActivitiesDataWarehouseUserActivitiesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/dataWarehouseUserActivities";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataWarehouseUserActivitiesData Data
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
        /// Gets the user activities of a data warehouse which includes running and suspended queries
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}
        /// Operation Id: DataWarehouseUserActivities_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DataWarehouseUserActivities>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivitiesDataWarehouseUserActivitiesClientDiagnostics.CreateScope("DataWarehouseUserActivities.Get");
            scope.Start();
            try
            {
                var response = await _dataWarehouseUserActivitiesDataWarehouseUserActivitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _dataWarehouseUserActivitiesDataWarehouseUserActivitiesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataWarehouseUserActivities(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the user activities of a data warehouse which includes running and suspended queries
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}
        /// Operation Id: DataWarehouseUserActivities_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataWarehouseUserActivities> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivitiesDataWarehouseUserActivitiesClientDiagnostics.CreateScope("DataWarehouseUserActivities.Get");
            scope.Start();
            try
            {
                var response = _dataWarehouseUserActivitiesDataWarehouseUserActivitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _dataWarehouseUserActivitiesDataWarehouseUserActivitiesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivities(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
