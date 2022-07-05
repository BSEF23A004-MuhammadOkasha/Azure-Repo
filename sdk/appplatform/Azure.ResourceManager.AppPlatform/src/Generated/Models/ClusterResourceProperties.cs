// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Service properties payload. </summary>
    public partial class ClusterResourceProperties
    {
        /// <summary> Initializes a new instance of ClusterResourceProperties. </summary>
        public ClusterResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of ClusterResourceProperties. </summary>
        /// <param name="provisioningState"> Provisioning state of the Service. </param>
        /// <param name="networkProfile"> Network profile of the Service. </param>
        /// <param name="version"> Version of the Service. </param>
        /// <param name="serviceId"> ServiceInstanceEntity GUID which uniquely identifies a created resource. </param>
        /// <param name="powerState"> Power state of the Service. </param>
        /// <param name="zoneRedundant"></param>
        /// <param name="fqdn"> Fully qualified dns name of the service instance. </param>
        internal ClusterResourceProperties(ProvisioningState? provisioningState, NetworkProfile networkProfile, int? version, string serviceId, PowerState? powerState, bool? zoneRedundant, string fqdn)
        {
            ProvisioningState = provisioningState;
            NetworkProfile = networkProfile;
            Version = version;
            ServiceId = serviceId;
            PowerState = powerState;
            ZoneRedundant = zoneRedundant;
            Fqdn = fqdn;
        }

        /// <summary> Provisioning state of the Service. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Network profile of the Service. </summary>
        public NetworkProfile NetworkProfile { get; set; }
        /// <summary> Version of the Service. </summary>
        public int? Version { get; }
        /// <summary> ServiceInstanceEntity GUID which uniquely identifies a created resource. </summary>
        public string ServiceId { get; }
        /// <summary> Power state of the Service. </summary>
        public PowerState? PowerState { get; }
        /// <summary> Gets or sets the zone redundant. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> Fully qualified dns name of the service instance. </summary>
        public string Fqdn { get; }
    }
}
