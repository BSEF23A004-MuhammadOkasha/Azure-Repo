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
    /// <summary> Response for ApplicationGatewayWafDynamicManifests API service call. </summary>
    internal partial class ApplicationGatewayWafDynamicManifestListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWafDynamicManifestListResult"/>. </summary>
        internal ApplicationGatewayWafDynamicManifestListResult()
        {
            Value = new ChangeTrackingList<ApplicationGatewayWafDynamicManifestData>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWafDynamicManifestListResult"/>. </summary>
        /// <param name="value"> The list of application gateway waf manifest. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayWafDynamicManifestListResult(IReadOnlyList<ApplicationGatewayWafDynamicManifestData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of application gateway waf manifest. </summary>
        public IReadOnlyList<ApplicationGatewayWafDynamicManifestData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
