// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of the network rules. </summary>
    internal partial class NetworkRuleSet
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkRuleSet"/>. </summary>
        public NetworkRuleSet()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRuleSet"/>. </summary>
        /// <param name="publicNetworkAccess"> The configuration to set whether network access from public internet to the endpoints are allowed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkRuleSet(MonitorPublicNetworkAccess? publicNetworkAccess, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublicNetworkAccess = publicNetworkAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration to set whether network access from public internet to the endpoints are allowed. </summary>
        public MonitorPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
