// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningModelContainerProperties. </summary>
    public partial class MachineLearningModelContainerProperties : MachineLearningAssetContainer
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningModelContainerProperties"/>. </summary>
        public MachineLearningModelContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningModelContainerProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningModelContainerProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isArchived, string latestVersion, string nextVersion, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(description, properties, tags, isArchived, latestVersion, nextVersion, serializedAdditionalRawData)
        {
        }
    }
}
