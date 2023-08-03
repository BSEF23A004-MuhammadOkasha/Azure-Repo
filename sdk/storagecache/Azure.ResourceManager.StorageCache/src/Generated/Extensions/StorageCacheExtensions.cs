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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StorageCache.Mocking;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StorageCache. </summary>
    public static partial class StorageCacheExtensions
    {
        private static StorageCacheArmClientMockingExtension GetStorageCacheArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new StorageCacheArmClientMockingExtension(client);
            });
        }

        private static StorageCacheResourceGroupMockingExtension GetStorageCacheResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageCacheResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static StorageCacheSubscriptionMockingExtension GetStorageCacheSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageCacheSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region AmlFileSystemResource
        /// <summary>
        /// Gets an object representing an <see cref="AmlFileSystemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AmlFileSystemResource.CreateResourceIdentifier" /> to create an <see cref="AmlFileSystemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AmlFileSystemResource" /> object. </returns>
        public static AmlFileSystemResource GetAmlFileSystemResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageCacheArmClientMockingExtension(client).GetAmlFileSystemResource(id);
        }
        #endregion

        #region StorageCacheResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageCacheResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageCacheResource.CreateResourceIdentifier" /> to create a <see cref="StorageCacheResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageCacheResource" /> object. </returns>
        public static StorageCacheResource GetStorageCacheResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageCacheArmClientMockingExtension(client).GetStorageCacheResource(id);
        }
        #endregion

        #region StorageTargetResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageTargetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageTargetResource.CreateResourceIdentifier" /> to create a <see cref="StorageTargetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageTargetResource" /> object. </returns>
        public static StorageTargetResource GetStorageTargetResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageCacheArmClientMockingExtension(client).GetStorageTargetResource(id);
        }
        #endregion

        /// <summary> Gets a collection of AmlFileSystemResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AmlFileSystemResources and their operations over a AmlFileSystemResource. </returns>
        public static AmlFileSystemCollection GetAmlFileSystems(this ResourceGroupResource resourceGroupResource)
        {
            return GetStorageCacheResourceGroupMockingExtension(resourceGroupResource).GetAmlFileSystems();
        }

        /// <summary>
        /// Returns an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AmlFileSystemResource>> GetAmlFileSystemAsync(this ResourceGroupResource resourceGroupResource, string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            return await GetStorageCacheResourceGroupMockingExtension(resourceGroupResource).GetAmlFileSystemAsync(amlFileSystemName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AmlFileSystemResource> GetAmlFileSystem(this ResourceGroupResource resourceGroupResource, string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheResourceGroupMockingExtension(resourceGroupResource).GetAmlFileSystem(amlFileSystemName, cancellationToken);
        }

        /// <summary> Gets a collection of StorageCacheResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageCacheResources and their operations over a StorageCacheResource. </returns>
        public static StorageCacheCollection GetStorageCaches(this ResourceGroupResource resourceGroupResource)
        {
            return GetStorageCacheResourceGroupMockingExtension(resourceGroupResource).GetStorageCaches();
        }

        /// <summary>
        /// Returns a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageCacheResource>> GetStorageCacheAsync(this ResourceGroupResource resourceGroupResource, string cacheName, CancellationToken cancellationToken = default)
        {
            return await GetStorageCacheResourceGroupMockingExtension(resourceGroupResource).GetStorageCacheAsync(cacheName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageCacheResource> GetStorageCache(this ResourceGroupResource resourceGroupResource, string cacheName, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheResourceGroupMockingExtension(resourceGroupResource).GetStorageCache(cacheName, cancellationToken);
        }

        /// <summary>
        /// Returns all AML file systems the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/amlFilesystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AmlFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AmlFileSystemResource> GetAmlFileSystemsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetAmlFileSystemsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns all AML file systems the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/amlFilesystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AmlFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AmlFileSystemResource> GetAmlFileSystems(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetAmlFileSystems(cancellationToken);
        }

        /// <summary>
        /// Check that subnets will be valid for AML file system create calls.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/checkAmlFSSubnets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>checkAmlFSSubnets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Information about the subnets to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response> CheckAmlFSSubnetsAsync(this SubscriptionResource subscriptionResource, AmlFileSystemSubnetContent content = null, CancellationToken cancellationToken = default)
        {
            return await GetStorageCacheSubscriptionMockingExtension(subscriptionResource).CheckAmlFSSubnetsAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check that subnets will be valid for AML file system create calls.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/checkAmlFSSubnets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>checkAmlFSSubnets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Information about the subnets to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response CheckAmlFSSubnets(this SubscriptionResource subscriptionResource, AmlFileSystemSubnetContent content = null, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).CheckAmlFSSubnets(content, cancellationToken);
        }

        /// <summary>
        /// Get the number of available IP addresses needed for the AML file system information provided.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/getRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>getRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Information to determine the number of available IPs a subnet will need to host the AML file system. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<RequiredAmlFileSystemSubnetsSize>> GetRequiredAmlFSSubnetsSizeAsync(this SubscriptionResource subscriptionResource, RequiredAmlFileSystemSubnetsSizeContent content = null, CancellationToken cancellationToken = default)
        {
            return await GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetRequiredAmlFSSubnetsSizeAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the number of available IP addresses needed for the AML file system information provided.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/getRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>getRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Information to determine the number of available IPs a subnet will need to host the AML file system. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<RequiredAmlFileSystemSubnetsSize> GetRequiredAmlFSSubnetsSize(this SubscriptionResource subscriptionResource, RequiredAmlFileSystemSubnetsSizeContent content = null, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetRequiredAmlFSSubnetsSize(content, cancellationToken);
        }

        /// <summary>
        /// Get the list of StorageCache.Cache SKUs available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheSku> GetStorageCacheSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetStorageCacheSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Get the list of StorageCache.Cache SKUs available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheSku> GetStorageCacheSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetStorageCacheSkus(cancellationToken);
        }

        /// <summary>
        /// Get the list of cache usage models available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/usageModels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageModels_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheUsageModel" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheUsageModel> GetUsageModelsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetUsageModelsAsync(cancellationToken);
        }

        /// <summary>
        /// Get the list of cache usage models available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/usageModels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageModels_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheUsageModel" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheUsageModel> GetUsageModels(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetUsageModels(cancellationToken);
        }

        /// <summary>
        /// Gets the quantity used and quota limit for resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AscUsages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the region to query for usage information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheUsage> GetStorageCacheUsagesAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetStorageCacheUsagesAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets the quantity used and quota limit for resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AscUsages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the region to query for usage information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheUsage> GetStorageCacheUsages(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetStorageCacheUsages(location, cancellationToken);
        }

        /// <summary>
        /// Returns all caches the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheResource> GetStorageCachesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetStorageCachesAsync(cancellationToken);
        }

        /// <summary>
        /// Returns all caches the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheResource> GetStorageCaches(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageCacheSubscriptionMockingExtension(subscriptionResource).GetStorageCaches(cancellationToken);
        }
    }
}
