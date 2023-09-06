// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileAttachedDataNetwork data model.
    /// Attached data network resource. Must be created in the same location as its parent packet core data plane.
    /// </summary>
    public partial class MobileAttachedDataNetworkData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MobileAttachedDataNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="userPlaneDataInterface"> The user plane interface on the data network. For 5G networks, this is the N6 interface. For 4G networks, this is the SGi interface. </param>
        /// <param name="dnsAddresses"> The DNS servers to signal to UEs to use for this attached data network. This configuration is mandatory - if you don't want DNS servers, you must provide an empty array. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userPlaneDataInterface"/> or <paramref name="dnsAddresses"/> is null. </exception>
        public MobileAttachedDataNetworkData(AzureLocation location, MobileNetworkInterfaceProperties userPlaneDataInterface, IEnumerable<string> dnsAddresses) : base(location)
        {
            Argument.AssertNotNull(userPlaneDataInterface, nameof(userPlaneDataInterface));
            Argument.AssertNotNull(dnsAddresses, nameof(dnsAddresses));

            UserPlaneDataInterface = userPlaneDataInterface;
            DnsAddresses = dnsAddresses.ToList();
            UserEquipmentAddressPoolPrefix = new ChangeTrackingList<string>();
            UserEquipmentStaticAddressPoolPrefix = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MobileAttachedDataNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the attached data network resource. </param>
        /// <param name="userPlaneDataInterface"> The user plane interface on the data network. For 5G networks, this is the N6 interface. For 4G networks, this is the SGi interface. </param>
        /// <param name="dnsAddresses"> The DNS servers to signal to UEs to use for this attached data network. This configuration is mandatory - if you don't want DNS servers, you must provide an empty array. </param>
        /// <param name="naptConfiguration">
        /// The network address and port translation (NAPT) configuration.
        /// If this is not specified, the attached data network will use a default NAPT configuration with NAPT enabled.
        /// </param>
        /// <param name="userEquipmentAddressPoolPrefix">
        /// The user equipment (UE) address pool prefixes for the attached data network from which the packet core instance will dynamically assign IP addresses to UEs.
        /// The packet core instance assigns an IP address to a UE when the UE sets up a PDU session.
        ///  You must define at least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix. If you define both, they must be of the same size.
        /// </param>
        /// <param name="userEquipmentStaticAddressPoolPrefix">
        /// The user equipment (UE) address pool prefixes for the attached data network from which the packet core instance will assign static IP addresses to UEs.
        /// The packet core instance assigns an IP address to a UE when the UE sets up a PDU session. The static IP address for a specific UE is set in StaticIPConfiguration on the corresponding SIM resource.
        /// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined, they must be of the same size.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileAttachedDataNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkProvisioningState? provisioningState, MobileNetworkInterfaceProperties userPlaneDataInterface, IList<string> dnsAddresses, NaptConfiguration naptConfiguration, IList<string> userEquipmentAddressPoolPrefix, IList<string> userEquipmentStaticAddressPoolPrefix, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            UserPlaneDataInterface = userPlaneDataInterface;
            DnsAddresses = dnsAddresses;
            NaptConfiguration = naptConfiguration;
            UserEquipmentAddressPoolPrefix = userEquipmentAddressPoolPrefix;
            UserEquipmentStaticAddressPoolPrefix = userEquipmentStaticAddressPoolPrefix;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileAttachedDataNetworkData"/> for deserialization. </summary>
        internal MobileAttachedDataNetworkData()
        {
        }

        /// <summary> The provisioning state of the attached data network resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The user plane interface on the data network. For 5G networks, this is the N6 interface. For 4G networks, this is the SGi interface. </summary>
        public MobileNetworkInterfaceProperties UserPlaneDataInterface { get; set; }
        /// <summary> The DNS servers to signal to UEs to use for this attached data network. This configuration is mandatory - if you don't want DNS servers, you must provide an empty array. </summary>
        public IList<string> DnsAddresses { get; }
        /// <summary>
        /// The network address and port translation (NAPT) configuration.
        /// If this is not specified, the attached data network will use a default NAPT configuration with NAPT enabled.
        /// </summary>
        public NaptConfiguration NaptConfiguration { get; set; }
        /// <summary>
        /// The user equipment (UE) address pool prefixes for the attached data network from which the packet core instance will dynamically assign IP addresses to UEs.
        /// The packet core instance assigns an IP address to a UE when the UE sets up a PDU session.
        ///  You must define at least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix. If you define both, they must be of the same size.
        /// </summary>
        public IList<string> UserEquipmentAddressPoolPrefix { get; }
        /// <summary>
        /// The user equipment (UE) address pool prefixes for the attached data network from which the packet core instance will assign static IP addresses to UEs.
        /// The packet core instance assigns an IP address to a UE when the UE sets up a PDU session. The static IP address for a specific UE is set in StaticIPConfiguration on the corresponding SIM resource.
        /// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined, they must be of the same size.
        /// </summary>
        public IList<string> UserEquipmentStaticAddressPoolPrefix { get; }
    }
}
