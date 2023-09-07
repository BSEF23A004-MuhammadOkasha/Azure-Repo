// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningFlavorData. </summary>
    public partial class MachineLearningFlavorData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningFlavorData"/>. </summary>
        public MachineLearningFlavorData()
        {
            Data = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFlavorData"/>. </summary>
        /// <param name="data"> Model flavor-specific data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningFlavorData(IDictionary<string, string> data, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Data = data;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Model flavor-specific data. </summary>
        public IDictionary<string, string> Data { get; set; }
    }
}
