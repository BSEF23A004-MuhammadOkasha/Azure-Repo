// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> BGP settings details for a link. </summary>
    public partial class VpnLinkBgpSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VpnLinkBgpSettings"/>. </summary>
        public VpnLinkBgpSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnLinkBgpSettings"/>. </summary>
        /// <param name="asn"> The BGP speaker's ASN. </param>
        /// <param name="bgpPeeringAddress"> The BGP peering address and BGP identifier of this BGP speaker. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnLinkBgpSettings(long? asn, string bgpPeeringAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Asn = asn;
            BgpPeeringAddress = bgpPeeringAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The BGP speaker's ASN. </summary>
        public long? Asn { get; set; }
        /// <summary> The BGP peering address and BGP identifier of this BGP speaker. </summary>
        public string BgpPeeringAddress { get; set; }
    }
}
