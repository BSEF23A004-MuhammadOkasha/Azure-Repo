// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Definition of a component version: defines resources that span component types. </summary>
    public partial class ComponentVersion : AssetBase
    {
        /// <summary> Initializes a new instance of ComponentVersion. </summary>
        public ComponentVersion()
        {
        }

        /// <summary> Initializes a new instance of ComponentVersion. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="componentSpec"> Defines Component definition details. </param>
        internal ComponentVersion(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isAnonymous, object componentSpec) : base(description, properties, tags, isAnonymous)
        {
            ComponentSpec = componentSpec;
        }

        /// <summary> Defines Component definition details. </summary>
        public object ComponentSpec { get; set; }
    }
}
