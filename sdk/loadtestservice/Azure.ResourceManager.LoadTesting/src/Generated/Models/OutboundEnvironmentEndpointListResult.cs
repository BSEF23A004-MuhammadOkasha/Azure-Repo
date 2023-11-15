// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LoadTesting.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class OutboundEnvironmentEndpointListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpointListResult"/>. </summary>
        internal OutboundEnvironmentEndpointListResult()
        {
            Value = new ChangeTrackingList<LoadTestingOutboundEnvironmentEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpointListResult"/>. </summary>
        /// <param name="value"> The collection of outbound network dependency endpoints returned by the listing operation. </param>
        /// <param name="nextLink"> The continuation token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundEnvironmentEndpointListResult(IReadOnlyList<LoadTestingOutboundEnvironmentEndpoint> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The collection of outbound network dependency endpoints returned by the listing operation. </summary>
        public IReadOnlyList<LoadTestingOutboundEnvironmentEndpoint> Value { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}
