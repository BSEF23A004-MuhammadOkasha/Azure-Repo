// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Contains a list of PrivateLinkResource and a possible link to query more results. </summary>
    internal partial class PrivateLinkResourceList
    {
        /// <summary> Initializes a new instance of PrivateLinkResourceList. </summary>
        internal PrivateLinkResourceList()
        {
            Value = new Core.ChangeTrackingList<WebPubSubPrivateLink>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResourceList. </summary>
        /// <param name="value"> List of PrivateLinkResource. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal PrivateLinkResourceList(IReadOnlyList<WebPubSubPrivateLink> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of PrivateLinkResource. </summary>
        public IReadOnlyList<WebPubSubPrivateLink> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
