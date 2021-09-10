// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Container for environment specification versions. </summary>
    public partial class EnvironmentContainer
    {
        /// <summary> Initializes a new instance of EnvironmentContainer. </summary>
        public EnvironmentContainer()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of EnvironmentContainer. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        internal EnvironmentContainer(string description, string latestVersion, string nextVersion, IDictionary<string, string> properties, IDictionary<string, string> tags)
        {
            Description = description;
            LatestVersion = latestVersion;
            NextVersion = nextVersion;
            Properties = properties;
            Tags = tags;
        }

        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
        /// <summary> The latest version inside this container. </summary>
        public string LatestVersion { get; }
        /// <summary> The next auto incremental version. </summary>
        public string NextVersion { get; }
        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}
