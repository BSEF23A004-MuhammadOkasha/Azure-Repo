// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> TrunkedNetworkList represents a list of trunked networks. </summary>
    internal partial class TrunkedNetworkList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TrunkedNetworkList"/>. </summary>
        internal TrunkedNetworkList()
        {
            Value = new ChangeTrackingList<NetworkCloudTrunkedNetworkData>();
        }

        /// <summary> Initializes a new instance of <see cref="TrunkedNetworkList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of trunked networks. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrunkedNetworkList(string nextLink, IReadOnlyList<NetworkCloudTrunkedNetworkData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of trunked networks. </summary>
        public IReadOnlyList<NetworkCloudTrunkedNetworkData> Value { get; }
    }
}
