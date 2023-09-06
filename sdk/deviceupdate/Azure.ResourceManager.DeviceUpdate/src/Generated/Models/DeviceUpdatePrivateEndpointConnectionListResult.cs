// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> List of private endpoint connection associated with the specified storage account. </summary>
    internal partial class DeviceUpdatePrivateEndpointConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateEndpointConnectionListResult"/>. </summary>
        internal DeviceUpdatePrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<DeviceUpdatePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceUpdatePrivateEndpointConnectionListResult(IReadOnlyList<DeviceUpdatePrivateEndpointConnectionData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<DeviceUpdatePrivateEndpointConnectionData> Value { get; }
    }
}
