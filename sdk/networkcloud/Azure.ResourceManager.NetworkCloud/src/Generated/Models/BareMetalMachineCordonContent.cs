// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineCordonParameters represents the body of the request to evacuate workloads from node on a bare metal machine. </summary>
    public partial class BareMetalMachineCordonContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineCordonContent"/>. </summary>
        public BareMetalMachineCordonContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineCordonContent"/>. </summary>
        /// <param name="evacuate"> The indicator of whether to evacuate the node workload when the bare metal machine is cordoned. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BareMetalMachineCordonContent(BareMetalMachineEvacuate? evacuate, Dictionary<string, BinaryData> rawData)
        {
            Evacuate = evacuate;
            _rawData = rawData;
        }

        /// <summary> The indicator of whether to evacuate the node workload when the bare metal machine is cordoned. </summary>
        public BareMetalMachineEvacuate? Evacuate { get; set; }
    }
}
