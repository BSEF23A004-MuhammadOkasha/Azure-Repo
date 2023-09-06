// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Metadata information for the properties JSON document. </summary>
    public partial class DeviceTwinMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceTwinMetadata"/>. </summary>
        internal DeviceTwinMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceTwinMetadata"/>. </summary>
        /// <param name="lastUpdated"> The ISO8601 timestamp of the last time the properties were updated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceTwinMetadata(string lastUpdated, Dictionary<string, BinaryData> rawData)
        {
            LastUpdated = lastUpdated;
            _rawData = rawData;
        }

        /// <summary> The ISO8601 timestamp of the last time the properties were updated. </summary>
        public string LastUpdated { get; }
    }
}
