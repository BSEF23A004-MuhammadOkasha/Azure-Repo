// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> An NS record. </summary>
    public partial class DnsNSRecordInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DnsNSRecordInfo"/>. </summary>
        public DnsNSRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DnsNSRecordInfo"/>. </summary>
        /// <param name="dnsNSDomainName"> The name server name for this NS record. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsNSRecordInfo(string dnsNSDomainName, Dictionary<string, BinaryData> rawData)
        {
            DnsNSDomainName = dnsNSDomainName;
            _rawData = rawData;
        }

        /// <summary> The name server name for this NS record. </summary>
        public string DnsNSDomainName { get; set; }
    }
}
