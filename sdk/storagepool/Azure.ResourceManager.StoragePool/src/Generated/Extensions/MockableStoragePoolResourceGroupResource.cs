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
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableStoragePoolResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStoragePoolResourceGroupResource"/> class for mocking. </summary>
        protected MockableStoragePoolResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStoragePoolResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStoragePoolResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DiskPoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DiskPoolResources and their operations over a DiskPoolResource. </returns>
        public virtual DiskPoolCollection GetDiskPools()
        {
            return GetCachedClient(client => new DiskPoolCollection(client, Id));
        }

        /// <summary>
        /// Get a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DiskPoolResource>> GetDiskPoolAsync(string diskPoolName, CancellationToken cancellationToken = default)
        {
            return await GetDiskPools().GetAsync(diskPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DiskPoolResource> GetDiskPool(string diskPoolName, CancellationToken cancellationToken = default)
        {
            return GetDiskPools().Get(diskPoolName, cancellationToken);
        }
    }
}
