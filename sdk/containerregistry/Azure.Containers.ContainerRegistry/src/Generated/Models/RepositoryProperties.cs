// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Repository attributes. </summary>
    public partial class RepositoryProperties
    {
        /// <summary> Initializes a new instance of RepositoryProperties. </summary>
        /// <param name="registryName"> Registry name. </param>
        /// <param name="name"> Image name. </param>
        /// <param name="createdOn"> Image created time. </param>
        /// <param name="lastUpdatedOn"> Image last update time. </param>
        /// <param name="manifestCount"> Number of the manifests. </param>
        /// <param name="tagCount"> Number of the tags. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registryName"/> or <paramref name="name"/> is null. </exception>
        internal RepositoryProperties(string registryName, string name, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, int manifestCount, int tagCount)
        {
            if (registryName == null)
            {
                throw new ArgumentNullException(nameof(registryName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            RegistryName = registryName;
            Name = name;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ManifestCount = manifestCount;
            TagCount = tagCount;
        }

        /// <summary> Initializes a new instance of RepositoryProperties. </summary>
        /// <param name="registryName"> Registry name. </param>
        /// <param name="name"> Image name. </param>
        /// <param name="createdOn"> Image created time. </param>
        /// <param name="lastUpdatedOn"> Image last update time. </param>
        /// <param name="manifestCount"> Number of the manifests. </param>
        /// <param name="tagCount"> Number of the tags. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <param name="teleportEnabled"> Enables Teleport functionality on new images in the repository improving Container startup performance. </param>
        internal RepositoryProperties(string registryName, string name, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, int manifestCount, int tagCount, bool? canDelete, bool? canWrite, bool? canList, bool? canRead, bool? teleportEnabled)
        {
            RegistryName = registryName;
            Name = name;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ManifestCount = manifestCount;
            TagCount = tagCount;
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
            TeleportEnabled = teleportEnabled;
        }

        /// <summary> Registry name. </summary>
        public string RegistryName { get; }
        /// <summary> Image name. </summary>
        public string Name { get; }
        /// <summary> Image created time. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Image last update time. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> Number of the manifests. </summary>
        public int ManifestCount { get; }
        /// <summary> Number of the tags. </summary>
        public int TagCount { get; }
    }
}
