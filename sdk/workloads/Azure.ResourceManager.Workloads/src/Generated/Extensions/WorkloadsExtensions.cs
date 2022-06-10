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
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Workloads. </summary>
    public static partial class WorkloadsExtensions
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
        /// Lists PHP workload resources for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/phpWorkloads
        /// Operation Id: PhpWorkloads_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PhpWorkloadResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PhpWorkloadResource> GetPhpWorkloadResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetPhpWorkloadResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists PHP workload resources for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/phpWorkloads
        /// Operation Id: PhpWorkloads_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PhpWorkloadResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PhpWorkloadResource> GetPhpWorkloadResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetPhpWorkloadResources(cancellationToken);
        }

        /// <summary>
        /// Get SAP sizing recommendations.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getSizingRecommendations
        /// Operation Id: SAPSizingRecommendations
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Sizing Recommendation Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static async Task<Response<SapSizingRecommendationResult>> SapSizingRecommendationsAsync(this SubscriptionResource subscriptionResource, string location, SapSizingRecommendationContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return await GetExtensionClient(subscriptionResource).SapSizingRecommendationsAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get SAP sizing recommendations.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getSizingRecommendations
        /// Operation Id: SAPSizingRecommendations
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Sizing Recommendation Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static Response<SapSizingRecommendationResult> SapSizingRecommendations(this SubscriptionResource subscriptionResource, string location, SapSizingRecommendationContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).SapSizingRecommendations(location, content, cancellationToken);
        }

        /// <summary>
        /// Get SAP supported SKUs.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getSapSupportedSku
        /// Operation Id: SAPSupportedSku
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Supported SKU Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static async Task<Response<SapSupportedResourceSkusResult>> SapSupportedSkuAsync(this SubscriptionResource subscriptionResource, string location, SapSupportedSkusContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return await GetExtensionClient(subscriptionResource).SapSupportedSkuAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get SAP supported SKUs.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getSapSupportedSku
        /// Operation Id: SAPSupportedSku
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Supported SKU Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static Response<SapSupportedResourceSkusResult> SapSupportedSku(this SubscriptionResource subscriptionResource, string location, SapSupportedSkusContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).SapSupportedSku(location, content, cancellationToken);
        }

        /// <summary>
        /// Get SAP Disk Configurations.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getDiskConfigurations
        /// Operation Id: SAPDiskConfigurations
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Disk Configurations Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static async Task<Response<SapDiskConfigurationsResult>> SapDiskConfigurationsAsync(this SubscriptionResource subscriptionResource, string location, SapDiskConfigurationsContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return await GetExtensionClient(subscriptionResource).SapDiskConfigurationsAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get SAP Disk Configurations.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getDiskConfigurations
        /// Operation Id: SAPDiskConfigurations
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Disk Configurations Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static Response<SapDiskConfigurationsResult> SapDiskConfigurations(this SubscriptionResource subscriptionResource, string location, SapDiskConfigurationsContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).SapDiskConfigurations(location, content, cancellationToken);
        }

        /// <summary>
        /// Get SAP Availability Zone Details.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getAvailabilityZoneDetails
        /// Operation Id: SAPAvailabilityZoneDetails
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Availability Zone Details Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static async Task<Response<SapAvailabilityZoneDetailsResult>> SapAvailabilityZoneDetailsAsync(this SubscriptionResource subscriptionResource, string location, SapAvailabilityZoneDetailsContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return await GetExtensionClient(subscriptionResource).SapAvailabilityZoneDetailsAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get SAP Availability Zone Details.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/locations/{location}/sapVirtualInstanceMetadata/default/getAvailabilityZoneDetails
        /// Operation Id: SAPAvailabilityZoneDetails
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> SAP Availability Zone Details Request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static Response<SapAvailabilityZoneDetailsResult> SapAvailabilityZoneDetails(this SubscriptionResource subscriptionResource, string location, SapAvailabilityZoneDetailsContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).SapAvailabilityZoneDetails(location, content, cancellationToken);
        }

        /// <summary>
        /// Gets all Virtual Instances for SAP in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/sapVirtualInstances
        /// Operation Id: SAPVirtualInstances_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapVirtualInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SapVirtualInstanceResource> GetSapVirtualInstancesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSapVirtualInstancesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all Virtual Instances for SAP in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/sapVirtualInstances
        /// Operation Id: SAPVirtualInstances_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapVirtualInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SapVirtualInstanceResource> GetSapVirtualInstances(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSapVirtualInstances(cancellationToken);
        }

        /// <summary>
        /// Gets a list of SAP monitors in the specified subscription. The operations returns various properties of each SAP monitor.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/monitors
        /// Operation Id: monitors_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SapMonitorResource> GetSapMonitorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSapMonitorsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of SAP monitors in the specified subscription. The operations returns various properties of each SAP monitor.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/monitors
        /// Operation Id: monitors_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SapMonitorResource> GetSapMonitors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSapMonitors(cancellationToken);
        }

        /// <summary>
        /// Lists all the available SKUs under this PR
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SkuDefinition> GetSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available SKUs under this PR
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Workloads/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SkuDefinition> GetSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkus(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of PhpWorkloadResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PhpWorkloadResources and their operations over a PhpWorkloadResource. </returns>
        public static PhpWorkloadResourceCollection GetPhpWorkloadResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetPhpWorkloadResources();
        }

        /// <summary>
        /// Gets the PHP workload resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}
        /// Operation Id: PhpWorkloads_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="phpWorkloadName"> Php workload name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="phpWorkloadName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="phpWorkloadName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PhpWorkloadResource>> GetPhpWorkloadResourceAsync(this ResourceGroupResource resourceGroupResource, string phpWorkloadName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetPhpWorkloadResources().GetAsync(phpWorkloadName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the PHP workload resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}
        /// Operation Id: PhpWorkloads_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="phpWorkloadName"> Php workload name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="phpWorkloadName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="phpWorkloadName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PhpWorkloadResource> GetPhpWorkloadResource(this ResourceGroupResource resourceGroupResource, string phpWorkloadName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetPhpWorkloadResources().Get(phpWorkloadName, cancellationToken);
        }

        /// <summary> Gets a collection of SapVirtualInstanceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SapVirtualInstanceResources and their operations over a SapVirtualInstanceResource. </returns>
        public static SapVirtualInstanceCollection GetSapVirtualInstances(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSapVirtualInstances();
        }

        /// <summary>
        /// Gets an Virtual Instance for SAP.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}
        /// Operation Id: SAPVirtualInstances_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapVirtualInstanceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SapVirtualInstanceResource>> GetSapVirtualInstanceAsync(this ResourceGroupResource resourceGroupResource, string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSapVirtualInstances().GetAsync(sapVirtualInstanceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an Virtual Instance for SAP.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}
        /// Operation Id: SAPVirtualInstances_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapVirtualInstanceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SapVirtualInstanceResource> GetSapVirtualInstance(this ResourceGroupResource resourceGroupResource, string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSapVirtualInstances().Get(sapVirtualInstanceName, cancellationToken);
        }

        /// <summary> Gets a collection of SapMonitorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SapMonitorResources and their operations over a SapMonitorResource. </returns>
        public static SapMonitorCollection GetSapMonitors(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSapMonitors();
        }

        /// <summary>
        /// Gets properties of a SAP monitor for the specified subscription, resource group, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}
        /// Operation Id: monitors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Name of the SAP monitor resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SapMonitorResource>> GetSapMonitorAsync(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSapMonitors().GetAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets properties of a SAP monitor for the specified subscription, resource group, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}
        /// Operation Id: monitors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Name of the SAP monitor resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SapMonitorResource> GetSapMonitor(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSapMonitors().Get(monitorName, cancellationToken);
        }

        #region PhpWorkloadResource
        /// <summary>
        /// Gets an object representing a <see cref="PhpWorkloadResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PhpWorkloadResource.CreateResourceIdentifier" /> to create a <see cref="PhpWorkloadResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PhpWorkloadResource" /> object. </returns>
        public static PhpWorkloadResource GetPhpWorkloadResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PhpWorkloadResource.ValidateResourceId(id);
                return new PhpWorkloadResource(client, id);
            }
            );
        }
        #endregion

        #region WordPressInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="WordPressInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WordPressInstanceResource.CreateResourceIdentifier" /> to create a <see cref="WordPressInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WordPressInstanceResource" /> object. </returns>
        public static WordPressInstanceResource GetWordPressInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WordPressInstanceResource.ValidateResourceId(id);
                return new WordPressInstanceResource(client, id);
            }
            );
        }
        #endregion

        #region SapVirtualInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="SapVirtualInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapVirtualInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapVirtualInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapVirtualInstanceResource" /> object. </returns>
        public static SapVirtualInstanceResource GetSapVirtualInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SapVirtualInstanceResource.ValidateResourceId(id);
                return new SapVirtualInstanceResource(client, id);
            }
            );
        }
        #endregion

        #region SapCentralServerInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="SapCentralServerInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapCentralServerInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapCentralServerInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapCentralServerInstanceResource" /> object. </returns>
        public static SapCentralServerInstanceResource GetSapCentralServerInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SapCentralServerInstanceResource.ValidateResourceId(id);
                return new SapCentralServerInstanceResource(client, id);
            }
            );
        }
        #endregion

        #region SapDatabaseInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="SapDatabaseInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapDatabaseInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapDatabaseInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapDatabaseInstanceResource" /> object. </returns>
        public static SapDatabaseInstanceResource GetSapDatabaseInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SapDatabaseInstanceResource.ValidateResourceId(id);
                return new SapDatabaseInstanceResource(client, id);
            }
            );
        }
        #endregion

        #region SapApplicationServerInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="SapApplicationServerInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapApplicationServerInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapApplicationServerInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapApplicationServerInstanceResource" /> object. </returns>
        public static SapApplicationServerInstanceResource GetSapApplicationServerInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SapApplicationServerInstanceResource.ValidateResourceId(id);
                return new SapApplicationServerInstanceResource(client, id);
            }
            );
        }
        #endregion

        #region SapMonitorResource
        /// <summary>
        /// Gets an object representing a <see cref="SapMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapMonitorResource.CreateResourceIdentifier" /> to create a <see cref="SapMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapMonitorResource" /> object. </returns>
        public static SapMonitorResource GetSapMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SapMonitorResource.ValidateResourceId(id);
                return new SapMonitorResource(client, id);
            }
            );
        }
        #endregion

        #region SapProviderInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="SapProviderInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapProviderInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapProviderInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapProviderInstanceResource" /> object. </returns>
        public static SapProviderInstanceResource GetSapProviderInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SapProviderInstanceResource.ValidateResourceId(id);
                return new SapProviderInstanceResource(client, id);
            }
            );
        }
        #endregion
    }
}
