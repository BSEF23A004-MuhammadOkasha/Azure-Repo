// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Storage.Models
{
    /// <summary> Returns the requested Docker V2 Manifest file. </summary>
    public partial class DockerManifestV2 : ImageManifest
    {
        /// <summary> Initializes a new instance of DockerManifestV2. </summary>
        public DockerManifestV2()
        {
            Layers = new ChangeTrackingList<ContentDescriptor>();
        }

        /// <summary> Initializes a new instance of DockerManifestV2. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="mediaType"> Media type for this Manifest. </param>
        /// <param name="config"> V2 image config descriptor. </param>
        /// <param name="layers"> List of V2 image layer information. </param>
        internal DockerManifestV2(int schemaVersion, string mediaType, ContentDescriptor config, IList<ContentDescriptor> layers) : base(schemaVersion)
        {
            MediaType = mediaType;
            Config = config;
            Layers = layers;
        }
        /// <summary> V2 image config descriptor. </summary>
        public ContentDescriptor Config { get; set; }
        /// <summary> List of V2 image layer information. </summary>
        public IList<ContentDescriptor> Layers { get; }
    }
}
