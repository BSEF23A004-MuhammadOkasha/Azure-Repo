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
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DeviceUpdate. </summary>
    public static partial class DeviceUpdateExtensions
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
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResponse>> CheckDeviceUpdateNameAvailabilityAsync(this SubscriptionResource subscriptionResource, CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            return await GetExtensionClient(subscriptionResource).CheckDeviceUpdateNameAvailabilityAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public static Response<CheckNameAvailabilityResponse> CheckDeviceUpdateNameAvailability(this SubscriptionResource subscriptionResource, CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            return GetExtensionClient(subscriptionResource).CheckDeviceUpdateNameAvailability(request, cancellationToken);
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeviceUpdateAccountResource> GetDeviceUpdateAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeviceUpdateAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeviceUpdateAccountResource> GetDeviceUpdateAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeviceUpdateAccounts(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeviceUpdateAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeviceUpdateAccountResources and their operations over a DeviceUpdateAccountResource. </returns>
        public static DeviceUpdateAccountCollection GetDeviceUpdateAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDeviceUpdateAccounts();
        }

        /// <summary>
        /// Returns account details for the given account name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeviceUpdateAccountResource>> GetDeviceUpdateAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDeviceUpdateAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns account details for the given account name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DeviceUpdateAccountResource> GetDeviceUpdateAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDeviceUpdateAccounts().Get(accountName, cancellationToken);
        }

        #region DeviceUpdateAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="DeviceUpdateAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceUpdateAccountResource.CreateResourceIdentifier" /> to create a <see cref="DeviceUpdateAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceUpdateAccountResource" /> object. </returns>
        public static DeviceUpdateAccountResource GetDeviceUpdateAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeviceUpdateAccountResource.ValidateResourceId(id);
                return new DeviceUpdateAccountResource(client, id);
            }
            );
        }
        #endregion

        #region DeviceUpdateInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="DeviceUpdateInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceUpdateInstanceResource.CreateResourceIdentifier" /> to create a <see cref="DeviceUpdateInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceUpdateInstanceResource" /> object. </returns>
        public static DeviceUpdateInstanceResource GetDeviceUpdateInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeviceUpdateInstanceResource.ValidateResourceId(id);
                return new DeviceUpdateInstanceResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="PrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
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
        /// <summary>
        /// Gets an object representing a <see cref="PrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
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

        #region PrivateEndpointConnectionProxyResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateEndpointConnectionProxyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateEndpointConnectionProxyResource.CreateResourceIdentifier" /> to create a <see cref="PrivateEndpointConnectionProxyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnectionProxyResource" /> object. </returns>
        public static PrivateEndpointConnectionProxyResource GetPrivateEndpointConnectionProxyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateEndpointConnectionProxyResource.ValidateResourceId(id);
                return new PrivateEndpointConnectionProxyResource(client, id);
            }
            );
        }
        #endregion
    }
}
