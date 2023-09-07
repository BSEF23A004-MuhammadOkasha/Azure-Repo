// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> IoT Hub capacity information. </summary>
    public partial class IotHubCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubCapacity"/>. </summary>
        internal IotHubCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotHubCapacity"/>. </summary>
        /// <param name="minimum"> The minimum number of units. </param>
        /// <param name="maximum"> The maximum number of units. </param>
        /// <param name="default"> The default number of units. </param>
        /// <param name="scaleType"> The type of the scaling enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubCapacity(long? minimum, long? maximum, long? @default, IotHubScaleType? scaleType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The minimum number of units. </summary>
        public long? Minimum { get; }
        /// <summary> The maximum number of units. </summary>
        public long? Maximum { get; }
        /// <summary> The default number of units. </summary>
        public long? Default { get; }
        /// <summary> The type of the scaling enabled. </summary>
        public IotHubScaleType? ScaleType { get; }
    }
}
