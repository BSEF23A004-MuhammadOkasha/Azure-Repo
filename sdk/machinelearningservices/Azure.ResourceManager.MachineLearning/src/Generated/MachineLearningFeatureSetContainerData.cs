// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing the MachineLearningFeatureSetContainer data model.
    /// Azure Resource Manager resource envelope.
    /// </summary>
    public partial class MachineLearningFeatureSetContainerData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningFeatureSetContainerData"/>. </summary>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public MachineLearningFeatureSetContainerData(MachineLearningFeatureSetContainerProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFeatureSetContainerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningFeatureSetContainerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MachineLearningFeatureSetContainerProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFeatureSetContainerData"/> for deserialization. </summary>
        internal MachineLearningFeatureSetContainerData()
        {
        }

        /// <summary> [Required] Additional attributes of the entity. </summary>
        public MachineLearningFeatureSetContainerProperties Properties { get; set; }
    }
}
