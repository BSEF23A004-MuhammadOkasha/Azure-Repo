// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The SKU that defines the type of the peering service. </summary>
    internal partial class PeeringServiceSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PeeringServiceSku"/>. </summary>
        public PeeringServiceSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeeringServiceSku"/>. </summary>
        /// <param name="name"> The name of the peering service SKU. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringServiceSku(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The name of the peering service SKU. </summary>
        public string Name { get; set; }
    }
}
