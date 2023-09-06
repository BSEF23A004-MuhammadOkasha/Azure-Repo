// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> A CAA record. </summary>
    public partial class DnsCaaRecordInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DnsCaaRecordInfo"/>. </summary>
        public DnsCaaRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DnsCaaRecordInfo"/>. </summary>
        /// <param name="flags"> The flags for this CAA record as an integer between 0 and 255. </param>
        /// <param name="tag"> The tag for this CAA record. </param>
        /// <param name="value"> The value for this CAA record. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsCaaRecordInfo(int? flags, string tag, string value, Dictionary<string, BinaryData> rawData)
        {
            Flags = flags;
            Tag = tag;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The flags for this CAA record as an integer between 0 and 255. </summary>
        public int? Flags { get; set; }
        /// <summary> The tag for this CAA record. </summary>
        public string Tag { get; set; }
        /// <summary> The value for this CAA record. </summary>
        public string Value { get; set; }
    }
}
