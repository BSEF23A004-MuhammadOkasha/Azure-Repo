// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of Internet Gateway Rules. </summary>
    internal partial class InternetGatewayRulesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InternetGatewayRulesListResult"/>. </summary>
        internal InternetGatewayRulesListResult()
        {
            Value = new ChangeTrackingList<NetworkFabricInternetGatewayRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="InternetGatewayRulesListResult"/>. </summary>
        /// <param name="value"> List of Internet Gateway Rule resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternetGatewayRulesListResult(IReadOnlyList<NetworkFabricInternetGatewayRuleData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Internet Gateway Rule resources. </summary>
        public IReadOnlyList<NetworkFabricInternetGatewayRuleData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
