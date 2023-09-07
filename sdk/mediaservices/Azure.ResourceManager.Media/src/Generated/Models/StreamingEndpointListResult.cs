// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The streaming endpoint list result. </summary>
    internal partial class StreamingEndpointListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointListResult"/>. </summary>
        internal StreamingEndpointListResult()
        {
            Value = new ChangeTrackingList<StreamingEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointListResult"/>. </summary>
        /// <param name="value"> The result of the List StreamingEndpoint operation. </param>
        /// <param name="odataCount"> The number of result. </param>
        /// <param name="odataNextLink"> The link to the next set of results. Not empty if value contains incomplete list of streaming endpoints. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingEndpointListResult(IReadOnlyList<StreamingEndpointData> value, int? odataCount, string odataNextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            OdataCount = odataCount;
            OdataNextLink = odataNextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The result of the List StreamingEndpoint operation. </summary>
        public IReadOnlyList<StreamingEndpointData> Value { get; }
        /// <summary> The number of result. </summary>
        public int? OdataCount { get; }
        /// <summary> The link to the next set of results. Not empty if value contains incomplete list of streaming endpoints. </summary>
        public string OdataNextLink { get; }
    }
}
