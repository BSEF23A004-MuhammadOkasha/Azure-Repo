// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Binding Inputs/Outputs to ComponentJob Inputs/Outputs etc. </summary>
    public partial class Binding
    {
        /// <summary> Initializes a new instance of Binding. </summary>
        public Binding()
        {
        }

        /// <summary> Initializes a new instance of Binding. </summary>
        /// <param name="bindingType"> Type of Binding. </param>
        internal Binding(BindingType bindingType)
        {
            BindingType = bindingType;
        }

        /// <summary> Type of Binding. </summary>
        internal BindingType BindingType { get; set; }
    }
}
