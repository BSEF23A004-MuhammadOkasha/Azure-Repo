// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list widget type operation. </summary>
    internal partial class WidgetTypeListResult
    {
        /// <summary> Initializes a new instance of WidgetTypeListResult. </summary>
        internal WidgetTypeListResult()
        {
            Value = new ChangeTrackingList<WidgetTypeResourceFormatData>();
        }

        /// <summary> Initializes a new instance of WidgetTypeListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal WidgetTypeListResult(IReadOnlyList<WidgetTypeResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<WidgetTypeResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
