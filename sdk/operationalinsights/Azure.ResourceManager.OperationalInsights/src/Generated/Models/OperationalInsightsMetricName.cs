// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The name of a metric. </summary>
    public partial class OperationalInsightsMetricName
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsMetricName"/>. </summary>
        internal OperationalInsightsMetricName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsMetricName"/>. </summary>
        /// <param name="value"> The system name of the metric. </param>
        /// <param name="localizedValue"> The localized name of the metric. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsMetricName(string value, string localizedValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            LocalizedValue = localizedValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The system name of the metric. </summary>
        public string Value { get; }
        /// <summary> The localized name of the metric. </summary>
        public string LocalizedValue { get; }
    }
}
