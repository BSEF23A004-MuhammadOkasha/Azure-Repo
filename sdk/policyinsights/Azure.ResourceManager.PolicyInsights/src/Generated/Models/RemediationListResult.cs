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
    /// <summary> List of remediations. </summary>
    internal partial class RemediationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemediationListResult"/>. </summary>
        internal RemediationListResult()
        {
            Value = new ChangeTrackingList<PolicyRemediationData>();
        }

        /// <summary> Initializes a new instance of <see cref="RemediationListResult"/>. </summary>
        /// <param name="value"> Array of remediation definitions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemediationListResult(IReadOnlyList<PolicyRemediationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of remediation definitions. </summary>
        public IReadOnlyList<PolicyRemediationData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
