// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> A TXT record. </summary>
    public partial class PrivateDnsTxtRecordInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateDnsTxtRecordInfo"/>. </summary>
        public PrivateDnsTxtRecordInfo()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsTxtRecordInfo"/>. </summary>
        /// <param name="values"> The text value of this TXT record. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsTxtRecordInfo(IList<string> values, Dictionary<string, BinaryData> rawData)
        {
            Values = values;
            _rawData = rawData;
        }

        /// <summary> The text value of this TXT record. </summary>
        public IList<string> Values { get; }
    }
}
