// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    /// <summary> The list of detected changes. </summary>
    internal partial class ChangeList
    {
        /// <summary> Initializes a new instance of ChangeList. </summary>
        internal ChangeList()
        {
            Value = new Core.ChangeTrackingList<DetectedChangeData>();
        }

        /// <summary> Initializes a new instance of ChangeList. </summary>
        /// <param name="value"> The list of changes. </param>
        /// <param name="nextLink"> The URI that can be used to request the next page of changes. </param>
        internal ChangeList(IReadOnlyList<DetectedChangeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of changes. </summary>
        public IReadOnlyList<DetectedChangeData> Value { get; }
        /// <summary> The URI that can be used to request the next page of changes. </summary>
        public string NextLink { get; }
    }
}
