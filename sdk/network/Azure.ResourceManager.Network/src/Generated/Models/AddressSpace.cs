// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network. </summary>
    internal partial class AddressSpace
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AddressSpace"/>. </summary>
        public AddressSpace()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AddressSpace"/>. </summary>
        /// <param name="addressPrefixes"> A list of address blocks reserved for this virtual network in CIDR notation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AddressSpace(IList<string> addressPrefixes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AddressPrefixes = addressPrefixes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of address blocks reserved for this virtual network in CIDR notation. </summary>
        public IList<string> AddressPrefixes { get; }
    }
}
