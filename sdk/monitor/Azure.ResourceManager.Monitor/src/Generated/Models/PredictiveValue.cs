// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Represents a predictive metric value in the given bucket. </summary>
    public partial class PredictiveValue
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PredictiveValue"/>. </summary>
        /// <param name="timeStamp"> the timestamp for the metric value in ISO 8601 format. </param>
        /// <param name="value"> Predictive value in this time bucket. </param>
        internal PredictiveValue(DateTimeOffset timeStamp, double value)
        {
            TimeStamp = timeStamp;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="PredictiveValue"/>. </summary>
        /// <param name="timeStamp"> the timestamp for the metric value in ISO 8601 format. </param>
        /// <param name="value"> Predictive value in this time bucket. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PredictiveValue(DateTimeOffset timeStamp, double value, Dictionary<string, BinaryData> rawData)
        {
            TimeStamp = timeStamp;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PredictiveValue"/> for deserialization. </summary>
        internal PredictiveValue()
        {
        }

        /// <summary> the timestamp for the metric value in ISO 8601 format. </summary>
        public DateTimeOffset TimeStamp { get; }
        /// <summary> Predictive value in this time bucket. </summary>
        public double Value { get; }
    }
}
