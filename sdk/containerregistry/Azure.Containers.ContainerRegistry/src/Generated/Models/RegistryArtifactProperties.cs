// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Manifest attributes details. </summary>
    public partial class RegistryArtifactProperties
    {
        /// <summary> Initializes a new instance of RegistryArtifactProperties. </summary>
        internal RegistryArtifactProperties()
        {
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RegistryArtifactProperties. </summary>
        /// <param name="registry"> Registry name. </param>
        /// <param name="repository"> Image name. </param>
        /// <param name="digest"> Manifest. </param>
        /// <param name="size"> Image size. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <param name="cpuArchitecture"> CPU architecture. </param>
        /// <param name="operatingSystem"> Operating system. </param>
        /// <param name="manifestMediaType"> Media type. </param>
        /// <param name="configMediaType"> Config blob media type. </param>
        /// <param name="tags"> List of tags. </param>
        /// <param name="manifestProperties"> Changeable attributes. </param>
        internal RegistryArtifactProperties(string registry, string repository, string digest, long? size, DateTimeOffset? createdOn, DateTimeOffset? lastUpdatedOn, string cpuArchitecture, string operatingSystem, string manifestMediaType, string configMediaType, IReadOnlyList<string> tags, ContentProperties manifestProperties)
        {
            Registry = registry;
            Repository = repository;
            Digest = digest;
            Size = size;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            CpuArchitecture = cpuArchitecture;
            OperatingSystem = operatingSystem;
            ManifestMediaType = manifestMediaType;
            ConfigMediaType = configMediaType;
            Tags = tags;
            ManifestProperties = manifestProperties;
        }

        /// <summary> Registry name. </summary>
        public string Registry { get; }
        /// <summary> Image name. </summary>
        public string Repository { get; }
        /// <summary> Manifest. </summary>
        public string Digest { get; }
        /// <summary> Image size. </summary>
        public long? Size { get; }
        /// <summary> Created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last update time. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> CPU architecture. </summary>
        public string CpuArchitecture { get; }
        /// <summary> Operating system. </summary>
        public string OperatingSystem { get; }
        /// <summary> Media type. </summary>
        public string ManifestMediaType { get; }
        /// <summary> Config blob media type. </summary>
        public string ConfigMediaType { get; }
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }
        /// <summary> Changeable attributes. </summary>
        public ContentProperties ManifestProperties { get; }
    }
}
