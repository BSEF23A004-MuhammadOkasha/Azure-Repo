// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> An A record. </summary>
    public partial class PrivateDnsARecordInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateDnsARecordInfo"/>. </summary>
        public PrivateDnsARecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsARecordInfo"/>. </summary>
        /// <param name="ipv4Address"> The IPv4 address of this A record. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsARecordInfo(IPAddress ipv4Address, Dictionary<string, BinaryData> rawData)
        {
            IPv4Address = ipv4Address;
            _rawData = rawData;
        }

        /// <summary> The IPv4 address of this A record. </summary>
        public IPAddress IPv4Address { get; set; }
    }
}
