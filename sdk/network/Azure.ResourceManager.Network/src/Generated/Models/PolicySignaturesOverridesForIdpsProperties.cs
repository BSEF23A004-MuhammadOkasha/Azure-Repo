// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Will contain the properties of the resource (the actual signature overrides). </summary>
    internal partial class PolicySignaturesOverridesForIdpsProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicySignaturesOverridesForIdpsProperties"/>. </summary>
        public PolicySignaturesOverridesForIdpsProperties()
        {
            Signatures = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicySignaturesOverridesForIdpsProperties"/>. </summary>
        /// <param name="signatures"> Dictionary of &lt;string&gt;. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicySignaturesOverridesForIdpsProperties(IDictionary<string, string> signatures, Dictionary<string, BinaryData> rawData)
        {
            Signatures = signatures;
            _rawData = rawData;
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Signatures { get; }
    }
}
