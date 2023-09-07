// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudRackSku data model.
    /// RackSku represents the SKU information of the rack.
    /// </summary>
    public partial class NetworkCloudRackSkuData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkCloudRackSkuData. </summary>
        public NetworkCloudRackSkuData()
        {
            ComputeMachines = new ChangeTrackingList<MachineSkuSlot>();
            ControllerMachines = new ChangeTrackingList<MachineSkuSlot>();
            StorageAppliances = new ChangeTrackingList<StorageApplianceSkuSlot>();
            SupportedRackSkuIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkCloudRackSkuData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="computeMachines"> The list of machine SKUs and associated rack slot for the compute-dedicated machines in this rack model. </param>
        /// <param name="controllerMachines"> The list of machine SKUs and associated rack slot for the control-plane dedicated machines in this rack model. </param>
        /// <param name="description"> The free-form text describing the rack. </param>
        /// <param name="maxClusterSlots"> The maximum number of compute racks supported by an aggregator rack. 0 if this is a compute rack or a rack for a single rack cluster(rackType="Single"). </param>
        /// <param name="provisioningState"> The provisioning state of the rack SKU resource. </param>
        /// <param name="rackType"> The type of the rack. </param>
        /// <param name="storageAppliances"> The list of appliance SKUs and associated rack slot for the storage appliance(s) in this rack model. </param>
        /// <param name="supportedRackSkuIds"> The list of supported SKUs if the rack is an aggregator. </param>
        internal NetworkCloudRackSkuData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<MachineSkuSlot> computeMachines, IReadOnlyList<MachineSkuSlot> controllerMachines, string description, long? maxClusterSlots, RackSkuProvisioningState? provisioningState, RackSkuType? rackType, IReadOnlyList<StorageApplianceSkuSlot> storageAppliances, IReadOnlyList<string> supportedRackSkuIds) : base(id, name, resourceType, systemData)
        {
            ComputeMachines = computeMachines;
            ControllerMachines = controllerMachines;
            Description = description;
            MaxClusterSlots = maxClusterSlots;
            ProvisioningState = provisioningState;
            RackType = rackType;
            StorageAppliances = storageAppliances;
            SupportedRackSkuIds = supportedRackSkuIds;
        }

        /// <summary> The list of machine SKUs and associated rack slot for the compute-dedicated machines in this rack model. </summary>
        public IReadOnlyList<MachineSkuSlot> ComputeMachines { get; }
        /// <summary> The list of machine SKUs and associated rack slot for the control-plane dedicated machines in this rack model. </summary>
        public IReadOnlyList<MachineSkuSlot> ControllerMachines { get; }
        /// <summary> The free-form text describing the rack. </summary>
        public string Description { get; }
        /// <summary> The maximum number of compute racks supported by an aggregator rack. 0 if this is a compute rack or a rack for a single rack cluster(rackType="Single"). </summary>
        public long? MaxClusterSlots { get; }
        /// <summary> The provisioning state of the rack SKU resource. </summary>
        public RackSkuProvisioningState? ProvisioningState { get; }
        /// <summary> The type of the rack. </summary>
        public RackSkuType? RackType { get; }
        /// <summary> The list of appliance SKUs and associated rack slot for the storage appliance(s) in this rack model. </summary>
        public IReadOnlyList<StorageApplianceSkuSlot> StorageAppliances { get; }
        /// <summary> The list of supported SKUs if the rack is an aggregator. </summary>
        public IReadOnlyList<string> SupportedRackSkuIds { get; }
    }
}
