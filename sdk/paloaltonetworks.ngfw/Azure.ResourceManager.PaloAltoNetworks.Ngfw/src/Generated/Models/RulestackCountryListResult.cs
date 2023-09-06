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
    /// <summary> Countries Response Object. </summary>
    internal partial class RulestackCountryListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RulestackCountryListResult"/>. </summary>
        /// <param name="value"> List of countries. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RulestackCountryListResult(IEnumerable<RulestackCountry> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RulestackCountryListResult"/>. </summary>
        /// <param name="value"> List of countries. </param>
        /// <param name="nextLink"> next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RulestackCountryListResult(IReadOnlyList<RulestackCountry> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulestackCountryListResult"/> for deserialization. </summary>
        internal RulestackCountryListResult()
        {
        }

        /// <summary> List of countries. </summary>
        public IReadOnlyList<RulestackCountry> Value { get; }
        /// <summary> next link. </summary>
        public string NextLink { get; }
    }
}
