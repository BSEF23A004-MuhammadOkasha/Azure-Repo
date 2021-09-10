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
    /// <summary> A class representing the EnvironmentContainerResource data model. </summary>
    public partial class EnvironmentContainerResourceData : Resource
    {
        /// <summary> Initializes a new instance of EnvironmentContainerResourceData. </summary>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public EnvironmentContainerResourceData(EnvironmentContainer properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of EnvironmentContainerResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="systemData"> System data associated with resource provider. </param>
        internal EnvironmentContainerResourceData(ResourceIdentifier id, string name, ResourceType type, EnvironmentContainer properties, SystemData systemData) : base(id, name, type)
        {
            Properties = properties;
            SystemData = systemData;
        }

        /// <summary> Additional attributes of the entity. </summary>
        public EnvironmentContainer Properties { get; set; }
        /// <summary> System data associated with resource provider. </summary>
        public SystemData SystemData { get; }
    }
}
