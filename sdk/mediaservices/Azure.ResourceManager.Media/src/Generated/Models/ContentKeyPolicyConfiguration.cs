// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for Content Key Policy configuration. A derived class must be used to create a configuration.
    /// Please note <see cref="ContentKeyPolicyConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContentKeyPolicyClearKeyConfiguration"/>, <see cref="ContentKeyPolicyFairPlayConfiguration"/>, <see cref="ContentKeyPolicyPlayReadyConfiguration"/>, <see cref="ContentKeyPolicyUnknownConfiguration"/> and <see cref="ContentKeyPolicyWidevineConfiguration"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownContentKeyPolicyConfiguration))]
    public abstract partial class ContentKeyPolicyConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyConfiguration"/>. </summary>
        protected ContentKeyPolicyConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyConfiguration"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentKeyPolicyConfiguration(string odataType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
