// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Response for data network API service call. </summary>
    internal partial class DataNetworkListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataNetworkListResult"/>. </summary>
        internal DataNetworkListResult()
        {
            Value = new ChangeTrackingList<MobileDataNetworkData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataNetworkListResult"/>. </summary>
        /// <param name="value"> A list of data networks. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataNetworkListResult(IReadOnlyList<MobileDataNetworkData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of data networks. </summary>
        public IReadOnlyList<MobileDataNetworkData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
