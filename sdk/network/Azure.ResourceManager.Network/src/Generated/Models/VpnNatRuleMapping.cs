// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn NatRule mapping. </summary>
    public partial class VpnNatRuleMapping
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VpnNatRuleMapping"/>. </summary>
        public VpnNatRuleMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnNatRuleMapping"/>. </summary>
        /// <param name="addressSpace"> Address space for Vpn NatRule mapping. </param>
        /// <param name="portRange"> Port range for Vpn NatRule mapping. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnNatRuleMapping(string addressSpace, string portRange, Dictionary<string, BinaryData> rawData)
        {
            AddressSpace = addressSpace;
            PortRange = portRange;
            _rawData = rawData;
        }

        /// <summary> Address space for Vpn NatRule mapping. </summary>
        public string AddressSpace { get; set; }
        /// <summary> Port range for Vpn NatRule mapping. </summary>
        public string PortRange { get; set; }
    }
}
