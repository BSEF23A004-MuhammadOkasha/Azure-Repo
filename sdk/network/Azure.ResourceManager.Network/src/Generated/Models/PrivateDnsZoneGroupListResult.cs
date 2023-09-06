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
    /// <summary> Response for the ListPrivateDnsZoneGroups API service call. </summary>
    internal partial class PrivateDnsZoneGroupListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateDnsZoneGroupListResult"/>. </summary>
        internal PrivateDnsZoneGroupListResult()
        {
            Value = new ChangeTrackingList<PrivateDnsZoneGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsZoneGroupListResult"/>. </summary>
        /// <param name="value"> A list of private dns zone group resources in a private endpoint. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsZoneGroupListResult(IReadOnlyList<PrivateDnsZoneGroupData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of private dns zone group resources in a private endpoint. </summary>
        public IReadOnlyList<PrivateDnsZoneGroupData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
