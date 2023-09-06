// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Public IP Address associated with azure firewall. </summary>
    public partial class AzureFirewallPublicIPAddress
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureFirewallPublicIPAddress"/>. </summary>
        public AzureFirewallPublicIPAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureFirewallPublicIPAddress"/>. </summary>
        /// <param name="address"> Public IP Address value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureFirewallPublicIPAddress(string address, Dictionary<string, BinaryData> rawData)
        {
            Address = address;
            _rawData = rawData;
        }

        /// <summary> Public IP Address value. </summary>
        public string Address { get; set; }
    }
}
