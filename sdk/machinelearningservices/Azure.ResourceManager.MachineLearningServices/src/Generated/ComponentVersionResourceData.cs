// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the ComponentVersionResource data model. </summary>
    public partial class ComponentVersionResourceData : Resource
    {
        /// <summary> Initializes a new instance of ComponentVersionResourceData. </summary>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ComponentVersionResourceData(ComponentVersion properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of ComponentVersionResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="systemData"> System data associated with resource provider. </param>
        internal ComponentVersionResourceData(ResourceIdentifier id, string name, ResourceType type, ComponentVersion properties, SystemData systemData) : base(id, name, type)
        {
            Properties = properties;
            SystemData = systemData;
        }

        /// <summary> Additional attributes of the entity. </summary>
        public ComponentVersion Properties { get; set; }
        /// <summary> System data associated with resource provider. </summary>
        public SystemData SystemData { get; }
    }
}
