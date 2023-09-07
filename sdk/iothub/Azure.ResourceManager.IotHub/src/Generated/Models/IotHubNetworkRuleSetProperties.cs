// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Network Rule Set Properties of IotHub. </summary>
    public partial class IotHubNetworkRuleSetProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubNetworkRuleSetProperties"/>. </summary>
        /// <param name="applyToBuiltInEventHubEndpoint"> If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub. </param>
        /// <param name="ipRules"> List of IP Rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipRules"/> is null. </exception>
        public IotHubNetworkRuleSetProperties(bool applyToBuiltInEventHubEndpoint, IEnumerable<IotHubNetworkRuleSetIPRule> ipRules)
        {
            Argument.AssertNotNull(ipRules, nameof(ipRules));

            ApplyToBuiltInEventHubEndpoint = applyToBuiltInEventHubEndpoint;
            IPRules = ipRules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IotHubNetworkRuleSetProperties"/>. </summary>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="applyToBuiltInEventHubEndpoint"> If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub. </param>
        /// <param name="ipRules"> List of IP Rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubNetworkRuleSetProperties(IotHubNetworkRuleSetDefaultAction? defaultAction, bool applyToBuiltInEventHubEndpoint, IList<IotHubNetworkRuleSetIPRule> ipRules, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DefaultAction = defaultAction;
            ApplyToBuiltInEventHubEndpoint = applyToBuiltInEventHubEndpoint;
            IPRules = ipRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubNetworkRuleSetProperties"/> for deserialization. </summary>
        internal IotHubNetworkRuleSetProperties()
        {
        }

        /// <summary> Default Action for Network Rule Set. </summary>
        public IotHubNetworkRuleSetDefaultAction? DefaultAction { get; set; }
        /// <summary> If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub. </summary>
        public bool ApplyToBuiltInEventHubEndpoint { get; set; }
        /// <summary> List of IP Rules. </summary>
        public IList<IotHubNetworkRuleSetIPRule> IPRules { get; }
    }
}
