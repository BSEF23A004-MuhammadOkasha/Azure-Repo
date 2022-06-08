// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary> A class representing the ConfigServerResource data model. </summary>
    public partial class ConfigServerResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ConfigServerResourceData"/>. </summary>
        public ConfigServerResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConfigServerResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the Config Server resource. </param>
        internal ConfigServerResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ConfigServerProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the Config Server resource. </summary>
        public ConfigServerProperties Properties { get; set; }
    }
}
