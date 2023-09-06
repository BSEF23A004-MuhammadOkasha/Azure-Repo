// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network interface and all its associated security rules. </summary>
    public partial class SecurityGroupNetworkInterface
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityGroupNetworkInterface"/>. </summary>
        internal SecurityGroupNetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityGroupNetworkInterface"/>. </summary>
        /// <param name="id"> ID of the network interface. </param>
        /// <param name="securityRuleAssociations"> All security rules associated with the network interface. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityGroupNetworkInterface(string id, SecurityRuleAssociations securityRuleAssociations, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            SecurityRuleAssociations = securityRuleAssociations;
            _rawData = rawData;
        }

        /// <summary> ID of the network interface. </summary>
        public string Id { get; }
        /// <summary> All security rules associated with the network interface. </summary>
        public SecurityRuleAssociations SecurityRuleAssociations { get; }
    }
}
