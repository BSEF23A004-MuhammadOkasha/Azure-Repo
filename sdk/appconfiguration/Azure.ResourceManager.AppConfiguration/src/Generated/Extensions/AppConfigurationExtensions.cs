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
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.AppConfiguration. </summary>
    public static partial class AppConfigurationExtensions
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
        /// Lists the configuration stores for a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfigurationStoreResource> GetConfigurationStoresAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetConfigurationStoresAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfigurationStoreResource> GetConfigurationStores(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetConfigurationStores(skipToken, cancellationToken);
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability
        /// Operation Id: CheckAppConfigurationNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityParameters"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityParameters"/> is null. </exception>
        public static async Task<Response<NameAvailabilityStatus>> CheckAppConfigurationNameAvailabilityAsync(this SubscriptionResource subscriptionResource, CheckNameAvailabilityParameters checkNameAvailabilityParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(checkNameAvailabilityParameters, nameof(checkNameAvailabilityParameters));

            return await GetExtensionClient(subscriptionResource).CheckAppConfigurationNameAvailabilityAsync(checkNameAvailabilityParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability
        /// Operation Id: CheckAppConfigurationNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityParameters"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityParameters"/> is null. </exception>
        public static Response<NameAvailabilityStatus> CheckAppConfigurationNameAvailability(this SubscriptionResource subscriptionResource, CheckNameAvailabilityParameters checkNameAvailabilityParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(checkNameAvailabilityParameters, nameof(checkNameAvailabilityParameters));

            return GetExtensionClient(subscriptionResource).CheckAppConfigurationNameAvailability(checkNameAvailabilityParameters, cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of ConfigurationStoreResources in the ConfigurationStoreResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ConfigurationStoreResources and their operations over a ConfigurationStoreResource. </returns>
        public static ConfigurationStoreCollection GetConfigurationStores(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetConfigurationStores();
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public static async Task<Response<ConfigurationStoreResource>> GetConfigurationStoreAsync(this ResourceGroup resourceGroup, string configStoreName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetConfigurationStores().GetAsync(configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public static Response<ConfigurationStoreResource> GetConfigurationStore(this ResourceGroup resourceGroup, string configStoreName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetConfigurationStores().Get(configStoreName, cancellationToken);
        }

        #region ConfigurationStoreResource
        /// <summary> Gets an object representing a ConfigurationStoreResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConfigurationStoreResource" /> object. </returns>
        public static ConfigurationStoreResource GetConfigurationStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConfigurationStoreResource.ValidateResourceId(id);
                return new ConfigurationStoreResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnectionResource
        /// <summary> Gets an object representing a PrivateEndpointConnectionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnectionResource" /> object. </returns>
        public static PrivateEndpointConnectionResource GetPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateEndpointConnectionResource.ValidateResourceId(id);
                return new PrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateLinkResource
        /// <summary> Gets an object representing a PrivateLinkResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateLinkResource" /> object. </returns>
        public static PrivateLinkResource GetPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateLinkResource.ValidateResourceId(id);
                return new PrivateLinkResource(client, id);
            }
            );
        }
        #endregion
    }
}
