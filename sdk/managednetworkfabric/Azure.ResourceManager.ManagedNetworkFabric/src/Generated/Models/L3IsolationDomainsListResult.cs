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
    /// <summary> List of L3 Isolation Domains. </summary>
    internal partial class L3IsolationDomainsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="L3IsolationDomainsListResult"/>. </summary>
        internal L3IsolationDomainsListResult()
        {
            Value = new ChangeTrackingList<NetworkFabricL3IsolationDomainData>();
        }

        /// <summary> Initializes a new instance of <see cref="L3IsolationDomainsListResult"/>. </summary>
        /// <param name="value"> List of L3 Isolation Domain resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal L3IsolationDomainsListResult(IReadOnlyList<NetworkFabricL3IsolationDomainData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of L3 Isolation Domain resources. </summary>
        public IReadOnlyList<NetworkFabricL3IsolationDomainData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
