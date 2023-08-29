// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The gallery artifact version source. </summary>
    public partial class GalleryArtifactVersionSource
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GalleryArtifactVersionSource"/>. </summary>
        public GalleryArtifactVersionSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryArtifactVersionSource"/>. </summary>
        /// <param name="id"> The id of the gallery artifact version source. Can specify a disk uri, snapshot uri, user image or storage account resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryArtifactVersionSource(ResourceIdentifier id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }

        /// <summary> The id of the gallery artifact version source. Can specify a disk uri, snapshot uri, user image or storage account resource. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
