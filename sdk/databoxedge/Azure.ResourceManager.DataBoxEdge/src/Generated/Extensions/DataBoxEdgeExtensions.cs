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
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataBoxEdge. </summary>
    public static partial class DataBoxEdgeExtensions
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
        /// List all the available Skus and information related to them.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/availableSkus
        /// Operation Id: AvailableSkus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableDataBoxEdgeSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AvailableDataBoxEdgeSku> GetAvailableSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAvailableSkusAsync(cancellationToken);
        }

        /// <summary>
        /// List all the available Skus and information related to them.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/availableSkus
        /// Operation Id: AvailableSkus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableDataBoxEdgeSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AvailableDataBoxEdgeSku> GetAvailableSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAvailableSkus(cancellationToken);
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices
        /// Operation Id: Devices_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeDeviceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevicesAsync(this SubscriptionResource subscriptionResource, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataBoxEdgeDevicesAsync(expand, cancellationToken);
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices
        /// Operation Id: Devices_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeDeviceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevices(this SubscriptionResource subscriptionResource, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataBoxEdgeDevices(expand, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DataBoxEdgeDeviceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataBoxEdgeDeviceResources and their operations over a DataBoxEdgeDeviceResource. </returns>
        public static DataBoxEdgeDeviceCollection GetDataBoxEdgeDevices(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDataBoxEdgeDevices();
        }

        /// <summary>
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}
        /// Operation Id: Devices_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataBoxEdgeDeviceResource>> GetDataBoxEdgeDeviceAsync(this ResourceGroupResource resourceGroupResource, string deviceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDataBoxEdgeDevices().GetAsync(deviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}
        /// Operation Id: Devices_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevice(this ResourceGroupResource resourceGroupResource, string deviceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDataBoxEdgeDevices().Get(deviceName, cancellationToken);
        }

        #region DataBoxEdgeDeviceResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeDeviceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeDeviceResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeDeviceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeDeviceResource" /> object. </returns>
        public static DataBoxEdgeDeviceResource GetDataBoxEdgeDeviceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeDeviceResource.ValidateResourceId(id);
                return new DataBoxEdgeDeviceResource(client, id);
            }
            );
        }
        #endregion

        #region NetworkSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="NetworkSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkSettingResource.CreateResourceIdentifier" /> to create a <see cref="NetworkSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkSettingResource" /> object. </returns>
        public static NetworkSettingResource GetNetworkSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetworkSettingResource.ValidateResourceId(id);
                return new NetworkSettingResource(client, id);
            }
            );
        }
        #endregion

        #region UpdateSummaryResource
        /// <summary>
        /// Gets an object representing an <see cref="UpdateSummaryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UpdateSummaryResource.CreateResourceIdentifier" /> to create an <see cref="UpdateSummaryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UpdateSummaryResource" /> object. </returns>
        public static UpdateSummaryResource GetUpdateSummaryResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                UpdateSummaryResource.ValidateResourceId(id);
                return new UpdateSummaryResource(client, id);
            }
            );
        }
        #endregion

        #region AlertResource
        /// <summary>
        /// Gets an object representing an <see cref="AlertResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AlertResource.CreateResourceIdentifier" /> to create an <see cref="AlertResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AlertResource" /> object. </returns>
        public static AlertResource GetAlertResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AlertResource.ValidateResourceId(id);
                return new AlertResource(client, id);
            }
            );
        }
        #endregion

        #region BandwidthScheduleResource
        /// <summary>
        /// Gets an object representing a <see cref="BandwidthScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BandwidthScheduleResource.CreateResourceIdentifier" /> to create a <see cref="BandwidthScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BandwidthScheduleResource" /> object. </returns>
        public static BandwidthScheduleResource GetBandwidthScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BandwidthScheduleResource.ValidateResourceId(id);
                return new BandwidthScheduleResource(client, id);
            }
            );
        }
        #endregion

        #region DeviceCapacityInfoResource
        /// <summary>
        /// Gets an object representing a <see cref="DeviceCapacityInfoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceCapacityInfoResource.CreateResourceIdentifier" /> to create a <see cref="DeviceCapacityInfoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceCapacityInfoResource" /> object. </returns>
        public static DeviceCapacityInfoResource GetDeviceCapacityInfoResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeviceCapacityInfoResource.ValidateResourceId(id);
                return new DeviceCapacityInfoResource(client, id);
            }
            );
        }
        #endregion

        #region DiagnosticProactiveLogCollectionSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="DiagnosticProactiveLogCollectionSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiagnosticProactiveLogCollectionSettingResource.CreateResourceIdentifier" /> to create a <see cref="DiagnosticProactiveLogCollectionSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticProactiveLogCollectionSettingResource" /> object. </returns>
        public static DiagnosticProactiveLogCollectionSettingResource GetDiagnosticProactiveLogCollectionSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DiagnosticProactiveLogCollectionSettingResource.ValidateResourceId(id);
                return new DiagnosticProactiveLogCollectionSettingResource(client, id);
            }
            );
        }
        #endregion

        #region DiagnosticRemoteSupportSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="DiagnosticRemoteSupportSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiagnosticRemoteSupportSettingResource.CreateResourceIdentifier" /> to create a <see cref="DiagnosticRemoteSupportSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticRemoteSupportSettingResource" /> object. </returns>
        public static DiagnosticRemoteSupportSettingResource GetDiagnosticRemoteSupportSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DiagnosticRemoteSupportSettingResource.ValidateResourceId(id);
                return new DiagnosticRemoteSupportSettingResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeDeviceJobResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeDeviceJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeDeviceJobResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeDeviceJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeDeviceJobResource" /> object. </returns>
        public static DataBoxEdgeDeviceJobResource GetDataBoxEdgeDeviceJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeDeviceJobResource.ValidateResourceId(id);
                return new DataBoxEdgeDeviceJobResource(client, id);
            }
            );
        }
        #endregion

        #region DataBoxEdgeDeviceJobStatusResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxEdgeDeviceJobStatusResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxEdgeDeviceJobStatusResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxEdgeDeviceJobStatusResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxEdgeDeviceJobStatusResource" /> object. </returns>
        public static DataBoxEdgeDeviceJobStatusResource GetDataBoxEdgeDeviceJobStatusResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxEdgeDeviceJobStatusResource.ValidateResourceId(id);
                return new DataBoxEdgeDeviceJobStatusResource(client, id);
            }
            );
        }
        #endregion

        #region OrderResource
        /// <summary>
        /// Gets an object representing an <see cref="OrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrderResource.CreateResourceIdentifier" /> to create an <see cref="OrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderResource" /> object. </returns>
        public static OrderResource GetOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OrderResource.ValidateResourceId(id);
                return new OrderResource(client, id);
            }
            );
        }
        #endregion

        #region RoleResource
        /// <summary>
        /// Gets an object representing a <see cref="RoleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RoleResource.CreateResourceIdentifier" /> to create a <see cref="RoleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RoleResource" /> object. </returns>
        public static RoleResource GetRoleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RoleResource.ValidateResourceId(id);
                return new RoleResource(client, id);
            }
            );
        }
        #endregion

        #region AddonResource
        /// <summary>
        /// Gets an object representing an <see cref="AddonResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AddonResource.CreateResourceIdentifier" /> to create an <see cref="AddonResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AddonResource" /> object. </returns>
        public static AddonResource GetAddonResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AddonResource.ValidateResourceId(id);
                return new AddonResource(client, id);
            }
            );
        }
        #endregion

        #region MonitoringMetricConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="MonitoringMetricConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MonitoringMetricConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MonitoringMetricConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MonitoringMetricConfigurationResource" /> object. </returns>
        public static MonitoringMetricConfigurationResource GetMonitoringMetricConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MonitoringMetricConfigurationResource.ValidateResourceId(id);
                return new MonitoringMetricConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region ShareResource
        /// <summary>
        /// Gets an object representing a <see cref="ShareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ShareResource.CreateResourceIdentifier" /> to create a <see cref="ShareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ShareResource" /> object. </returns>
        public static ShareResource GetShareResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ShareResource.ValidateResourceId(id);
                return new ShareResource(client, id);
            }
            );
        }
        #endregion

        #region StorageAccountCredentialResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountCredentialResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountCredentialResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountCredentialResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountCredentialResource" /> object. </returns>
        public static StorageAccountCredentialResource GetStorageAccountCredentialResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageAccountCredentialResource.ValidateResourceId(id);
                return new StorageAccountCredentialResource(client, id);
            }
            );
        }
        #endregion

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
            return client.GetResourceClient(() =>
            {
                StorageAccountResource.ValidateResourceId(id);
                return new StorageAccountResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerResource.CreateResourceIdentifier" /> to create a <see cref="ContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerResource" /> object. </returns>
        public static ContainerResource GetContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerResource.ValidateResourceId(id);
                return new ContainerResource(client, id);
            }
            );
        }
        #endregion

        #region TriggerResource
        /// <summary>
        /// Gets an object representing a <see cref="TriggerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TriggerResource.CreateResourceIdentifier" /> to create a <see cref="TriggerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TriggerResource" /> object. </returns>
        public static TriggerResource GetTriggerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TriggerResource.ValidateResourceId(id);
                return new TriggerResource(client, id);
            }
            );
        }
        #endregion

        #region UserResource
        /// <summary>
        /// Gets an object representing an <see cref="UserResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UserResource.CreateResourceIdentifier" /> to create an <see cref="UserResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UserResource" /> object. </returns>
        public static UserResource GetUserResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                UserResource.ValidateResourceId(id);
                return new UserResource(client, id);
            }
            );
        }
        #endregion
    }
}
