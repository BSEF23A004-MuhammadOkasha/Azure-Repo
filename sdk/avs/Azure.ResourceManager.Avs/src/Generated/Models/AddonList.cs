// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A paged list of addons. </summary>
    internal partial class AddonList
    {
        /// <summary> Initializes a new instance of AddonList. </summary>
        internal AddonList()
        {
            Value = new ChangeTrackingList<AddonData>();
        }

        /// <summary> Initializes a new instance of AddonList. </summary>
        /// <param name="value"> The items on a page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal AddonList(IReadOnlyList<AddonData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on a page. </summary>
        public IReadOnlyList<AddonData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
