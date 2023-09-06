// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VpnServerConfigurations list associated with VirtualWan Response. </summary>
    public partial class VpnServerConfigurationsResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VpnServerConfigurationsResponse"/>. </summary>
        internal VpnServerConfigurationsResponse()
        {
            VpnServerConfigurationResourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnServerConfigurationsResponse"/>. </summary>
        /// <param name="vpnServerConfigurationResourceIds"> List of VpnServerConfigurations associated with VirtualWan. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnServerConfigurationsResponse(IReadOnlyList<string> vpnServerConfigurationResourceIds, Dictionary<string, BinaryData> rawData)
        {
            VpnServerConfigurationResourceIds = vpnServerConfigurationResourceIds;
            _rawData = rawData;
        }

        /// <summary> List of VpnServerConfigurations associated with VirtualWan. </summary>
        public IReadOnlyList<string> VpnServerConfigurationResourceIds { get; }
    }
}
