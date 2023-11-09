// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListNetworkSecurityGroups API service call. </summary>
    internal partial class NetworkSecurityGroupListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupListResult"/>. </summary>
        internal NetworkSecurityGroupListResult()
        {
            Value = new ChangeTrackingList<NetworkSecurityGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupListResult"/>. </summary>
        /// <param name="value"> A list of NetworkSecurityGroup resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityGroupListResult(IReadOnlyList<NetworkSecurityGroupData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of NetworkSecurityGroup resources. </summary>
        public IReadOnlyList<NetworkSecurityGroupData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
