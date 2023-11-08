// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MixedReality;

namespace Azure.ResourceManager.MixedReality.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMixedRealityResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMixedRealityResourceGroupResource"/> class for mocking. </summary>
        protected MockableMixedRealityResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMixedRealityResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMixedRealityResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SpatialAnchorsAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SpatialAnchorsAccountResources and their operations over a SpatialAnchorsAccountResource. </returns>
        public virtual SpatialAnchorsAccountCollection GetSpatialAnchorsAccounts()
        {
            return GetCachedClient(client => new SpatialAnchorsAccountCollection(client, Id));
        }

        /// <summary>
        /// Retrieve a Spatial Anchors Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SpatialAnchorsAccountResource>> GetSpatialAnchorsAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetSpatialAnchorsAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve a Spatial Anchors Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SpatialAnchorsAccountResource> GetSpatialAnchorsAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetSpatialAnchorsAccounts().Get(accountName, cancellationToken);
        }

        /// <summary> Gets a collection of RemoteRenderingAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of RemoteRenderingAccountResources and their operations over a RemoteRenderingAccountResource. </returns>
        public virtual RemoteRenderingAccountCollection GetRemoteRenderingAccounts()
        {
            return GetCachedClient(client => new RemoteRenderingAccountCollection(client, Id));
        }

        /// <summary>
        /// Retrieve a Remote Rendering Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RemoteRenderingAccountResource>> GetRemoteRenderingAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetRemoteRenderingAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve a Remote Rendering Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RemoteRenderingAccountResource> GetRemoteRenderingAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetRemoteRenderingAccounts().Get(accountName, cancellationToken);
        }
    }
}
