// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> Paged response contains list of requested objects and a URL link to get the next set of results. </summary>
    internal partial class FarmBeatsExtensionListResponse
    {
        /// <summary> Initializes a new instance of FarmBeatsExtensionListResponse. </summary>
        internal FarmBeatsExtensionListResponse()
        {
            Value = new Core.ChangeTrackingList<FarmBeatsExtensionData>();
        }

        /// <summary> Initializes a new instance of FarmBeatsExtensionListResponse. </summary>
        /// <param name="value"> List of requested objects. </param>
        /// <param name="nextLink"> Continuation link (absolute URI) to the next page of results in the list. </param>
        internal FarmBeatsExtensionListResponse(IReadOnlyList<FarmBeatsExtensionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of requested objects. </summary>
        public IReadOnlyList<FarmBeatsExtensionData> Value { get; }
        /// <summary> Continuation link (absolute URI) to the next page of results in the list. </summary>
        public string NextLink { get; }
    }
}
