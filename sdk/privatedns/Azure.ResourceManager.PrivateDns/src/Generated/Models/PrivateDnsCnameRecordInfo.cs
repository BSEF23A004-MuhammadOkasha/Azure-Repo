// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> A CNAME record. </summary>
    internal partial class PrivateDnsCnameRecordInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateDnsCnameRecordInfo"/>. </summary>
        public PrivateDnsCnameRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsCnameRecordInfo"/>. </summary>
        /// <param name="cname"> The canonical name for this CNAME record. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsCnameRecordInfo(string cname, Dictionary<string, BinaryData> rawData)
        {
            Cname = cname;
            _rawData = rawData;
        }

        /// <summary> The canonical name for this CNAME record. </summary>
        public string Cname { get; set; }
    }
}
