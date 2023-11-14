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
    /// <summary> List of RouteTables and a URL nextLink to get the next set of results. </summary>
    internal partial class ListHubRouteTablesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListHubRouteTablesResult"/>. </summary>
        internal ListHubRouteTablesResult()
        {
            Value = new ChangeTrackingList<HubRouteTableData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListHubRouteTablesResult"/>. </summary>
        /// <param name="value"> List of RouteTables. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListHubRouteTablesResult(IReadOnlyList<HubRouteTableData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of RouteTables. </summary>
        public IReadOnlyList<HubRouteTableData> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
