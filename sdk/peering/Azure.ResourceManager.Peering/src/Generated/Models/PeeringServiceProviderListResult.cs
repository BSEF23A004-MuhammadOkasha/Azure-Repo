// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The paginated list of peering service providers. </summary>
    internal partial class PeeringServiceProviderListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PeeringServiceProviderListResult"/>. </summary>
        internal PeeringServiceProviderListResult()
        {
            Value = new ChangeTrackingList<PeeringServiceProvider>();
        }

        /// <summary> Initializes a new instance of <see cref="PeeringServiceProviderListResult"/>. </summary>
        /// <param name="value"> The list of peering service providers. </param>
        /// <param name="nextLink"> The link to fetch the next page of peering service providers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringServiceProviderListResult(IReadOnlyList<PeeringServiceProvider> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of peering service providers. </summary>
        public IReadOnlyList<PeeringServiceProvider> Value { get; }
        /// <summary> The link to fetch the next page of peering service providers. </summary>
        public string NextLink { get; }
    }
}
