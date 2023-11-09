// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains stats associated with the peering. </summary>
    public partial class ExpressRouteCircuitStats
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitStats"/>. </summary>
        public ExpressRouteCircuitStats()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitStats"/>. </summary>
        /// <param name="primarybytesIn"> The Primary BytesIn of the peering. </param>
        /// <param name="primarybytesOut"> The primary BytesOut of the peering. </param>
        /// <param name="secondarybytesIn"> The secondary BytesIn of the peering. </param>
        /// <param name="secondarybytesOut"> The secondary BytesOut of the peering. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteCircuitStats(long? primarybytesIn, long? primarybytesOut, long? secondarybytesIn, long? secondarybytesOut, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimarybytesIn = primarybytesIn;
            PrimarybytesOut = primarybytesOut;
            SecondarybytesIn = secondarybytesIn;
            SecondarybytesOut = secondarybytesOut;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Primary BytesIn of the peering. </summary>
        public long? PrimarybytesIn { get; set; }
        /// <summary> The primary BytesOut of the peering. </summary>
        public long? PrimarybytesOut { get; set; }
        /// <summary> The secondary BytesIn of the peering. </summary>
        public long? SecondarybytesIn { get; set; }
        /// <summary> The secondary BytesOut of the peering. </summary>
        public long? SecondarybytesOut { get; set; }
    }
}
