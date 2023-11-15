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
    /// <summary> Paginated list of Machine Learning compute objects wrapped in ARM resource envelope. </summary>
    internal partial class PaginatedComputeResourcesList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PaginatedComputeResourcesList"/>. </summary>
        internal PaginatedComputeResourcesList()
        {
            Value = new ChangeTrackingList<MachineLearningComputeData>();
        }

        /// <summary> Initializes a new instance of <see cref="PaginatedComputeResourcesList"/>. </summary>
        /// <param name="value"> An array of Machine Learning compute objects wrapped in ARM resource envelope. </param>
        /// <param name="nextLink"> A continuation link (absolute URI) to the next page of results in the list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PaginatedComputeResourcesList(IReadOnlyList<MachineLearningComputeData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of Machine Learning compute objects wrapped in ARM resource envelope. </summary>
        public IReadOnlyList<MachineLearningComputeData> Value { get; }
        /// <summary> A continuation link (absolute URI) to the next page of results in the list. </summary>
        public string NextLink { get; }
    }
}
