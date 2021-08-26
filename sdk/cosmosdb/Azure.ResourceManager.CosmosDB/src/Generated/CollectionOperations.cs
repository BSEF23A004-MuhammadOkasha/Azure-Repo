// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> The Collection service client. </summary>
    public partial class CollectionOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal CollectionRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of CollectionOperations for mocking. </summary>
        protected CollectionOperations()
        {
        }

        /// <summary> Initializes a new instance of CollectionOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal CollectionOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-06-15")
        {
            RestClient = new CollectionRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account and collection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, <paramref name="collectionRid"/>, or <paramref name="filter"/> is null. </exception>
        public virtual AsyncPageable<Metric> ListMetricsAsync(string resourceGroupName, string accountName, string databaseRid, string collectionRid, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (databaseRid == null)
            {
                throw new ArgumentNullException(nameof(databaseRid));
            }
            if (collectionRid == null)
            {
                throw new ArgumentNullException(nameof(collectionRid));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            async Task<Page<Metric>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CollectionOperations.ListMetrics");
                scope.Start();
                try
                {
                    var response = await RestClient.ListMetricsAsync(resourceGroupName, accountName, databaseRid, collectionRid, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account and collection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, <paramref name="collectionRid"/>, or <paramref name="filter"/> is null. </exception>
        public virtual Pageable<Metric> ListMetrics(string resourceGroupName, string accountName, string databaseRid, string collectionRid, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (databaseRid == null)
            {
                throw new ArgumentNullException(nameof(databaseRid));
            }
            if (collectionRid == null)
            {
                throw new ArgumentNullException(nameof(collectionRid));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            Page<Metric> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CollectionOperations.ListMetrics");
                scope.Start();
                try
                {
                    var response = RestClient.ListMetrics(resourceGroupName, accountName, databaseRid, collectionRid, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieves the usages (most recent storage data) for the given collection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of usages to return. The supported parameter is name.value (name of the metric, can have an or of multiple names). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, or <paramref name="collectionRid"/> is null. </exception>
        public virtual AsyncPageable<Usage> ListUsagesAsync(string resourceGroupName, string accountName, string databaseRid, string collectionRid, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (databaseRid == null)
            {
                throw new ArgumentNullException(nameof(databaseRid));
            }
            if (collectionRid == null)
            {
                throw new ArgumentNullException(nameof(collectionRid));
            }

            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CollectionOperations.ListUsages");
                scope.Start();
                try
                {
                    var response = await RestClient.ListUsagesAsync(resourceGroupName, accountName, databaseRid, collectionRid, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieves the usages (most recent storage data) for the given collection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of usages to return. The supported parameter is name.value (name of the metric, can have an or of multiple names). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, or <paramref name="collectionRid"/> is null. </exception>
        public virtual Pageable<Usage> ListUsages(string resourceGroupName, string accountName, string databaseRid, string collectionRid, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (databaseRid == null)
            {
                throw new ArgumentNullException(nameof(databaseRid));
            }
            if (collectionRid == null)
            {
                throw new ArgumentNullException(nameof(collectionRid));
            }

            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CollectionOperations.ListUsages");
                scope.Start();
                try
                {
                    var response = RestClient.ListUsages(resourceGroupName, accountName, databaseRid, collectionRid, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieves metric definitions for the given collection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, or <paramref name="collectionRid"/> is null. </exception>
        public virtual AsyncPageable<MetricDefinition> ListMetricDefinitionsAsync(string resourceGroupName, string accountName, string databaseRid, string collectionRid, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (databaseRid == null)
            {
                throw new ArgumentNullException(nameof(databaseRid));
            }
            if (collectionRid == null)
            {
                throw new ArgumentNullException(nameof(collectionRid));
            }

            async Task<Page<MetricDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CollectionOperations.ListMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await RestClient.ListMetricDefinitionsAsync(resourceGroupName, accountName, databaseRid, collectionRid, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieves metric definitions for the given collection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, or <paramref name="collectionRid"/> is null. </exception>
        public virtual Pageable<MetricDefinition> ListMetricDefinitions(string resourceGroupName, string accountName, string databaseRid, string collectionRid, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (databaseRid == null)
            {
                throw new ArgumentNullException(nameof(databaseRid));
            }
            if (collectionRid == null)
            {
                throw new ArgumentNullException(nameof(collectionRid));
            }

            Page<MetricDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CollectionOperations.ListMetricDefinitions");
                scope.Start();
                try
                {
                    var response = RestClient.ListMetricDefinitions(resourceGroupName, accountName, databaseRid, collectionRid, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
