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
    /// <summary> The response of a PrefixListGlobalRulestackResource list operation. </summary>
    internal partial class PrefixListGlobalRulestackResourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrefixListGlobalRulestackResourceListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PrefixListGlobalRulestackResourceListResult(IEnumerable<GlobalRulestackPrefixData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PrefixListGlobalRulestackResourceListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrefixListGlobalRulestackResourceListResult(IReadOnlyList<GlobalRulestackPrefixData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PrefixListGlobalRulestackResourceListResult"/> for deserialization. </summary>
        internal PrefixListGlobalRulestackResourceListResult()
        {
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<GlobalRulestackPrefixData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
