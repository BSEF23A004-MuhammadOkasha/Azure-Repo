// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Base definition for identity configuration.
    /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownIdentityConfiguration))]
    public abstract partial class MachineLearningIdentityConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningIdentityConfiguration"/>. </summary>
        protected MachineLearningIdentityConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningIdentityConfiguration"/>. </summary>
        /// <param name="identityType"> [Required] Specifies the type of identity framework. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningIdentityConfiguration(IdentityConfigurationType identityType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IdentityType = identityType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> [Required] Specifies the type of identity framework. </summary>
        internal IdentityConfigurationType IdentityType { get; set; }
    }
}
