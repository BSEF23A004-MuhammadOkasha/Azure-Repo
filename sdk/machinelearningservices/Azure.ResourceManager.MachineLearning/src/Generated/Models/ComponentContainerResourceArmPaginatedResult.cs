// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of ComponentContainer entities. </summary>
    internal partial class ComponentContainerResourceArmPaginatedResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComponentContainerResourceArmPaginatedResult"/>. </summary>
        internal ComponentContainerResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningComponentContainerData>();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentContainerResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of ComponentContainer objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type ComponentContainer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentContainerResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningComponentContainerData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link to the next page of ComponentContainer objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type ComponentContainer. </summary>
        public IReadOnlyList<MachineLearningComponentContainerData> Value { get; }
    }
}
