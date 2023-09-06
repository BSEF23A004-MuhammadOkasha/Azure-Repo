// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The response of a PostRulesResource list operation. </summary>
    internal partial class PostRulesResourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostRulesResourceListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PostRulesResourceListResult(IEnumerable<PostRulestackRuleData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PostRulesResourceListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostRulesResourceListResult(IReadOnlyList<PostRulestackRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostRulesResourceListResult"/> for deserialization. </summary>
        internal PostRulesResourceListResult()
        {
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<PostRulestackRuleData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
