// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a DatabaseAutomaticTuning along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseAutomaticTuning : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseAutomaticTuning"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseAutomaticTuningClientDiagnostics;
        private readonly DatabaseAutomaticTuningRestOperations _databaseAutomaticTuningRestClient;
        private readonly DatabaseAutomaticTuningData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAutomaticTuning"/> class for mocking. </summary>
        protected DatabaseAutomaticTuning()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseAutomaticTuning"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseAutomaticTuning(ArmClient client, DatabaseAutomaticTuningData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAutomaticTuning"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseAutomaticTuning(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAutomaticTuningClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string databaseAutomaticTuningApiVersion);
            _databaseAutomaticTuningRestClient = new DatabaseAutomaticTuningRestOperations(_databaseAutomaticTuningClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, databaseAutomaticTuningApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/automaticTuning";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseAutomaticTuningData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// OperationId: DatabaseAutomaticTuning_Get
        /// <summary> Gets a database&apos;s automatic tuning. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DatabaseAutomaticTuning>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAutomaticTuningClientDiagnostics.CreateScope("DatabaseAutomaticTuning.Get");
            scope.Start();
            try
            {
                var response = await _databaseAutomaticTuningRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _databaseAutomaticTuningClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAutomaticTuning(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// OperationId: DatabaseAutomaticTuning_Get
        /// <summary> Gets a database&apos;s automatic tuning. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAutomaticTuning> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAutomaticTuningClientDiagnostics.CreateScope("DatabaseAutomaticTuning.Get");
            scope.Start();
            try
            {
                var response = _databaseAutomaticTuningRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _databaseAutomaticTuningClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAutomaticTuning(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// OperationId: DatabaseAutomaticTuning_Update
        /// <summary> Update automatic tuning properties for target database. </summary>
        /// <param name="parameters"> The requested automatic tuning resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<DatabaseAutomaticTuning>> UpdateAsync(DatabaseAutomaticTuningData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _databaseAutomaticTuningClientDiagnostics.CreateScope("DatabaseAutomaticTuning.Update");
            scope.Start();
            try
            {
                var response = await _databaseAutomaticTuningRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAutomaticTuning(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/automaticTuning/current
        /// OperationId: DatabaseAutomaticTuning_Update
        /// <summary> Update automatic tuning properties for target database. </summary>
        /// <param name="parameters"> The requested automatic tuning resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<DatabaseAutomaticTuning> Update(DatabaseAutomaticTuningData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _databaseAutomaticTuningClientDiagnostics.CreateScope("DatabaseAutomaticTuning.Update");
            scope.Start();
            try
            {
                var response = _databaseAutomaticTuningRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, parameters, cancellationToken);
                return Response.FromValue(new DatabaseAutomaticTuning(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAutomaticTuningClientDiagnostics.CreateScope("DatabaseAutomaticTuning.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAutomaticTuningClientDiagnostics.CreateScope("DatabaseAutomaticTuning.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
