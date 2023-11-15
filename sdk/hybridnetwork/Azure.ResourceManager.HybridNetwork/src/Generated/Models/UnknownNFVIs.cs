// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The UnknownNFVIs. </summary>
    internal partial class UnknownNFVIs : NFVIs
    {
        /// <summary> Initializes a new instance of <see cref="UnknownNFVIs"/>. </summary>
        /// <param name="name"> Name of the nfvi. </param>
        /// <param name="nfviType"> The NFVI type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownNFVIs(string name, NfviType nfviType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(name, nfviType, serializedAdditionalRawData)
        {
            NfviType = nfviType;
        }
    }
}
