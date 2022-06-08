// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListAzureWebCategories API service call. </summary>
    internal partial class AzureWebCategoryListResult
    {
        /// <summary> Initializes a new instance of <see cref="AzureWebCategoryListResult"/>. </summary>
        internal AzureWebCategoryListResult()
        {
            Value = new ChangeTrackingList<AzureWebCategoryData>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureWebCategoryListResult"/>. </summary>
        /// <param name="value"> List of Azure Web Categories for a given Subscription. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal AzureWebCategoryListResult(IReadOnlyList<AzureWebCategoryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Azure Web Categories for a given Subscription. </summary>
        public IReadOnlyList<AzureWebCategoryData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
