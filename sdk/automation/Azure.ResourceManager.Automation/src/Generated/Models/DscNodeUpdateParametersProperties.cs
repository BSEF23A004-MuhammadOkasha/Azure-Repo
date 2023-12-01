// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The DscNodeUpdateParametersProperties. </summary>
    internal partial class DscNodeUpdateParametersProperties
    {
        /// <summary> Initializes a new instance of <see cref="DscNodeUpdateParametersProperties"/>. </summary>
        public DscNodeUpdateParametersProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DscNodeUpdateParametersProperties"/>. </summary>
        /// <param name="name"> Gets or sets the name of the dsc node configuration. </param>
        internal DscNodeUpdateParametersProperties(string name)
        {
            Name = name;
        }

        /// <summary> Gets or sets the name of the dsc node configuration. </summary>
        public string Name { get; set; }
    }
}
