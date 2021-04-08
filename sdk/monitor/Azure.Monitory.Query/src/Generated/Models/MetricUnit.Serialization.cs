// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitory.Query
{
    internal static partial class MetricUnitExtensions
    {
        public static string ToSerialString(this MetricUnit value) => value switch
        {
            MetricUnit.Count => "Count",
            MetricUnit.Bytes => "Bytes",
            MetricUnit.Seconds => "Seconds",
            MetricUnit.CountPerSecond => "CountPerSecond",
            MetricUnit.BytesPerSecond => "BytesPerSecond",
            MetricUnit.Percent => "Percent",
            MetricUnit.MilliSeconds => "MilliSeconds",
            MetricUnit.ByteSeconds => "ByteSeconds",
            MetricUnit.Unspecified => "Unspecified",
            MetricUnit.Cores => "Cores",
            MetricUnit.MilliCores => "MilliCores",
            MetricUnit.NanoCores => "NanoCores",
            MetricUnit.BitsPerSecond => "BitsPerSecond",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricUnit value.")
        };

        public static MetricUnit ToMetricUnit(this string value)
        {
            if (string.Equals(value, "Count", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.Count;
            if (string.Equals(value, "Bytes", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.Bytes;
            if (string.Equals(value, "Seconds", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.Seconds;
            if (string.Equals(value, "CountPerSecond", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.CountPerSecond;
            if (string.Equals(value, "BytesPerSecond", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.BytesPerSecond;
            if (string.Equals(value, "Percent", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.Percent;
            if (string.Equals(value, "MilliSeconds", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.MilliSeconds;
            if (string.Equals(value, "ByteSeconds", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.ByteSeconds;
            if (string.Equals(value, "Unspecified", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.Unspecified;
            if (string.Equals(value, "Cores", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.Cores;
            if (string.Equals(value, "MilliCores", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.MilliCores;
            if (string.Equals(value, "NanoCores", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.NanoCores;
            if (string.Equals(value, "BitsPerSecond", StringComparison.InvariantCultureIgnoreCase)) return MetricUnit.BitsPerSecond;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricUnit value.");
        }
    }
}
