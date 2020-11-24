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
    /// <summary> The PartitionKeyRangeId service client. </summary>
    public partial class PartitionKeyRangeIdOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PartitionKeyRangeIdRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of PartitionKeyRangeIdOperations for mocking. </summary>
        protected PartitionKeyRangeIdOperations()
        {
        }
        /// <summary> Initializes a new instance of PartitionKeyRangeIdOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal PartitionKeyRangeIdOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new PartitionKeyRangeIdRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given partition key range id. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="partitionKeyRangeId"> Partition Key Range Id for which to get data. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, <paramref name="collectionRid"/>, <paramref name="partitionKeyRangeId"/>, or <paramref name="filter"/> is null. </exception>
        public virtual AsyncPageable<PartitionMetric> ListMetricsAsync(string resourceGroupName, string accountName, string databaseRid, string collectionRid, string partitionKeyRangeId, string filter, CancellationToken cancellationToken = default)
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
            if (partitionKeyRangeId == null)
            {
                throw new ArgumentNullException(nameof(partitionKeyRangeId));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            async Task<Page<PartitionMetric>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PartitionKeyRangeIdOperations.ListMetrics");
                scope.Start();
                try
                {
                    var response = await RestClient.ListMetricsAsync(resourceGroupName, accountName, databaseRid, collectionRid, partitionKeyRangeId, filter, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Retrieves the metrics determined by the given filter for the given partition key range id. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="databaseRid"> Cosmos DB database rid. </param>
        /// <param name="collectionRid"> Cosmos DB collection rid. </param>
        /// <param name="partitionKeyRangeId"> Partition Key Range Id for which to get data. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="databaseRid"/>, <paramref name="collectionRid"/>, <paramref name="partitionKeyRangeId"/>, or <paramref name="filter"/> is null. </exception>
        public virtual Pageable<PartitionMetric> ListMetrics(string resourceGroupName, string accountName, string databaseRid, string collectionRid, string partitionKeyRangeId, string filter, CancellationToken cancellationToken = default)
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
            if (partitionKeyRangeId == null)
            {
                throw new ArgumentNullException(nameof(partitionKeyRangeId));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            Page<PartitionMetric> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PartitionKeyRangeIdOperations.ListMetrics");
                scope.Start();
                try
                {
                    var response = RestClient.ListMetrics(resourceGroupName, accountName, databaseRid, collectionRid, partitionKeyRangeId, filter, cancellationToken);
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
