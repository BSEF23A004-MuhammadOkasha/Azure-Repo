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
    /// <summary> Response for packet core control planes API service call. </summary>
    internal partial class PacketCoreControlPlaneListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PacketCoreControlPlaneListResult"/>. </summary>
        internal PacketCoreControlPlaneListResult()
        {
            Value = new ChangeTrackingList<PacketCoreControlPlaneData>();
        }

        /// <summary> Initializes a new instance of <see cref="PacketCoreControlPlaneListResult"/>. </summary>
        /// <param name="value"> A list of packet core control planes in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PacketCoreControlPlaneListResult(IReadOnlyList<PacketCoreControlPlaneData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of packet core control planes in a resource group. </summary>
        public IReadOnlyList<PacketCoreControlPlaneData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
