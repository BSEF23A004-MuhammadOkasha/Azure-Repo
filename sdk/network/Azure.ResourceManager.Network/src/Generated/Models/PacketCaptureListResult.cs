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
    /// <summary> List of packet capture sessions. </summary>
    internal partial class PacketCaptureListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PacketCaptureListResult"/>. </summary>
        internal PacketCaptureListResult()
        {
            Value = new ChangeTrackingList<PacketCaptureData>();
        }

        /// <summary> Initializes a new instance of <see cref="PacketCaptureListResult"/>. </summary>
        /// <param name="value"> Information about packet capture sessions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PacketCaptureListResult(IReadOnlyList<PacketCaptureData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Information about packet capture sessions. </summary>
        public IReadOnlyList<PacketCaptureData> Value { get; }
    }
}
