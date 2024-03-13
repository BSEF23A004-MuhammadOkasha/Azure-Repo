// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> A metric describing the usage of a resource. </summary>
    public partial class OperationalInsightsUsageMetric
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsUsageMetric"/>. </summary>
        internal OperationalInsightsUsageMetric()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsUsageMetric"/>. </summary>
        /// <param name="name"> The name of the metric. </param>
        /// <param name="unit"> The units used for the metric. </param>
        /// <param name="currentValue"> The current value of the metric. </param>
        /// <param name="limit"> The quota limit for the metric. </param>
        /// <param name="nextResetOn"> The time that the metric's value will reset. </param>
        /// <param name="quotaPeriod"> The quota period that determines the length of time between value resets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsUsageMetric(OperationalInsightsMetricName name, string unit, double? currentValue, double? limit, DateTimeOffset? nextResetOn, string quotaPeriod, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetOn = nextResetOn;
            QuotaPeriod = quotaPeriod;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the metric. </summary>
        [WirePath("name")]
        public OperationalInsightsMetricName Name { get; }
        /// <summary> The units used for the metric. </summary>
        [WirePath("unit")]
        public string Unit { get; }
        /// <summary> The current value of the metric. </summary>
        [WirePath("currentValue")]
        public double? CurrentValue { get; }
        /// <summary> The quota limit for the metric. </summary>
        [WirePath("limit")]
        public double? Limit { get; }
        /// <summary> The time that the metric's value will reset. </summary>
        [WirePath("nextResetTime")]
        public DateTimeOffset? NextResetOn { get; }
        /// <summary> The quota period that determines the length of time between value resets. </summary>
        [WirePath("quotaPeriod")]
        public string QuotaPeriod { get; }
    }
}
