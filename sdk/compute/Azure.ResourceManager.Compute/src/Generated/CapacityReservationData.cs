// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the CapacityReservation data model.
    /// Specifies information about the capacity reservation.
    /// </summary>
    public partial class CapacityReservationData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CapacityReservationData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called 'CapacityReservationSupported' set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public CapacityReservationData(AzureLocation location, ComputeSku sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
            Zones = new ChangeTrackingList<string>();
            VirtualMachinesAssociated = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called 'CapacityReservationSupported' set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </param>
        /// <param name="zones"> Availability Zone to use for this capacity reservation. The zone has to be single value and also should be part for the list of zones specified during the capacity reservation group creation. The zone can be assigned only during creation. If not provided, the reservation supports only non-zonal deployments. If provided, enforces VM/VMSS using this capacity reservation to be in same zone. </param>
        /// <param name="reservationId"> A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource. </param>
        /// <param name="platformFaultDomainCount"> Specifies the value of fault domain count that Capacity Reservation supports for requested VM size. **Note:** The fault domain count specified for a resource (like virtual machines scale set) must be less than or equal to this value if it deploys using capacity reservation. Minimum api-version: 2022-08-01. </param>
        /// <param name="virtualMachinesAssociated"> A list of all virtual machine resource ids that are associated with the capacity reservation. </param>
        /// <param name="provisioningOn"> The date time when the capacity reservation was last updated. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The Capacity reservation instance view. </param>
        /// <param name="timeCreated"> Specifies the time at which the Capacity Reservation resource was created. Minimum api-version: 2021-11-01. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CapacityReservationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ComputeSku sku, IList<string> zones, string reservationId, int? platformFaultDomainCount, IReadOnlyList<SubResource> virtualMachinesAssociated, DateTimeOffset? provisioningOn, string provisioningState, CapacityReservationInstanceView instanceView, DateTimeOffset? timeCreated, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Zones = zones;
            ReservationId = reservationId;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            ProvisioningOn = provisioningOn;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            TimeCreated = timeCreated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationData"/> for deserialization. </summary>
        internal CapacityReservationData()
        {
        }

        /// <summary> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called 'CapacityReservationSupported' set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </summary>
        public ComputeSku Sku { get; set; }
        /// <summary> Availability Zone to use for this capacity reservation. The zone has to be single value and also should be part for the list of zones specified during the capacity reservation group creation. The zone can be assigned only during creation. If not provided, the reservation supports only non-zonal deployments. If provided, enforces VM/VMSS using this capacity reservation to be in same zone. </summary>
        public IList<string> Zones { get; }
        /// <summary> A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource. </summary>
        public string ReservationId { get; }
        /// <summary> Specifies the value of fault domain count that Capacity Reservation supports for requested VM size. **Note:** The fault domain count specified for a resource (like virtual machines scale set) must be less than or equal to this value if it deploys using capacity reservation. Minimum api-version: 2022-08-01. </summary>
        public int? PlatformFaultDomainCount { get; }
        /// <summary> A list of all virtual machine resource ids that are associated with the capacity reservation. </summary>
        public IReadOnlyList<SubResource> VirtualMachinesAssociated { get; }
        /// <summary> The date time when the capacity reservation was last updated. </summary>
        public DateTimeOffset? ProvisioningOn { get; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The Capacity reservation instance view. </summary>
        public CapacityReservationInstanceView InstanceView { get; }
        /// <summary> Specifies the time at which the Capacity Reservation resource was created. Minimum api-version: 2021-11-01. </summary>
        public DateTimeOffset? TimeCreated { get; }
    }
}
