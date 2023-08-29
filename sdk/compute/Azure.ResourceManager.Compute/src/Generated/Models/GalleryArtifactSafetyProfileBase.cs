// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the safety profile of the Gallery Artifact Version. </summary>
    public partial class GalleryArtifactSafetyProfileBase
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GalleryArtifactSafetyProfileBase"/>. </summary>
        public GalleryArtifactSafetyProfileBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryArtifactSafetyProfileBase"/>. </summary>
        /// <param name="allowDeletionOfReplicatedLocations"> Indicates whether or not removing this Gallery Image Version from replicated regions is allowed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryArtifactSafetyProfileBase(bool? allowDeletionOfReplicatedLocations, Dictionary<string, BinaryData> rawData)
        {
            AllowDeletionOfReplicatedLocations = allowDeletionOfReplicatedLocations;
            _rawData = rawData;
        }

        /// <summary> Indicates whether or not removing this Gallery Image Version from replicated regions is allowed. </summary>
        public bool? AllowDeletionOfReplicatedLocations { get; set; }
    }
}
