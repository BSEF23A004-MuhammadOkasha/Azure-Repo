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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecoveryNetworkResource"/> and their operations.
    /// Each <see cref="SiteRecoveryNetworkResource"/> in the collection will belong to the same instance of <see cref="SiteRecoveryFabricResource"/>.
    /// To get a <see cref="SiteRecoveryNetworkCollection"/> instance call the GetSiteRecoveryNetworks method from an instance of <see cref="SiteRecoveryFabricResource"/>.
    /// </summary>
    public partial class SiteRecoveryNetworkCollection : ArmCollection, IEnumerable<SiteRecoveryNetworkResource>, IAsyncEnumerable<SiteRecoveryNetworkResource>
    {
        private readonly ClientDiagnostics _siteRecoveryNetworkReplicationNetworksClientDiagnostics;
        private readonly ReplicationNetworksRestOperations _siteRecoveryNetworkReplicationNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkCollection"/> class for mocking. </summary>
        protected SiteRecoveryNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteRecoveryNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryNetworkReplicationNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryNetworkResource.ResourceType, out string siteRecoveryNetworkReplicationNetworksApiVersion);
            _siteRecoveryNetworkReplicationNetworksRestClient = new ReplicationNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryNetworkReplicationNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteRecoveryFabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteRecoveryFabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of a network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryNetworkResource>> GetAsync(string networkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkName, nameof(networkName));

            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkReplicationNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkName"/> is null. </exception>
        public virtual Response<SiteRecoveryNetworkResource> Get(string networkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkName, nameof(networkName));

            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkReplicationNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the networks available for a fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_ListByReplicationFabrics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryNetworkReplicationNetworksRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryNetworkReplicationNetworksRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteRecoveryNetworkResource(Client, SiteRecoveryNetworkData.DeserializeSiteRecoveryNetworkData(e)), _siteRecoveryNetworkReplicationNetworksClientDiagnostics, Pipeline, "SiteRecoveryNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the networks available for a fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_ListByReplicationFabrics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryNetworkReplicationNetworksRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryNetworkReplicationNetworksRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteRecoveryNetworkResource(Client, SiteRecoveryNetworkData.DeserializeSiteRecoveryNetworkData(e)), _siteRecoveryNetworkReplicationNetworksClientDiagnostics, Pipeline, "SiteRecoveryNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkName, nameof(networkName));

            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkReplicationNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkName, nameof(networkName));

            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkReplicationNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryNetworkResource>> GetIfExistsAsync(string networkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkName, nameof(networkName));

            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkReplicationNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryNetworkResource> GetIfExists(string networkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkName, nameof(networkName));

            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkReplicationNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryNetworkResource> IEnumerable<SiteRecoveryNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryNetworkResource> IAsyncEnumerable<SiteRecoveryNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
