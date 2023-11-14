// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Response for the ListSpacecrafts API service call. </summary>
    internal partial class OrbitalSpacecraftListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OrbitalSpacecraftListResult"/>. </summary>
        internal OrbitalSpacecraftListResult()
        {
            Value = new ChangeTrackingList<OrbitalSpacecraftData>();
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalSpacecraftListResult"/>. </summary>
        /// <param name="value"> A list of spacecraft resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OrbitalSpacecraftListResult(IReadOnlyList<OrbitalSpacecraftData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of spacecraft resources in a resource group. </summary>
        public IReadOnlyList<OrbitalSpacecraftData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
