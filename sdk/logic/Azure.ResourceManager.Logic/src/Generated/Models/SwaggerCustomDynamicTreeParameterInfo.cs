// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger custom dynamic tree parameter. </summary>
    public partial class SwaggerCustomDynamicTreeParameterInfo
    {
        /// <summary> Initializes a new instance of SwaggerCustomDynamicTreeParameterInfo. </summary>
        public SwaggerCustomDynamicTreeParameterInfo()
        {
        }

        /// <summary> Initializes a new instance of SwaggerCustomDynamicTreeParameterInfo. </summary>
        /// <param name="selectedItemValuePath"> Gets or sets a path to a property in the currently selected item to pass as a value to a parameter for the given operation. </param>
        /// <param name="value"> The parameter value. </param>
        /// <param name="parameterReference"> The parameter reference. </param>
        /// <param name="required"> Indicates whether the parameter is required. </param>
        internal SwaggerCustomDynamicTreeParameterInfo(string selectedItemValuePath, BinaryData value, string parameterReference, bool? required)
        {
            SelectedItemValuePath = selectedItemValuePath;
            Value = value;
            ParameterReference = parameterReference;
            Required = required;
        }

        /// <summary> Gets or sets a path to a property in the currently selected item to pass as a value to a parameter for the given operation. </summary>
        public string SelectedItemValuePath { get; set; }
        /// <summary> The parameter value. </summary>
        public BinaryData Value { get; set; }
        /// <summary> The parameter reference. </summary>
        public string ParameterReference { get; set; }
        /// <summary> Indicates whether the parameter is required. </summary>
        public bool? Required { get; set; }
    }
}
