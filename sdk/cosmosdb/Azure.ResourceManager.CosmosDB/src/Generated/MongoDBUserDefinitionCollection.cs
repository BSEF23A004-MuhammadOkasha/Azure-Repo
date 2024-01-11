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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="MongoDBUserDefinitionResource"/> and their operations.
    /// Each <see cref="MongoDBUserDefinitionResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="MongoDBUserDefinitionCollection"/> instance call the GetMongoDBUserDefinitions method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class MongoDBUserDefinitionCollection : ArmCollection, IEnumerable<MongoDBUserDefinitionResource>, IAsyncEnumerable<MongoDBUserDefinitionResource>
    {
        private readonly ClientDiagnostics _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _mongoDBUserDefinitionMongoDBResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MongoDBUserDefinitionCollection"/> class for mocking. </summary>
        protected MongoDBUserDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MongoDBUserDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MongoDBUserDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", MongoDBUserDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MongoDBUserDefinitionResource.ResourceType, out string mongoDBUserDefinitionMongoDBResourcesApiVersion);
            _mongoDBUserDefinitionMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mongoDBUserDefinitionMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB Mongo User Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_CreateUpdateMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="content"> The properties required to create or update a User Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<MongoDBUserDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string mongoUserDefinitionId, MongoDBUserDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mongoDBUserDefinitionMongoDBResourcesRestClient.CreateUpdateMongoUserDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<MongoDBUserDefinitionResource>(new MongoDBUserDefinitionOperationSource(Client), _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBUserDefinitionMongoDBResourcesRestClient.CreateCreateUpdateMongoUserDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB Mongo User Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_CreateUpdateMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="content"> The properties required to create or update a User Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<MongoDBUserDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string mongoUserDefinitionId, MongoDBUserDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mongoDBUserDefinitionMongoDBResourcesRestClient.CreateUpdateMongoUserDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, content, cancellationToken);
                var operation = new CosmosDBArmOperation<MongoDBUserDefinitionResource>(new MongoDBUserDefinitionOperationSource(Client), _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBUserDefinitionMongoDBResourcesRestClient.CreateCreateUpdateMongoUserDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves the properties of an existing Azure Cosmos DB Mongo User Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> is null. </exception>
        public virtual async Task<Response<MongoDBUserDefinitionResource>> GetAsync(string mongoUserDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _mongoDBUserDefinitionMongoDBResourcesRestClient.GetMongoUserDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBUserDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB Mongo User Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> is null. </exception>
        public virtual Response<MongoDBUserDefinitionResource> Get(string mongoUserDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _mongoDBUserDefinitionMongoDBResourcesRestClient.GetMongoUserDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBUserDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB Mongo User Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_ListMongoUserDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MongoDBUserDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MongoDBUserDefinitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoDBUserDefinitionMongoDBResourcesRestClient.CreateListMongoUserDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MongoDBUserDefinitionResource(Client, MongoDBUserDefinitionData.DeserializeMongoDBUserDefinitionData(e)), _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics, Pipeline, "MongoDBUserDefinitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB Mongo User Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_ListMongoUserDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MongoDBUserDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MongoDBUserDefinitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoDBUserDefinitionMongoDBResourcesRestClient.CreateListMongoUserDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new MongoDBUserDefinitionResource(Client, MongoDBUserDefinitionData.DeserializeMongoDBUserDefinitionData(e)), _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics, Pipeline, "MongoDBUserDefinitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mongoUserDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mongoDBUserDefinitionMongoDBResourcesRestClient.GetMongoUserDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> is null. </exception>
        public virtual Response<bool> Exists(string mongoUserDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _mongoDBUserDefinitionMongoDBResourcesRestClient.GetMongoUserDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> is null. </exception>
        public virtual async Task<NullableResponse<MongoDBUserDefinitionResource>> GetIfExistsAsync(string mongoUserDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mongoDBUserDefinitionMongoDBResourcesRestClient.GetMongoUserDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MongoDBUserDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new MongoDBUserDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbUserDefinitions/{mongoUserDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoUserDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBUserDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoUserDefinitionId"> The ID for the User Definition {dbName.userName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoUserDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoUserDefinitionId"/> is null. </exception>
        public virtual NullableResponse<MongoDBUserDefinitionResource> GetIfExists(string mongoUserDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoUserDefinitionId, nameof(mongoUserDefinitionId));

            using var scope = _mongoDBUserDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBUserDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mongoDBUserDefinitionMongoDBResourcesRestClient.GetMongoUserDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoUserDefinitionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MongoDBUserDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new MongoDBUserDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MongoDBUserDefinitionResource> IEnumerable<MongoDBUserDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MongoDBUserDefinitionResource> IAsyncEnumerable<MongoDBUserDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
