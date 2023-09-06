// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the Get delivery attributes operation. </summary>
    internal partial class DeliveryAttributeListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeliveryAttributeListResult"/>. </summary>
        internal DeliveryAttributeListResult()
        {
            Value = new ChangeTrackingList<DeliveryAttributeMapping>();
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryAttributeListResult"/>. </summary>
        /// <param name="value">
        /// A collection of DeliveryAttributeMapping
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeliveryAttributeListResult(IReadOnlyList<DeliveryAttributeMapping> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary>
        /// A collection of DeliveryAttributeMapping
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </summary>
        public IReadOnlyList<DeliveryAttributeMapping> Value { get; }
    }
}
