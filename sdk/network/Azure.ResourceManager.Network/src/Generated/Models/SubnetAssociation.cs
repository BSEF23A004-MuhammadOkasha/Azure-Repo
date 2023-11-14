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
    /// <summary> Subnet and it's custom security rules. </summary>
    public partial class SubnetAssociation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SubnetAssociation"/>. </summary>
        internal SubnetAssociation()
        {
            SecurityRules = new ChangeTrackingList<SecurityRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="SubnetAssociation"/>. </summary>
        /// <param name="id"> Subnet ID. </param>
        /// <param name="securityRules"> Collection of custom security rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubnetAssociation(ResourceIdentifier id, IReadOnlyList<SecurityRuleData> securityRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            SecurityRules = securityRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Subnet ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Collection of custom security rules. </summary>
        public IReadOnlyList<SecurityRuleData> SecurityRules { get; }
    }
}
