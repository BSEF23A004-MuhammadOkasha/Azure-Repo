// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The list workspaces operation response. </summary>
    internal partial class WorkspaceListResult
    {
        /// <summary> Initializes a new instance of WorkspaceListResult. </summary>
        internal WorkspaceListResult()
        {
            Value = new ChangeTrackingList<OperationalInsightsWorkspaceData>();
        }

        /// <summary> Initializes a new instance of WorkspaceListResult. </summary>
        /// <param name="value"> A list of workspaces. </param>
        internal WorkspaceListResult(IReadOnlyList<OperationalInsightsWorkspaceData> value)
        {
            Value = value;
        }

        /// <summary> A list of workspaces. </summary>
        public IReadOnlyList<OperationalInsightsWorkspaceData> Value { get; }
    }
}
