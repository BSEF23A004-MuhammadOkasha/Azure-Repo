// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Stop packet capture parameters. </summary>
    public partial class VpnGatewayPacketCaptureStopContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VpnGatewayPacketCaptureStopContent"/>. </summary>
        public VpnGatewayPacketCaptureStopContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnGatewayPacketCaptureStopContent"/>. </summary>
        /// <param name="sasUri"> SAS url for packet capture on vpn gateway. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnGatewayPacketCaptureStopContent(Uri sasUri, Dictionary<string, BinaryData> rawData)
        {
            SasUri = sasUri;
            _rawData = rawData;
        }

        /// <summary> SAS url for packet capture on vpn gateway. </summary>
        public Uri SasUri { get; set; }
    }
}
