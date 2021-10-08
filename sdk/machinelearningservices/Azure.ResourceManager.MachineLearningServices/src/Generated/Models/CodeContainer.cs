// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Container for code asset versions. </summary>
    public partial class CodeContainer : AssetContainer
    {
        /// <summary> Initializes a new instance of CodeContainer. </summary>
        public CodeContainer()
        {
        }

        /// <summary> Initializes a new instance of CodeContainer. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        internal CodeContainer(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, string latestVersion, string nextVersion) : base(description, properties, tags, latestVersion, nextVersion)
        {
        }
    }
}
