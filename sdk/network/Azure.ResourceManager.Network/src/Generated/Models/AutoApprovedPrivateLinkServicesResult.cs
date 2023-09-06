// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An array of private link service id that can be linked to a private end point with auto approved. </summary>
    internal partial class AutoApprovedPrivateLinkServicesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutoApprovedPrivateLinkServicesResult"/>. </summary>
        internal AutoApprovedPrivateLinkServicesResult()
        {
            Value = new ChangeTrackingList<AutoApprovedPrivateLinkService>();
        }

        /// <summary> Initializes a new instance of <see cref="AutoApprovedPrivateLinkServicesResult"/>. </summary>
        /// <param name="value"> An array of auto approved private link service. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoApprovedPrivateLinkServicesResult(IReadOnlyList<AutoApprovedPrivateLinkService> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> An array of auto approved private link service. </summary>
        public IReadOnlyList<AutoApprovedPrivateLinkService> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
