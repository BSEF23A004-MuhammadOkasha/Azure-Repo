// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Artifact profile properties. </summary>
    public partial class NSDArtifactProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NSDArtifactProfile"/>. </summary>
        public NSDArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NSDArtifactProfile"/>. </summary>
        /// <param name="artifactStoreReference"> The artifact store resource id. </param>
        /// <param name="artifactName"> Artifact name. </param>
        /// <param name="artifactVersion"> Artifact version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NSDArtifactProfile(WritableSubResource artifactStoreReference, string artifactName, string artifactVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ArtifactStoreReference = artifactStoreReference;
            ArtifactName = artifactName;
            ArtifactVersion = artifactVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The artifact store resource id. </summary>
        internal WritableSubResource ArtifactStoreReference { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ArtifactStoreReferenceId
        {
            get => ArtifactStoreReference is null ? default : ArtifactStoreReference.Id;
            set
            {
                if (ArtifactStoreReference is null)
                    ArtifactStoreReference = new WritableSubResource();
                ArtifactStoreReference.Id = value;
            }
        }

        /// <summary> Artifact name. </summary>
        public string ArtifactName { get; set; }
        /// <summary> Artifact version. </summary>
        public string ArtifactVersion { get; set; }
    }
}
