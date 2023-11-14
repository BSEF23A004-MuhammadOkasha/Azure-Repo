// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The Capacity Reservation properties. </summary>
    public partial class OperationalInsightsCapacityReservationProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsCapacityReservationProperties"/>. </summary>
        public OperationalInsightsCapacityReservationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsCapacityReservationProperties"/>. </summary>
        /// <param name="lastSkuUpdatedOn"> The last time Sku was updated. </param>
        /// <param name="minCapacity"> Minimum CapacityReservation value in GB. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsCapacityReservationProperties(DateTimeOffset? lastSkuUpdatedOn, long? minCapacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastSkuUpdatedOn = lastSkuUpdatedOn;
            MinCapacity = minCapacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The last time Sku was updated. </summary>
        public DateTimeOffset? LastSkuUpdatedOn { get; }
        /// <summary> Minimum CapacityReservation value in GB. </summary>
        public long? MinCapacity { get; }
    }
}
