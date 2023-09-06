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
    /// <summary> Response for ListSubnets API service callRetrieves all subnet that belongs to a virtual network. </summary>
    internal partial class SubnetListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SubnetListResult"/>. </summary>
        internal SubnetListResult()
        {
            Value = new ChangeTrackingList<SubnetData>();
        }

        /// <summary> Initializes a new instance of <see cref="SubnetListResult"/>. </summary>
        /// <param name="value"> The subnets in a virtual network. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SubnetListResult(IReadOnlyList<SubnetData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The subnets in a virtual network. </summary>
        public IReadOnlyList<SubnetData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
