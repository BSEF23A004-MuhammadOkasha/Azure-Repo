// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of CosmosDBLocation and their operations over its parent. </summary>
    public partial class CosmosDBLocationCollection : ArmCollection, IEnumerable<CosmosDBLocation>, IAsyncEnumerable<CosmosDBLocation>
    {
        private readonly ClientDiagnostics _cosmosDBLocationLocationsClientDiagnostics;
        private readonly LocationsRestOperations _cosmosDBLocationLocationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocationCollection"/> class for mocking. </summary>
        protected CosmosDBLocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBLocationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBLocationLocationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBLocation.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBLocation.ResourceType, out string cosmosDBLocationLocationsApiVersion);
            _cosmosDBLocationLocationsRestClient = new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBLocationLocationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public virtual async Task<Response<CosmosDBLocation>> GetAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBLocationLocationsRestClient.GetAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public virtual Response<CosmosDBLocation> Get(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBLocationLocationsRestClient.Get(Id.SubscriptionId, location, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Cosmos DB locations and their properties
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations
        /// Operation Id: Locations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBLocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBLocation> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CosmosDBLocation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cosmosDBLocationLocationsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CosmosDBLocation(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List Cosmos DB locations and their properties
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations
        /// Operation Id: Locations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBLocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBLocation> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CosmosDBLocation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cosmosDBLocationLocationsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CosmosDBLocation(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public virtual Response<bool> Exists(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public virtual async Task<Response<CosmosDBLocation>> GetIfExistsAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBLocationLocationsRestClient.GetAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CosmosDBLocation>(null, response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public virtual Response<CosmosDBLocation> GetIfExists(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBLocationLocationsRestClient.Get(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CosmosDBLocation>(null, response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBLocation> IEnumerable<CosmosDBLocation>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBLocation> IAsyncEnumerable<CosmosDBLocation>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
