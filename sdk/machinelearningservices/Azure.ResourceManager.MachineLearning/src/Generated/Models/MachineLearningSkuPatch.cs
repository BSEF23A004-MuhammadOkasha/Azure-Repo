// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Common SKU definition. </summary>
    public partial class MachineLearningSkuPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningSkuPatch"/>. </summary>
        public MachineLearningSkuPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSkuPatch"/>. </summary>
        /// <param name="capacity"> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <param name="size"> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningSkuPatch(int? capacity, string family, string name, string size, MachineLearningSkuTier? tier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Capacity = capacity;
            Family = family;
            Name = name;
            Size = size;
            Tier = tier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </summary>
        public int? Capacity { get; set; }
        /// <summary> If the service has different generations of hardware, for the same SKU, then that can be captured here. </summary>
        public string Family { get; set; }
        /// <summary> The name of the SKU. Ex - P3. It is typically a letter+number code. </summary>
        public string Name { get; set; }
        /// <summary> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </summary>
        public string Size { get; set; }
        /// <summary> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </summary>
        public MachineLearningSkuTier? Tier { get; set; }
    }
}
