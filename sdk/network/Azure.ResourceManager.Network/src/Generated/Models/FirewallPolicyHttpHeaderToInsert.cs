// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> name and value of HTTP/S header to insert. </summary>
    public partial class FirewallPolicyHttpHeaderToInsert
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyHttpHeaderToInsert"/>. </summary>
        public FirewallPolicyHttpHeaderToInsert()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyHttpHeaderToInsert"/>. </summary>
        /// <param name="headerName"> Contains the name of the header. </param>
        /// <param name="headerValue"> Contains the value of the header. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicyHttpHeaderToInsert(string headerName, string headerValue, Dictionary<string, BinaryData> rawData)
        {
            HeaderName = headerName;
            HeaderValue = headerValue;
            _rawData = rawData;
        }

        /// <summary> Contains the name of the header. </summary>
        public string HeaderName { get; set; }
        /// <summary> Contains the value of the header. </summary>
        public string HeaderValue { get; set; }
    }
}
