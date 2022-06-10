// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> A class that represents a VerificationStatus record. </summary>
    public partial class DnsRecord
    {
        /// <summary> Initializes a new instance of DnsRecord. </summary>
        internal DnsRecord()
        {
        }

        /// <summary> Initializes a new instance of DnsRecord. </summary>
        /// <param name="dnsRecordType"> Type of the DNS record. Example: TXT. </param>
        /// <param name="name"> Name of the DNS record. </param>
        /// <param name="value"> Value of the DNS record. </param>
        /// <param name="ttl"> Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default = 3600sec. </param>
        internal DnsRecord(string dnsRecordType, string name, string value, int? ttl)
        {
            DnsRecordType = dnsRecordType;
            Name = name;
            Value = value;
            Ttl = ttl;
        }

        /// <summary> Type of the DNS record. Example: TXT. </summary>
        public string DnsRecordType { get; }
        /// <summary> Name of the DNS record. </summary>
        public string Name { get; }
        /// <summary> Value of the DNS record. </summary>
        public string Value { get; }
        /// <summary> Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default = 3600sec. </summary>
        public int? Ttl { get; }
    }
}
