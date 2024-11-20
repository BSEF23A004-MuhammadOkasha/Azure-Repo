// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Disk.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDiskResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDiskResourceGroupResource"/> class for mocking. </summary>
        protected MockableDiskResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDiskResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDiskResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ManagedDiskResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ManagedDiskResources and their operations over a ManagedDiskResource. </returns>
        public virtual ManagedDiskCollection GetManagedDisks()
        {
            return GetCachedClient(client => new ManagedDiskCollection(client, Id));
        }

        /// <summary>
        /// Gets information about a disk.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDiskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedDiskResource>> GetManagedDiskAsync(string diskName, CancellationToken cancellationToken = default)
        {
            return await GetManagedDisks().GetAsync(diskName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a disk.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDiskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedDiskResource> GetManagedDisk(string diskName, CancellationToken cancellationToken = default)
        {
            return GetManagedDisks().Get(diskName, cancellationToken);
        }

        /// <summary> Gets a collection of DiskAccessResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DiskAccessResources and their operations over a DiskAccessResource. </returns>
        public virtual DiskAccessCollection GetDiskAccesses()
        {
            return GetCachedClient(client => new DiskAccessCollection(client, Id));
        }

        /// <summary>
        /// Gets information about a disk access resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskAccessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskAccessName"> The name of the disk access resource that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskAccessName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskAccessName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DiskAccessResource>> GetDiskAccessAsync(string diskAccessName, CancellationToken cancellationToken = default)
        {
            return await GetDiskAccesses().GetAsync(diskAccessName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a disk access resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskAccessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskAccessName"> The name of the disk access resource that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskAccessName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskAccessName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DiskAccessResource> GetDiskAccess(string diskAccessName, CancellationToken cancellationToken = default)
        {
            return GetDiskAccesses().Get(diskAccessName, cancellationToken);
        }

        /// <summary> Gets a collection of DiskEncryptionSetResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DiskEncryptionSetResources and their operations over a DiskEncryptionSetResource. </returns>
        public virtual DiskEncryptionSetCollection GetDiskEncryptionSets()
        {
            return GetCachedClient(client => new DiskEncryptionSetCollection(client, Id));
        }

        /// <summary>
        /// Gets information about a disk encryption set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DiskEncryptionSetResource>> GetDiskEncryptionSetAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            return await GetDiskEncryptionSets().GetAsync(diskEncryptionSetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a disk encryption set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DiskEncryptionSetResource> GetDiskEncryptionSet(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            return GetDiskEncryptionSets().Get(diskEncryptionSetName, cancellationToken);
        }

        /// <summary> Gets a collection of DiskRestorePointResources in the ResourceGroupResource. </summary>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of DiskRestorePointResources and their operations over a DiskRestorePointResource. </returns>
        public virtual DiskRestorePointCollection GetDiskRestorePoints(string restorePointGroupName, string vmRestorePointName)
        {
            return new DiskRestorePointCollection(Client, Id, restorePointGroupName, vmRestorePointName);
        }

        /// <summary>
        /// Get disk restorePoint resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{vmRestorePointName}/diskRestorePoints/{diskRestorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskRestorePoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DiskRestorePointResource>> GetDiskRestorePointAsync(string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            return await GetDiskRestorePoints(restorePointGroupName, vmRestorePointName).GetAsync(diskRestorePointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get disk restorePoint resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{vmRestorePointName}/diskRestorePoints/{diskRestorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskRestorePoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DiskRestorePointResource> GetDiskRestorePoint(string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            return GetDiskRestorePoints(restorePointGroupName, vmRestorePointName).Get(diskRestorePointName, cancellationToken);
        }

        /// <summary> Gets a collection of SnapshotResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SnapshotResources and their operations over a SnapshotResource. </returns>
        public virtual SnapshotCollection GetSnapshots()
        {
            return GetCachedClient(client => new SnapshotCollection(client, Id));
        }

        /// <summary>
        /// Gets information about a snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SnapshotResource>> GetSnapshotAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            return await GetSnapshots().GetAsync(snapshotName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SnapshotResource> GetSnapshot(string snapshotName, CancellationToken cancellationToken = default)
        {
            return GetSnapshots().Get(snapshotName, cancellationToken);
        }
    }
}
