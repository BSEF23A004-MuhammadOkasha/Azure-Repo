// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> List of attestations. </summary>
    internal partial class AttestationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AttestationListResult"/>. </summary>
        internal AttestationListResult()
        {
            Value = new ChangeTrackingList<PolicyAttestationData>();
        }

        /// <summary> Initializes a new instance of <see cref="AttestationListResult"/>. </summary>
        /// <param name="value"> Array of attestation definitions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AttestationListResult(IReadOnlyList<PolicyAttestationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of attestation definitions. </summary>
        public IReadOnlyList<PolicyAttestationData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
