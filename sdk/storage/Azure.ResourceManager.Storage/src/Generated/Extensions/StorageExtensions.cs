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
using Azure.ResourceManager.Storage.Mocking;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Storage. </summary>
    public static partial class StorageExtensions
    {
        private static StorageArmClientMockingExtension GetStorageArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new StorageArmClientMockingExtension(client);
            });
        }

        private static StorageResourceGroupMockingExtension GetStorageResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static StorageSubscriptionMockingExtension GetStorageSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region StorageAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountResource" /> object. </returns>
        public static StorageAccountResource GetStorageAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetStorageAccountResource(id);
        }
        #endregion

        #region DeletedAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="DeletedAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedAccountResource.CreateResourceIdentifier" /> to create a <see cref="DeletedAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAccountResource" /> object. </returns>
        public static DeletedAccountResource GetDeletedAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetDeletedAccountResource(id);
        }
        #endregion

        #region StorageAccountManagementPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountManagementPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountManagementPolicyResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountManagementPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountManagementPolicyResource" /> object. </returns>
        public static StorageAccountManagementPolicyResource GetStorageAccountManagementPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetStorageAccountManagementPolicyResource(id);
        }
        #endregion

        #region BlobInventoryPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobInventoryPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobInventoryPolicyResource.CreateResourceIdentifier" /> to create a <see cref="BlobInventoryPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobInventoryPolicyResource" /> object. </returns>
        public static BlobInventoryPolicyResource GetBlobInventoryPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetBlobInventoryPolicyResource(id);
        }
        #endregion

        #region StoragePrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="StoragePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StoragePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="StoragePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StoragePrivateEndpointConnectionResource" /> object. </returns>
        public static StoragePrivateEndpointConnectionResource GetStoragePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetStoragePrivateEndpointConnectionResource(id);
        }
        #endregion

        #region ObjectReplicationPolicyResource
        /// <summary>
        /// Gets an object representing an <see cref="ObjectReplicationPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ObjectReplicationPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ObjectReplicationPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ObjectReplicationPolicyResource" /> object. </returns>
        public static ObjectReplicationPolicyResource GetObjectReplicationPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetObjectReplicationPolicyResource(id);
        }
        #endregion

        #region StorageAccountLocalUserResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountLocalUserResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountLocalUserResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountLocalUserResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountLocalUserResource" /> object. </returns>
        public static StorageAccountLocalUserResource GetStorageAccountLocalUserResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetStorageAccountLocalUserResource(id);
        }
        #endregion

        #region EncryptionScopeResource
        /// <summary>
        /// Gets an object representing an <see cref="EncryptionScopeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EncryptionScopeResource.CreateResourceIdentifier" /> to create an <see cref="EncryptionScopeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EncryptionScopeResource" /> object. </returns>
        public static EncryptionScopeResource GetEncryptionScopeResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetEncryptionScopeResource(id);
        }
        #endregion

        #region BlobServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobServiceResource.CreateResourceIdentifier" /> to create a <see cref="BlobServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobServiceResource" /> object. </returns>
        public static BlobServiceResource GetBlobServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetBlobServiceResource(id);
        }
        #endregion

        #region BlobContainerResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobContainerResource.CreateResourceIdentifier" /> to create a <see cref="BlobContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobContainerResource" /> object. </returns>
        public static BlobContainerResource GetBlobContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetBlobContainerResource(id);
        }
        #endregion

        #region ImmutabilityPolicyResource
        /// <summary>
        /// Gets an object representing an <see cref="ImmutabilityPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ImmutabilityPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ImmutabilityPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImmutabilityPolicyResource" /> object. </returns>
        public static ImmutabilityPolicyResource GetImmutabilityPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetImmutabilityPolicyResource(id);
        }
        #endregion

        #region FileServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="FileServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileServiceResource.CreateResourceIdentifier" /> to create a <see cref="FileServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileServiceResource" /> object. </returns>
        public static FileServiceResource GetFileServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetFileServiceResource(id);
        }
        #endregion

        #region FileShareResource
        /// <summary>
        /// Gets an object representing a <see cref="FileShareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileShareResource.CreateResourceIdentifier" /> to create a <see cref="FileShareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileShareResource" /> object. </returns>
        public static FileShareResource GetFileShareResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetFileShareResource(id);
        }
        #endregion

        #region QueueServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="QueueServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QueueServiceResource.CreateResourceIdentifier" /> to create a <see cref="QueueServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QueueServiceResource" /> object. </returns>
        public static QueueServiceResource GetQueueServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetQueueServiceResource(id);
        }
        #endregion

        #region StorageQueueResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageQueueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageQueueResource.CreateResourceIdentifier" /> to create a <see cref="StorageQueueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageQueueResource" /> object. </returns>
        public static StorageQueueResource GetStorageQueueResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetStorageQueueResource(id);
        }
        #endregion

        #region TableServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="TableServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TableServiceResource.CreateResourceIdentifier" /> to create a <see cref="TableServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableServiceResource" /> object. </returns>
        public static TableServiceResource GetTableServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetTableServiceResource(id);
        }
        #endregion

        #region TableResource
        /// <summary>
        /// Gets an object representing a <see cref="TableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TableResource.CreateResourceIdentifier" /> to create a <see cref="TableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableResource" /> object. </returns>
        public static TableResource GetTableResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageArmClientMockingExtension(client).GetTableResource(id);
        }
        #endregion

        /// <summary> Gets a collection of StorageAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageAccountResources and their operations over a StorageAccountResource. </returns>
        public static StorageAccountCollection GetStorageAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetStorageResourceGroupMockingExtension(resourceGroupResource).GetStorageAccounts();
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account's properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageAccountResource>> GetStorageAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return await GetStorageResourceGroupMockingExtension(resourceGroupResource).GetStorageAccountAsync(accountName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account's properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageAccountResource> GetStorageAccount(this ResourceGroupResource resourceGroupResource, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return GetStorageResourceGroupMockingExtension(resourceGroupResource).GetStorageAccount(accountName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of DeletedAccountResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedAccountResources and their operations over a DeletedAccountResource. </returns>
        public static DeletedAccountCollection GetDeletedAccounts(this SubscriptionResource subscriptionResource)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetDeletedAccounts();
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeletedAccountResource>> GetDeletedAccountAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return await GetStorageSubscriptionMockingExtension(subscriptionResource).GetDeletedAccountAsync(location, deletedAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DeletedAccountResource> GetDeletedAccount(this SubscriptionResource subscriptionResource, AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetDeletedAccount(location, deletedAccountName, cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageSkuInformation> GetSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageSkuInformation> GetSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetSkus(cancellationToken);
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<StorageAccountNameAvailabilityResult>> CheckStorageAccountNameAvailabilityAsync(this SubscriptionResource subscriptionResource, StorageAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetStorageSubscriptionMockingExtension(subscriptionResource).CheckStorageAccountNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<StorageAccountNameAvailabilityResult> CheckStorageAccountNameAvailability(this SubscriptionResource subscriptionResource, StorageAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).CheckStorageAccountNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageAccountResource> GetStorageAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetStorageAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageAccountResource> GetStorageAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetStorageAccounts(cancellationToken);
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedAccountResource> GetDeletedAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetDeletedAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedAccountResource> GetDeletedAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetDeletedAccounts(cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageUsage> GetUsagesByLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetUsagesByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageUsage> GetUsagesByLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetStorageSubscriptionMockingExtension(subscriptionResource).GetUsagesByLocation(location, cancellationToken);
        }
    }
}
