// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkTableRequestTargetStructureOptions. </summary>
    public partial class LinkTableRequestTargetStructureOptions
    {
        /// <summary> Initializes a new instance of LinkTableRequestTargetStructureOptions. </summary>
        public LinkTableRequestTargetStructureOptions()
        {
        }

        /// <summary> Initializes a new instance of LinkTableRequestTargetStructureOptions. </summary>
        /// <param name="type"> Target table structure type. </param>
        internal LinkTableRequestTargetStructureOptions(string type)
        {
            Type = type;
        }

        /// <summary> Target table structure type. </summary>
        public string Type { get; set; }
    }
}
