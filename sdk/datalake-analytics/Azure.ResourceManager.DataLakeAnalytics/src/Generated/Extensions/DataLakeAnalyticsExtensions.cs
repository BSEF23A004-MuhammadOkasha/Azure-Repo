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
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataLakeAnalytics. </summary>
    public static partial class DataLakeAnalyticsExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within the current subscription. This includes a link to the next page, if any.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/accounts
        /// Operation Id: Accounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="top"> The number of items to return. Optional. </param>
        /// <param name="skip"> The number of items to skip over before returning elements. Optional. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional. </param>
        /// <param name="orderby"> OrderBy clause. One or more comma-separated expressions with an optional &quot;asc&quot; (the default) or &quot;desc&quot; depending on the order you&apos;d like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional. </param>
        /// <param name="count"> The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataLakeAnalyticsAccountBasic> GetAccountsAsync(this SubscriptionResource subscriptionResource, string filter = null, int? top = null, int? skip = null, string select = null, string orderby = null, bool? count = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAccountsAsync(filter, top, skip, select, orderby, count, cancellationToken);
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within the current subscription. This includes a link to the next page, if any.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/accounts
        /// Operation Id: Accounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="top"> The number of items to return. Optional. </param>
        /// <param name="skip"> The number of items to skip over before returning elements. Optional. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional. </param>
        /// <param name="orderby"> OrderBy clause. One or more comma-separated expressions with an optional &quot;asc&quot; (the default) or &quot;desc&quot; depending on the order you&apos;d like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional. </param>
        /// <param name="count"> The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataLakeAnalyticsAccountBasic> GetAccounts(this SubscriptionResource subscriptionResource, string filter = null, int? top = null, int? skip = null, string select = null, string orderby = null, bool? count = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAccounts(filter, top, skip, select, orderby, count, cancellationToken);
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/checkNameAvailability
        /// Operation Id: Accounts_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Analytics account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<NameAvailabilityInformation>> CheckNameAvailabilityAccountAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityAccountAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/checkNameAvailability
        /// Operation Id: Accounts_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Analytics account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<NameAvailabilityInformation> CheckNameAvailabilityAccount(this SubscriptionResource subscriptionResource, AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityAccount(location, content, cancellationToken);
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Analytics specified by resource location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/capability
        /// Operation Id: Locations_GetCapability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<CapabilityInformation>> GetCapabilityLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscriptionResource).GetCapabilityLocationAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Analytics specified by resource location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/capability
        /// Operation Id: Locations_GetCapability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<CapabilityInformation> GetCapabilityLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetCapabilityLocation(location, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DataLakeAnalyticsAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataLakeAnalyticsAccountResources and their operations over a DataLakeAnalyticsAccountResource. </returns>
        public static DataLakeAnalyticsAccountCollection GetDataLakeAnalyticsAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDataLakeAnalyticsAccounts();
        }

        /// <summary>
        /// Gets details of the specified Data Lake Analytics account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataLakeAnalyticsAccountResource>> GetDataLakeAnalyticsAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDataLakeAnalyticsAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details of the specified Data Lake Analytics account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DataLakeAnalyticsAccountResource> GetDataLakeAnalyticsAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDataLakeAnalyticsAccounts().Get(accountName, cancellationToken);
        }

        #region DataLakeAnalyticsAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsAccountResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsAccountResource" /> object. </returns>
        public static DataLakeAnalyticsAccountResource GetDataLakeAnalyticsAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataLakeAnalyticsAccountResource.ValidateResourceId(id);
                return new DataLakeAnalyticsAccountResource(client, id);
            }
            );
        }
        #endregion

        #region DataLakeStoreAccountInformationResource
        /// <summary>
        /// Gets an object representing a <see cref="DataLakeStoreAccountInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeStoreAccountInformationResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeStoreAccountInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeStoreAccountInformationResource" /> object. </returns>
        public static DataLakeStoreAccountInformationResource GetDataLakeStoreAccountInformationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataLakeStoreAccountInformationResource.ValidateResourceId(id);
                return new DataLakeStoreAccountInformationResource(client, id);
            }
            );
        }
        #endregion

        #region StorageAccountInformationResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountInformationResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountInformationResource" /> object. </returns>
        public static StorageAccountInformationResource GetStorageAccountInformationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageAccountInformationResource.ValidateResourceId(id);
                return new StorageAccountInformationResource(client, id);
            }
            );
        }
        #endregion

        #region StorageContainerResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageContainerResource.CreateResourceIdentifier" /> to create a <see cref="StorageContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageContainerResource" /> object. </returns>
        public static StorageContainerResource GetStorageContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageContainerResource.ValidateResourceId(id);
                return new StorageContainerResource(client, id);
            }
            );
        }
        #endregion

        #region ComputePolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="ComputePolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ComputePolicyResource.CreateResourceIdentifier" /> to create a <see cref="ComputePolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ComputePolicyResource" /> object. </returns>
        public static ComputePolicyResource GetComputePolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ComputePolicyResource.ValidateResourceId(id);
                return new ComputePolicyResource(client, id);
            }
            );
        }
        #endregion

        #region FirewallRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="FirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="FirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirewallRuleResource" /> object. </returns>
        public static FirewallRuleResource GetFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FirewallRuleResource.ValidateResourceId(id);
                return new FirewallRuleResource(client, id);
            }
            );
        }
        #endregion
    }
}
