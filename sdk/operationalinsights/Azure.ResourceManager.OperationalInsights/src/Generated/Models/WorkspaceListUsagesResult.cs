// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The list workspace usages operation response. </summary>
    internal partial class WorkspaceListUsagesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkspaceListUsagesResult"/>. </summary>
        internal WorkspaceListUsagesResult()
        {
            Value = new ChangeTrackingList<OperationalInsightsUsageMetric>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceListUsagesResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of usage metrics for a workspace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceListUsagesResult(IReadOnlyList<OperationalInsightsUsageMetric> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets or sets a list of usage metrics for a workspace. </summary>
        public IReadOnlyList<OperationalInsightsUsageMetric> Value { get; }
    }
}
