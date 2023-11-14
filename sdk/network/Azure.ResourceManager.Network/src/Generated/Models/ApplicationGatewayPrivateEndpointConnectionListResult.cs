// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListApplicationGatewayPrivateEndpointConnection API service call. Gets all private endpoint connections for an application gateway. </summary>
    internal partial class ApplicationGatewayPrivateEndpointConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayPrivateEndpointConnectionListResult"/>. </summary>
        internal ApplicationGatewayPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<ApplicationGatewayPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> List of private endpoint connections on an application gateway. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayPrivateEndpointConnectionListResult(IReadOnlyList<ApplicationGatewayPrivateEndpointConnectionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of private endpoint connections on an application gateway. </summary>
        public IReadOnlyList<ApplicationGatewayPrivateEndpointConnectionData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
