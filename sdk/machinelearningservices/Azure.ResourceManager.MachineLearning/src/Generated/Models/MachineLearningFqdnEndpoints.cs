// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningFqdnEndpoints. </summary>
    public partial class MachineLearningFqdnEndpoints
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningFqdnEndpoints"/>. </summary>
        internal MachineLearningFqdnEndpoints()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFqdnEndpoints"/>. </summary>
        /// <param name="properties"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningFqdnEndpoints(MachineLearningFqdnEndpointsProperties properties, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the properties. </summary>
        public MachineLearningFqdnEndpointsProperties Properties { get; }
    }
}
