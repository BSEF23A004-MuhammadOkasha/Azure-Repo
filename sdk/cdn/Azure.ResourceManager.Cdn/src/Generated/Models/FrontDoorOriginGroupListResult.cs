// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list origin groups. It contains a list of origin groups objects and a URL link to get the next set of results. </summary>
    internal partial class FrontDoorOriginGroupListResult
    {
        /// <summary> Initializes a new instance of FrontDoorOriginGroupListResult. </summary>
        internal FrontDoorOriginGroupListResult()
        {
            Value = new Core.ChangeTrackingList<FrontDoorOriginGroupData>();
        }

        /// <summary> Initializes a new instance of FrontDoorOriginGroupListResult. </summary>
        /// <param name="value"> List of CDN origin groups within an endpoint. </param>
        /// <param name="nextLink"> URL to get the next set of origin objects if there are any. </param>
        internal FrontDoorOriginGroupListResult(IReadOnlyList<FrontDoorOriginGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of CDN origin groups within an endpoint. </summary>
        public IReadOnlyList<FrontDoorOriginGroupData> Value { get; }
        /// <summary> URL to get the next set of origin objects if there are any. </summary>
        public string NextLink { get; }
    }
}
