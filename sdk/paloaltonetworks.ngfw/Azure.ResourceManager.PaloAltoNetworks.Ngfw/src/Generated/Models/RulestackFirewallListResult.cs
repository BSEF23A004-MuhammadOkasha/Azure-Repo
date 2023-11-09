// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> List firewalls response. </summary>
    internal partial class RulestackFirewallListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RulestackFirewallListResult"/>. </summary>
        /// <param name="value"> firewalls list. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RulestackFirewallListResult(IEnumerable<string> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RulestackFirewallListResult"/>. </summary>
        /// <param name="value"> firewalls list. </param>
        /// <param name="nextLink"> next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RulestackFirewallListResult(IReadOnlyList<string> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulestackFirewallListResult"/> for deserialization. </summary>
        internal RulestackFirewallListResult()
        {
        }

        /// <summary> firewalls list. </summary>
        public IReadOnlyList<string> Value { get; }
        /// <summary> next link. </summary>
        public string NextLink { get; }
    }
}
