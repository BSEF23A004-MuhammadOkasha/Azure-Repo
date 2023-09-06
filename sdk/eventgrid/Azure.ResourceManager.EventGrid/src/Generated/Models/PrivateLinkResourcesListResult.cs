// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List private link resources operation. </summary>
    internal partial class PrivateLinkResourcesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesListResult"/>. </summary>
        internal PrivateLinkResourcesListResult()
        {
            Value = new ChangeTrackingList<EventGridPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesListResult"/>. </summary>
        /// <param name="value"> A collection of private link resources. </param>
        /// <param name="nextLink"> A link for the next page of private link resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkResourcesListResult(IReadOnlyList<EventGridPrivateLinkResourceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of private link resources. </summary>
        public IReadOnlyList<EventGridPrivateLinkResourceData> Value { get; }
        /// <summary> A link for the next page of private link resources. </summary>
        public string NextLink { get; }
    }
}
