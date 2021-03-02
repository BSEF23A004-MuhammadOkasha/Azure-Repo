// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate.Models
{
    /// <summary> The list of device tags. </summary>
    public partial class PageableListOfDeviceTags
    {
        /// <summary> Initializes a new instance of PageableListOfDeviceTags. </summary>
        internal PageableListOfDeviceTags()
        {
            Value = new ChangeTrackingList<DeviceTag>();
        }

        /// <summary> Initializes a new instance of PageableListOfDeviceTags. </summary>
        /// <param name="value"> The collection of pageable items. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal PageableListOfDeviceTags(IReadOnlyList<DeviceTag> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of pageable items. </summary>
        public IReadOnlyList<DeviceTag> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
