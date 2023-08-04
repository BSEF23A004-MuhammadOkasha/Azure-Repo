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
using Azure.ResourceManager.NotificationHubs.Mocking;
using Azure.ResourceManager.NotificationHubs.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NotificationHubs
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.NotificationHubs. </summary>
    public static partial class NotificationHubsExtensions
    {
        private static NotificationHubsArmClientMockingExtension GetNotificationHubsArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new NotificationHubsArmClientMockingExtension(client);
            });
        }

        private static NotificationHubsResourceGroupMockingExtension GetNotificationHubsResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new NotificationHubsResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static NotificationHubsSubscriptionMockingExtension GetNotificationHubsSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new NotificationHubsSubscriptionMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="NotificationHubNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NotificationHubNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="NotificationHubNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NotificationHubNamespaceResource" /> object. </returns>
        public static NotificationHubNamespaceResource GetNotificationHubNamespaceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetNotificationHubsArmClientMockingExtension(client).GetNotificationHubNamespaceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NotificationHubNamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NotificationHubNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="NotificationHubNamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NotificationHubNamespaceAuthorizationRuleResource" /> object. </returns>
        public static NotificationHubNamespaceAuthorizationRuleResource GetNotificationHubNamespaceAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetNotificationHubsArmClientMockingExtension(client).GetNotificationHubNamespaceAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NotificationHubAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NotificationHubAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="NotificationHubAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NotificationHubAuthorizationRuleResource" /> object. </returns>
        public static NotificationHubAuthorizationRuleResource GetNotificationHubAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetNotificationHubsArmClientMockingExtension(client).GetNotificationHubAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NotificationHubResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NotificationHubResource.CreateResourceIdentifier" /> to create a <see cref="NotificationHubResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NotificationHubResource" /> object. </returns>
        public static NotificationHubResource GetNotificationHubResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetNotificationHubsArmClientMockingExtension(client).GetNotificationHubResource(id);
        }

        /// <summary> Gets a collection of NotificationHubNamespaceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of NotificationHubNamespaceResources and their operations over a NotificationHubNamespaceResource. </returns>
        public static NotificationHubNamespaceCollection GetNotificationHubNamespaces(this ResourceGroupResource resourceGroupResource)
        {
            return GetNotificationHubsResourceGroupMockingExtension(resourceGroupResource).GetNotificationHubNamespaces();
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<NotificationHubNamespaceResource>> GetNotificationHubNamespaceAsync(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return await GetNotificationHubsResourceGroupMockingExtension(resourceGroupResource).GetNotificationHubNamespaceAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<NotificationHubNamespaceResource> GetNotificationHubNamespace(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return GetNotificationHubsResourceGroupMockingExtension(resourceGroupResource).GetNotificationHubNamespace(namespaceName, cancellationToken);
        }

        /// <summary>
        /// Checks the availability of the given service namespace across all Azure subscriptions. This is useful because the domain name is created based on the service namespace name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NotificationHubs/checkNamespaceAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<NotificationHubAvailabilityResult>> CheckNotificationHubNamespaceAvailabilityAsync(this SubscriptionResource subscriptionResource, NotificationHubAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetNotificationHubsSubscriptionMockingExtension(subscriptionResource).CheckNotificationHubNamespaceAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks the availability of the given service namespace across all Azure subscriptions. This is useful because the domain name is created based on the service namespace name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NotificationHubs/checkNamespaceAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<NotificationHubAvailabilityResult> CheckNotificationHubNamespaceAvailability(this SubscriptionResource subscriptionResource, NotificationHubAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetNotificationHubsSubscriptionMockingExtension(subscriptionResource).CheckNotificationHubNamespaceAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription irrespective of the resourceGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NotificationHubs/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NotificationHubNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NotificationHubNamespaceResource> GetNotificationHubNamespacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetNotificationHubsSubscriptionMockingExtension(subscriptionResource).GetNotificationHubNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription irrespective of the resourceGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NotificationHubs/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NotificationHubNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NotificationHubNamespaceResource> GetNotificationHubNamespaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetNotificationHubsSubscriptionMockingExtension(subscriptionResource).GetNotificationHubNamespaces(cancellationToken);
        }
    }
}
