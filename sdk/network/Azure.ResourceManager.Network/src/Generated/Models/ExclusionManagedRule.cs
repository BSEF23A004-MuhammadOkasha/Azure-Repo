// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines a managed rule to use for exclusion. </summary>
    public partial class ExclusionManagedRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExclusionManagedRule"/>. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public ExclusionManagedRule(string ruleId)
        {
            Argument.AssertNotNull(ruleId, nameof(ruleId));

            RuleId = ruleId;
        }

        /// <summary> Initializes a new instance of <see cref="ExclusionManagedRule"/>. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExclusionManagedRule(string ruleId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuleId = ruleId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExclusionManagedRule"/> for deserialization. </summary>
        internal ExclusionManagedRule()
        {
        }

        /// <summary> Identifier for the managed rule. </summary>
        public string RuleId { get; set; }
    }
}
