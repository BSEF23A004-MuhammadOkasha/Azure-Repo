﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    /// <summary> Tag details. </summary>
    public partial class TagDetails
    {
        /// <summary> Initializes a new instance of TagDetails. </summary>
        internal TagDetails()
        {
            Values = new ChangeTrackingList<TagValue>();
        }

        /// <summary> Initializes a new instance of TagDetails. </summary>
        /// <param name="id"> The tag name ID. </param>
        /// <param name="tagName"> The tag name. </param>
        /// <param name="count"> The total number of resources that use the resource tag. When a tag is initially created and has no associated resources, the value is 0. </param>
        /// <param name="values"> The list of tag values. </param>
        internal TagDetails(string id, string tagName, TagCount count, IReadOnlyList<TagValue> values)
        {
            Id = id;
            TagName = tagName;
            Count = count;
            Values = values;
        }

        /// <summary> The tag name ID. </summary>
        public string Id { get; }
        /// <summary> The tag name. </summary>
        public string TagName { get; }
        /// <summary> The total number of resources that use the resource tag. When a tag is initially created and has no associated resources, the value is 0. </summary>
        public TagCount Count { get; }
        /// <summary> The list of tag values. </summary>
        public IReadOnlyList<TagValue> Values { get; }
    }
}
