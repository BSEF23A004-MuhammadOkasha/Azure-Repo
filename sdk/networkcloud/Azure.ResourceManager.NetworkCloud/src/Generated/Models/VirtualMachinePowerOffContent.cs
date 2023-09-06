// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VirtualMachinePowerOffParameters represents the body of the request to power off virtual machine. </summary>
    public partial class VirtualMachinePowerOffContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePowerOffContent"/>. </summary>
        public VirtualMachinePowerOffContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePowerOffContent"/>. </summary>
        /// <param name="skipShutdown"> The indicator of whether to skip the graceful OS shutdown and power off the virtual machine immediately. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachinePowerOffContent(SkipShutdown? skipShutdown, Dictionary<string, BinaryData> rawData)
        {
            SkipShutdown = skipShutdown;
            _rawData = rawData;
        }

        /// <summary> The indicator of whether to skip the graceful OS shutdown and power off the virtual machine immediately. </summary>
        public SkipShutdown? SkipShutdown { get; set; }
    }
}
