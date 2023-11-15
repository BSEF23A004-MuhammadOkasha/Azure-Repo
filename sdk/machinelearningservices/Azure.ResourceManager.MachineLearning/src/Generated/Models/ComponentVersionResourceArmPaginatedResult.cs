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
    /// <summary> A paginated list of ComponentVersion entities. </summary>
    internal partial class ComponentVersionResourceArmPaginatedResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComponentVersionResourceArmPaginatedResult"/>. </summary>
        internal ComponentVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningComponentVersionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentVersionResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of ComponentVersion objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type ComponentVersion. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentVersionResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningComponentVersionData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link to the next page of ComponentVersion objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type ComponentVersion. </summary>
        public IReadOnlyList<MachineLearningComponentVersionData> Value { get; }
    }
}
