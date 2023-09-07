// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of NetworkDevices. </summary>
    internal partial class NetworkDevicesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkDevicesListResult"/>. </summary>
        internal NetworkDevicesListResult()
        {
            Value = new ChangeTrackingList<NetworkDeviceData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkDevicesListResult"/>. </summary>
        /// <param name="value"> List of NetworkDevice resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkDevicesListResult(IReadOnlyList<NetworkDeviceData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of NetworkDevice resources. </summary>
        public IReadOnlyList<NetworkDeviceData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
