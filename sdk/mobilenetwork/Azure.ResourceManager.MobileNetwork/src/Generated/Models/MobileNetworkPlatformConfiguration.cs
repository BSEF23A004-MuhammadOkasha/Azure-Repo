// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The platform where the packet core is deployed. </summary>
    public partial class MobileNetworkPlatformConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkPlatformConfiguration"/>. </summary>
        /// <param name="platformType"> The platform type where packet core is deployed. </param>
        public MobileNetworkPlatformConfiguration(MobileNetworkPlatformType platformType)
        {
            PlatformType = platformType;
            AzureStackEdgeDevices = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkPlatformConfiguration"/>. </summary>
        /// <param name="platformType"> The platform type where packet core is deployed. </param>
        /// <param name="azureStackEdgeDevice"> The Azure Stack Edge device where the packet core is deployed. If the device is part of a fault tolerant pair, either device in the pair can be specified. </param>
        /// <param name="azureStackEdgeDevices"> The Azure Stack Edge devices where the packet core is deployed. If the packet core is deployed across multiple devices, all devices will appear in this list. </param>
        /// <param name="azureStackHciCluster"> The Azure Stack HCI cluster where the packet core is deployed. </param>
        /// <param name="connectedCluster"> Azure Arc connected cluster where the packet core is deployed. </param>
        /// <param name="customLocation"> Azure Arc custom location where the packet core is deployed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkPlatformConfiguration(MobileNetworkPlatformType platformType, WritableSubResource azureStackEdgeDevice, IReadOnlyList<WritableSubResource> azureStackEdgeDevices, WritableSubResource azureStackHciCluster, WritableSubResource connectedCluster, WritableSubResource customLocation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PlatformType = platformType;
            AzureStackEdgeDevice = azureStackEdgeDevice;
            AzureStackEdgeDevices = azureStackEdgeDevices;
            AzureStackHciCluster = azureStackHciCluster;
            ConnectedCluster = connectedCluster;
            CustomLocation = customLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkPlatformConfiguration"/> for deserialization. </summary>
        internal MobileNetworkPlatformConfiguration()
        {
        }

        /// <summary> The platform type where packet core is deployed. </summary>
        public MobileNetworkPlatformType PlatformType { get; set; }
        /// <summary> The Azure Stack Edge device where the packet core is deployed. If the device is part of a fault tolerant pair, either device in the pair can be specified. </summary>
        internal WritableSubResource AzureStackEdgeDevice { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AzureStackEdgeDeviceId
        {
            get => AzureStackEdgeDevice is null ? default : AzureStackEdgeDevice.Id;
            set
            {
                if (AzureStackEdgeDevice is null)
                    AzureStackEdgeDevice = new WritableSubResource();
                AzureStackEdgeDevice.Id = value;
            }
        }

        /// <summary> The Azure Stack Edge devices where the packet core is deployed. If the packet core is deployed across multiple devices, all devices will appear in this list. </summary>
        public IReadOnlyList<WritableSubResource> AzureStackEdgeDevices { get; }
        /// <summary> The Azure Stack HCI cluster where the packet core is deployed. </summary>
        internal WritableSubResource AzureStackHciCluster { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AzureStackHciClusterId
        {
            get => AzureStackHciCluster is null ? default : AzureStackHciCluster.Id;
            set
            {
                if (AzureStackHciCluster is null)
                    AzureStackHciCluster = new WritableSubResource();
                AzureStackHciCluster.Id = value;
            }
        }

        /// <summary> Azure Arc connected cluster where the packet core is deployed. </summary>
        internal WritableSubResource ConnectedCluster { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ConnectedClusterId
        {
            get => ConnectedCluster is null ? default : ConnectedCluster.Id;
            set
            {
                if (ConnectedCluster is null)
                    ConnectedCluster = new WritableSubResource();
                ConnectedCluster.Id = value;
            }
        }

        /// <summary> Azure Arc custom location where the packet core is deployed. </summary>
        internal WritableSubResource CustomLocation { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier CustomLocationId
        {
            get => CustomLocation is null ? default : CustomLocation.Id;
            set
            {
                if (CustomLocation is null)
                    CustomLocation = new WritableSubResource();
                CustomLocation.Id = value;
            }
        }
    }
}
