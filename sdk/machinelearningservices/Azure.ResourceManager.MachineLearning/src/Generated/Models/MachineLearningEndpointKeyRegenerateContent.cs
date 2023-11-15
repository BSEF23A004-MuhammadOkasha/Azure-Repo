// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningEndpointKeyRegenerateContent. </summary>
    public partial class MachineLearningEndpointKeyRegenerateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointKeyRegenerateContent"/>. </summary>
        /// <param name="keyType"> [Required] Specification for which type of key to generate. Primary or Secondary. </param>
        public MachineLearningEndpointKeyRegenerateContent(MachineLearningKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointKeyRegenerateContent"/>. </summary>
        /// <param name="keyType"> [Required] Specification for which type of key to generate. Primary or Secondary. </param>
        /// <param name="keyValue"> The value the key is set to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningEndpointKeyRegenerateContent(MachineLearningKeyType keyType, string keyValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            KeyValue = keyValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointKeyRegenerateContent"/> for deserialization. </summary>
        internal MachineLearningEndpointKeyRegenerateContent()
        {
        }

        /// <summary> [Required] Specification for which type of key to generate. Primary or Secondary. </summary>
        public MachineLearningKeyType KeyType { get; }
        /// <summary> The value the key is set to. </summary>
        public string KeyValue { get; set; }
    }
}
