// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TimeAggregationOperator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeAggregationOperator
    {
        [EnumMember(Value = "Average")]
        Average,
        [EnumMember(Value = "Minimum")]
        Minimum,
        [EnumMember(Value = "Maximum")]
        Maximum,
        [EnumMember(Value = "Total")]
        Total,
        [EnumMember(Value = "Last")]
        Last
    }
    internal static class TimeAggregationOperatorEnumExtension
    {
        internal static string ToSerializedValue(this TimeAggregationOperator? value)  =>
            value == null ? null : ((TimeAggregationOperator)value).ToSerializedValue();

        internal static string ToSerializedValue(this TimeAggregationOperator value)
        {
            switch( value )
            {
                case TimeAggregationOperator.Average:
                    return "Average";
                case TimeAggregationOperator.Minimum:
                    return "Minimum";
                case TimeAggregationOperator.Maximum:
                    return "Maximum";
                case TimeAggregationOperator.Total:
                    return "Total";
                case TimeAggregationOperator.Last:
                    return "Last";
            }
            return null;
        }

        internal static TimeAggregationOperator? ParseTimeAggregationOperator(this string value)
        {
            switch( value )
            {
                case "Average":
                    return TimeAggregationOperator.Average;
                case "Minimum":
                    return TimeAggregationOperator.Minimum;
                case "Maximum":
                    return TimeAggregationOperator.Maximum;
                case "Total":
                    return TimeAggregationOperator.Total;
                case "Last":
                    return TimeAggregationOperator.Last;
            }
            return null;
        }
    }
}
