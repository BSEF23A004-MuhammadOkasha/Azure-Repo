// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> IoT Security solution analytics severity metrics. </summary>
    public partial class IotSeverityMetrics
    {
        /// <summary> Initializes a new instance of IotSeverityMetrics. </summary>
        internal IotSeverityMetrics()
        {
        }

        /// <summary> Initializes a new instance of IotSeverityMetrics. </summary>
        /// <param name="high"> Count of high severity alerts/recommendations. </param>
        /// <param name="medium"> Count of medium severity alerts/recommendations. </param>
        /// <param name="low"> Count of low severity alerts/recommendations. </param>
        internal IotSeverityMetrics(long? high, long? medium, long? low)
        {
            High = high;
            Medium = medium;
            Low = low;
        }

        /// <summary> Count of high severity alerts/recommendations. </summary>
        public long? High { get; }
        /// <summary> Count of medium severity alerts/recommendations. </summary>
        public long? Medium { get; }
        /// <summary> Count of low severity alerts/recommendations. </summary>
        public long? Low { get; }
    }
}
