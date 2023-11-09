// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The sku of this Bastion Host. </summary>
    internal partial class NetworkSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkSku"/>. </summary>
        public NetworkSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSku"/>. </summary>
        /// <param name="name"> The name of this Bastion Host. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSku(BastionHostSkuName? name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of this Bastion Host. </summary>
        public BastionHostSkuName? Name { get; set; }
    }
}
