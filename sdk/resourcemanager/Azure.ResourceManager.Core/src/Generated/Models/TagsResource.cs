﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.ResourceManager.Core
{
    /// <summary> Wrapper resource for tags API requests and responses. </summary>
    public partial class TagsResource
    {
        /// <summary> Initializes a new instance of TagsResource. </summary>
        /// <param name="properties"> The set of tags. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public TagsResource(TagsData properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of TagsResource. </summary>
        /// <param name="id"> The ID of the tags wrapper resource. </param>
        /// <param name="name"> The name of the tags wrapper resource. </param>
        /// <param name="type"> The type of the tags wrapper resource. </param>
        /// <param name="properties"> The set of tags. </param>
        internal TagsResource(string id, string name, string type, TagsData properties)
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
        }

        /// <summary> The ID of the tags wrapper resource. </summary>
        public string Id { get; }
        /// <summary> The name of the tags wrapper resource. </summary>
        public string Name { get; }
        /// <summary> The type of the tags wrapper resource. </summary>
        public string Type { get; }
        /// <summary> The set of tags. </summary>
        public TagsData Properties { get; set; }
    }
}
