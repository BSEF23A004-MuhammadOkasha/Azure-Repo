// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EnrichmentStatusList. </summary>
    internal partial class EnrichmentStatusList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EnrichmentStatusList"/>. </summary>
        internal EnrichmentStatusList()
        {
            Value = new ChangeTrackingList<EnrichmentStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="EnrichmentStatusList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnrichmentStatusList(string nextLink, IReadOnlyList<EnrichmentStatus> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<EnrichmentStatus> Value { get; }
    }
}
