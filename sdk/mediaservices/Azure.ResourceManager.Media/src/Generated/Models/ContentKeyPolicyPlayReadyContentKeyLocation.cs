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
    /// Base class for content key ID location. A derived class must be used to represent the location.
    /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownContentKeyPolicyPlayReadyContentKeyLocation))]
    public abstract partial class ContentKeyPolicyPlayReadyContentKeyLocation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/>. </summary>
        protected ContentKeyPolicyPlayReadyContentKeyLocation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentKeyPolicyPlayReadyContentKeyLocation(string odataType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
