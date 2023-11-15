// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The StreamingEndpointSkuInfoListResult. </summary>
    internal partial class StreamingEndpointSkuInfoListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointSkuInfoListResult"/>. </summary>
        internal StreamingEndpointSkuInfoListResult()
        {
            Value = new ChangeTrackingList<StreamingEndpointSkuInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointSkuInfoListResult"/>. </summary>
        /// <param name="value"> The result of the List StreamingEndpoint skus. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingEndpointSkuInfoListResult(IReadOnlyList<StreamingEndpointSkuInfo> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The result of the List StreamingEndpoint skus. </summary>
        public IReadOnlyList<StreamingEndpointSkuInfo> Value { get; }
    }
}
