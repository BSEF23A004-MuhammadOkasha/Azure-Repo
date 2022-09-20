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
    /// A class representing the DataBoxEdgeRole data model.
    /// Please note <see cref="DataBoxEdgeRoleData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CloudEdgeManagementRole"/>, <see cref="IotRole"/>, <see cref="KubernetesRole"/> and <see cref="MecRole"/>.
    /// </summary>
    public partial class DataBoxEdgeRoleData : ResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeRoleData. </summary>
        public DataBoxEdgeRoleData()
        {
        }

        /// <summary> Initializes a new instance of DataBoxEdgeRoleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Role type. </param>
        internal DataBoxEdgeRoleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RoleType kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> Role type. </summary>
        internal RoleType Kind { get; set; }
    }
}
