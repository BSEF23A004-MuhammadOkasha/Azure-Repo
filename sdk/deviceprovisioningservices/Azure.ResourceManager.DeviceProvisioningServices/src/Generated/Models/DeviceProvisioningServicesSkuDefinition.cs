// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Available SKUs of tier and units. </summary>
    public partial class DeviceProvisioningServicesSkuDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesSkuDefinition"/>. </summary>
        internal DeviceProvisioningServicesSkuDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesSkuDefinition"/>. </summary>
        /// <param name="name"> Sku name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceProvisioningServicesSkuDefinition(DeviceProvisioningServicesSku? name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Sku name. </summary>
        public DeviceProvisioningServicesSku? Name { get; }
    }
}
