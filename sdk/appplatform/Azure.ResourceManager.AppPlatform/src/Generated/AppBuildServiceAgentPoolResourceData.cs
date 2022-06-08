// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary> A class representing the AppBuildServiceAgentPoolResource data model. </summary>
    public partial class AppBuildServiceAgentPoolResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppBuildServiceAgentPoolResourceData"/>. </summary>
        public AppBuildServiceAgentPoolResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppBuildServiceAgentPoolResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> build service agent pool properties. </param>
        internal AppBuildServiceAgentPoolResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BuildServiceAgentPoolProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> build service agent pool properties. </summary>
        public BuildServiceAgentPoolProperties Properties { get; set; }
    }
}
