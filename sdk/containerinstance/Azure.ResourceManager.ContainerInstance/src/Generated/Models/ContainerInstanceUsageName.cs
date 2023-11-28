// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The name object of the resource. </summary>
    public partial class ContainerInstanceUsageName
    {
        /// <summary> Initializes a new instance of <see cref="ContainerInstanceUsageName"/>. </summary>
        internal ContainerInstanceUsageName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceUsageName"/>. </summary>
        /// <param name="value"> The name of the resource. </param>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        internal ContainerInstanceUsageName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> The name of the resource. </summary>
        public string Value { get; }
        /// <summary> The localized name of the resource. </summary>
        public string LocalizedValue { get; }
    }
}
