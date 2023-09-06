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
    /// <summary> The response of a FqdnListLocalRulestackResource list operation. </summary>
    internal partial class LocalRulestackFqdnListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LocalRulestackFqdnListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LocalRulestackFqdnListResult(IEnumerable<LocalRulestackFqdnData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="LocalRulestackFqdnListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LocalRulestackFqdnListResult(IReadOnlyList<LocalRulestackFqdnData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LocalRulestackFqdnListResult"/> for deserialization. </summary>
        internal LocalRulestackFqdnListResult()
        {
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<LocalRulestackFqdnData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
