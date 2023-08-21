// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    /// <summary> The response of the list configuration profile operation. </summary>
    internal partial class ConfigurationProfileList
    {
        /// <summary> Initializes a new instance of ConfigurationProfileList. </summary>
        internal ConfigurationProfileList()
        {
            Value = new ChangeTrackingList<AutomanageConfigurationProfileData>();
        }

        /// <summary> Initializes a new instance of ConfigurationProfileList. </summary>
        /// <param name="value"> Result of the list ConfigurationProfile operation. </param>
        internal ConfigurationProfileList(IReadOnlyList<AutomanageConfigurationProfileData> value)
        {
            Value = value;
        }

        /// <summary> Result of the list ConfigurationProfile operation. </summary>
        public IReadOnlyList<AutomanageConfigurationProfileData> Value { get; }
    }
}
