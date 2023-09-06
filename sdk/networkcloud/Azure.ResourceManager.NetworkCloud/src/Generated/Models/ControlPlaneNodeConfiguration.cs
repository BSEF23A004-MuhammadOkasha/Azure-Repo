// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ControlPlaneNodeConfiguration represents the selection of virtual machines and size of the control plane for a Kubernetes cluster. </summary>
    public partial class ControlPlaneNodeConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ControlPlaneNodeConfiguration"/>. </summary>
        /// <param name="count"> The number of virtual machines that use this configuration. </param>
        /// <param name="vmSkuName"> The name of the VM SKU supplied during creation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSkuName"/> is null. </exception>
        public ControlPlaneNodeConfiguration(long count, string vmSkuName)
        {
            Argument.AssertNotNull(vmSkuName, nameof(vmSkuName));

            AvailabilityZones = new ChangeTrackingList<string>();
            Count = count;
            VmSkuName = vmSkuName;
        }

        /// <summary> Initializes a new instance of <see cref="ControlPlaneNodeConfiguration"/>. </summary>
        /// <param name="administratorConfiguration"> The administrator credentials to be used for the nodes in the control plane. </param>
        /// <param name="availabilityZones"> The list of availability zones of the Network Cloud cluster to be used for the provisioning of nodes in the control plane. If not specified, all availability zones will be used. </param>
        /// <param name="count"> The number of virtual machines that use this configuration. </param>
        /// <param name="vmSkuName"> The name of the VM SKU supplied during creation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ControlPlaneNodeConfiguration(AdministratorConfiguration administratorConfiguration, IList<string> availabilityZones, long count, string vmSkuName, Dictionary<string, BinaryData> rawData)
        {
            AdministratorConfiguration = administratorConfiguration;
            AvailabilityZones = availabilityZones;
            Count = count;
            VmSkuName = vmSkuName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ControlPlaneNodeConfiguration"/> for deserialization. </summary>
        internal ControlPlaneNodeConfiguration()
        {
        }

        /// <summary> The administrator credentials to be used for the nodes in the control plane. </summary>
        public AdministratorConfiguration AdministratorConfiguration { get; set; }
        /// <summary> The list of availability zones of the Network Cloud cluster to be used for the provisioning of nodes in the control plane. If not specified, all availability zones will be used. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> The number of virtual machines that use this configuration. </summary>
        public long Count { get; set; }
        /// <summary> The name of the VM SKU supplied during creation. </summary>
        public string VmSkuName { get; set; }
    }
}
