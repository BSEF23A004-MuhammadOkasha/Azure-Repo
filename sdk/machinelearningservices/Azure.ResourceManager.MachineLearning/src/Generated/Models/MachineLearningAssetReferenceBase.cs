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
    /// Base definition for asset references.
    /// Please note <see cref="MachineLearningAssetReferenceBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MachineLearningDataPathAssetReference"/>, <see cref="MachineLearningIdAssetReference"/> and <see cref="MachineLearningOutputPathAssetReference"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownAssetReferenceBase))]
    public abstract partial class MachineLearningAssetReferenceBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningAssetReferenceBase"/>. </summary>
        protected MachineLearningAssetReferenceBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAssetReferenceBase"/>. </summary>
        /// <param name="referenceType"> [Required] Specifies the type of asset reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningAssetReferenceBase(ReferenceType referenceType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReferenceType = referenceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> [Required] Specifies the type of asset reference. </summary>
        internal ReferenceType ReferenceType { get; set; }
    }
}
