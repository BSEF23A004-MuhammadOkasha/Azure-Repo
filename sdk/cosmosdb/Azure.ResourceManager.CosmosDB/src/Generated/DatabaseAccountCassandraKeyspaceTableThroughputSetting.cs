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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a DatabaseAccountCassandraKeyspaceTableThroughputSetting along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseAccountCassandraKeyspaceTableThroughputSetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseAccountCassandraKeyspaceTableThroughputSetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string keyspaceName, string tableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables/{tableName}/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics;
        private readonly CassandraResourcesRestOperations _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient;
        private readonly ThroughputSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountCassandraKeyspaceTableThroughputSetting"/> class for mocking. </summary>
        protected DatabaseAccountCassandraKeyspaceTableThroughputSetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseAccountCassandraKeyspaceTableThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseAccountCassandraKeyspaceTableThroughputSetting(ArmClient client, ThroughputSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountCassandraKeyspaceTableThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseAccountCassandraKeyspaceTableThroughputSetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesApiVersion);
            _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient = new CassandraResourcesRestOperations(_databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables/throughputSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ThroughputSettingsData Data
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

        /// <summary> Gets the RUs per second of the Cassandra table under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the RUs per second of the Cassandra table under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update RUs per second of an Azure Cosmos DB Cassandra table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current Cassandra table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public async virtual Task<DatabaseAccountCassandraKeyspaceTableThroughputSettingCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            if (updateThroughputParameters == null)
            {
                throw new ArgumentNullException(nameof(updateThroughputParameters));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.UpdateCassandraTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseAccountCassandraKeyspaceTableThroughputSettingCreateOrUpdateOperation(Client, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.CreateUpdateCassandraTableThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response);
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

        /// <summary> Update RUs per second of an Azure Cosmos DB Cassandra table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current Cassandra table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual DatabaseAccountCassandraKeyspaceTableThroughputSettingCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            if (updateThroughputParameters == null)
            {
                throw new ArgumentNullException(nameof(updateThroughputParameters));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.UpdateCassandraTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken);
                var operation = new DatabaseAccountCassandraKeyspaceTableThroughputSettingCreateOrUpdateOperation(Client, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.CreateUpdateCassandraTableThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response);
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

        /// <summary> Migrate an Azure Cosmos DB Cassandra table from manual throughput to autoscale. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToAutoscaleOperation> MigrateCassandraTableToAutoscaleAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.MigrateCassandraTableToAutoscale");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.MigrateCassandraTableToAutoscaleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToAutoscaleOperation(_databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraTableToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
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

        /// <summary> Migrate an Azure Cosmos DB Cassandra table from manual throughput to autoscale. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToAutoscaleOperation MigrateCassandraTableToAutoscale(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.MigrateCassandraTableToAutoscale");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.MigrateCassandraTableToAutoscale(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToAutoscaleOperation(_databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraTableToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
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

        /// <summary> Migrate an Azure Cosmos DB Cassandra table from autoscale to manual throughput. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToManualThroughputOperation> MigrateCassandraTableToManualThroughputAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.MigrateCassandraTableToManualThroughput");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.MigrateCassandraTableToManualThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToManualThroughputOperation(_databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraTableToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
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

        /// <summary> Migrate an Azure Cosmos DB Cassandra table from autoscale to manual throughput. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToManualThroughputOperation MigrateCassandraTableToManualThroughput(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.MigrateCassandraTableToManualThroughput");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.MigrateCassandraTableToManualThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new DatabaseAccountCassandraKeyspaceTableThroughputSettingMigrateCassandraTableToManualThroughputOperation(_databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraTableToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
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

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DatabaseAccountCassandraKeyspaceTableThroughputSetting> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesRestClient.GetCassandraTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceTableThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
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
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.GetAvailableLocations");
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
            using var scope = _databaseAccountCassandraKeyspaceTableThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceTableThroughputSetting.GetAvailableLocations");
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
