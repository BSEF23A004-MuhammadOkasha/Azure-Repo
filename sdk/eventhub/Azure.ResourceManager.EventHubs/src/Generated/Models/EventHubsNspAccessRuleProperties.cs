// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties of Access Rule. </summary>
    public partial class EventHubsNspAccessRuleProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsNspAccessRuleProperties"/>. </summary>
        internal EventHubsNspAccessRuleProperties()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            Subscriptions = new ChangeTrackingList<SubResource>();
            NetworkSecurityPerimeters = new ChangeTrackingList<EventHubsNetworkSecurityPerimeter>();
            FullyQualifiedDomainNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNspAccessRuleProperties"/>. </summary>
        /// <param name="direction"> Direction of Access Rule. </param>
        /// <param name="addressPrefixes"> Address prefixes in the CIDR format for inbound rules. </param>
        /// <param name="subscriptions"> Subscriptions for inbound rules. </param>
        /// <param name="networkSecurityPerimeters"> NetworkSecurityPerimeters for inbound rules. </param>
        /// <param name="fullyQualifiedDomainNames"> FQDN for outbound rules. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNspAccessRuleProperties(EventHubsNspAccessRuleDirection? direction, IReadOnlyList<string> addressPrefixes, IReadOnlyList<SubResource> subscriptions, IReadOnlyList<EventHubsNetworkSecurityPerimeter> networkSecurityPerimeters, IReadOnlyList<string> fullyQualifiedDomainNames, Dictionary<string, BinaryData> rawData)
        {
            Direction = direction;
            AddressPrefixes = addressPrefixes;
            Subscriptions = subscriptions;
            NetworkSecurityPerimeters = networkSecurityPerimeters;
            FullyQualifiedDomainNames = fullyQualifiedDomainNames;
            _rawData = rawData;
        }

        /// <summary> Direction of Access Rule. </summary>
        public EventHubsNspAccessRuleDirection? Direction { get; }
        /// <summary> Address prefixes in the CIDR format for inbound rules. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
        /// <summary> Subscriptions for inbound rules. </summary>
        public IReadOnlyList<SubResource> Subscriptions { get; }
        /// <summary> NetworkSecurityPerimeters for inbound rules. </summary>
        public IReadOnlyList<EventHubsNetworkSecurityPerimeter> NetworkSecurityPerimeters { get; }
        /// <summary> FQDN for outbound rules. </summary>
        public IReadOnlyList<string> FullyQualifiedDomainNames { get; }
    }
}
