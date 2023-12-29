// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeRoleAddon data model.
    /// Role Addon
    /// Please note <see cref="DataBoxEdgeRoleAddonData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="EdgeArcAddon"/> and <see cref="EdgeIotAddon"/>.
    /// </summary>
    public abstract partial class DataBoxEdgeRoleAddonData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeRoleAddonData"/>. </summary>
        protected DataBoxEdgeRoleAddonData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeRoleAddonData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Addon type. </param>
        internal DataBoxEdgeRoleAddonData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AddonType kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> Addon type. </summary>
        internal AddonType Kind { get; set; }
    }
}
