// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDBForPostgreSql;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableCosmosDBForPostgreSqlSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _cosmosDBForPostgreSqlClusterClustersClientDiagnostics;
        private ClustersRestOperations _cosmosDBForPostgreSqlClusterClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBForPostgreSqlSubscriptionResource"/> class for mocking. </summary>
        protected MockableCosmosDBForPostgreSqlSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBForPostgreSqlSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCosmosDBForPostgreSqlSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CosmosDBForPostgreSqlClusterClustersClientDiagnostics => _cosmosDBForPostgreSqlClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", CosmosDBForPostgreSqlClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations CosmosDBForPostgreSqlClusterClustersRestClient => _cosmosDBForPostgreSqlClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CosmosDBForPostgreSqlClusterResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBForPostgreSqlClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBForPostgreSqlClusterResource> GetCosmosDBForPostgreSqlClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CosmosDBForPostgreSqlClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CosmosDBForPostgreSqlClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CosmosDBForPostgreSqlClusterResource(Client, CosmosDBForPostgreSqlClusterData.DeserializeCosmosDBForPostgreSqlClusterData(e)), CosmosDBForPostgreSqlClusterClustersClientDiagnostics, Pipeline, "MockableCosmosDBForPostgreSqlSubscriptionResource.GetCosmosDBForPostgreSqlClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBForPostgreSqlClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBForPostgreSqlClusterResource> GetCosmosDBForPostgreSqlClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CosmosDBForPostgreSqlClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CosmosDBForPostgreSqlClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CosmosDBForPostgreSqlClusterResource(Client, CosmosDBForPostgreSqlClusterData.DeserializeCosmosDBForPostgreSqlClusterData(e)), CosmosDBForPostgreSqlClusterClustersClientDiagnostics, Pipeline, "MockableCosmosDBForPostgreSqlSubscriptionResource.GetCosmosDBForPostgreSqlClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks availability of a cluster name. Cluster names should be globally unique; at least 3 characters and at most 40 characters long; they must only contain lowercase letters, numbers, and hyphens; and must not start or end with a hyphen.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if cluster name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CosmosDBForPostgreSqlClusterNameAvailabilityResult>> CheckCosmosDBForPostgreSqlClusterNameAvailabilityAsync(CosmosDBForPostgreSqlClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CosmosDBForPostgreSqlClusterClustersClientDiagnostics.CreateScope("MockableCosmosDBForPostgreSqlSubscriptionResource.CheckCosmosDBForPostgreSqlClusterNameAvailability");
            scope.Start();
            try
            {
                var response = await CosmosDBForPostgreSqlClusterClustersRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks availability of a cluster name. Cluster names should be globally unique; at least 3 characters and at most 40 characters long; they must only contain lowercase letters, numbers, and hyphens; and must not start or end with a hyphen.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if cluster name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<CosmosDBForPostgreSqlClusterNameAvailabilityResult> CheckCosmosDBForPostgreSqlClusterNameAvailability(CosmosDBForPostgreSqlClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CosmosDBForPostgreSqlClusterClustersClientDiagnostics.CreateScope("MockableCosmosDBForPostgreSqlSubscriptionResource.CheckCosmosDBForPostgreSqlClusterNameAvailability");
            scope.Start();
            try
            {
                var response = CosmosDBForPostgreSqlClusterClustersRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
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
