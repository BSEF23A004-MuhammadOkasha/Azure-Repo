// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Input values for operation results call. </summary>
    public partial class DeviceProvisioningServicesNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the Provisioning Service to check. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DeviceProvisioningServicesNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the Provisioning Service to check. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceProvisioningServicesNameAvailabilityContent(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesNameAvailabilityContent"/> for deserialization. </summary>
        internal DeviceProvisioningServicesNameAvailabilityContent()
        {
        }

        /// <summary> The name of the Provisioning Service to check. </summary>
        public string Name { get; }
    }
}
