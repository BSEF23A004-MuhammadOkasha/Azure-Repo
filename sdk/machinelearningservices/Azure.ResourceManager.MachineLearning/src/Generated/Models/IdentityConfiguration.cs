// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Base definition for identity configuration.
    /// Please note <see cref="IdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AmlToken"/>, <see cref="ManagedIdentity"/> and <see cref="UserIdentity"/>.
    /// </summary>
    public abstract partial class IdentityConfiguration
    {
        /// <summary> Initializes a new instance of IdentityConfiguration. </summary>
        protected IdentityConfiguration()
        {
        }

        /// <summary> Initializes a new instance of IdentityConfiguration. </summary>
        /// <param name="identityType"> [Required] Specifies the type of identity framework. </param>
        internal IdentityConfiguration(IdentityConfigurationType identityType)
        {
            IdentityType = identityType;
        }

        /// <summary> [Required] Specifies the type of identity framework. </summary>
        internal IdentityConfigurationType IdentityType { get; set; }
    }
}
