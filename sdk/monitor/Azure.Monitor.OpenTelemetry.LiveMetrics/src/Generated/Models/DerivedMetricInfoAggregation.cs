// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Aggregation type. </summary>
    public readonly partial struct DerivedMetricInfoAggregation : IEquatable<DerivedMetricInfoAggregation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DerivedMetricInfoAggregation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DerivedMetricInfoAggregation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvgValue = "Avg";
        private const string SumValue = "Sum";
        private const string MinValue = "Min";
        private const string MaxValue = "Max";

        /// <summary> Avg. </summary>
        public static DerivedMetricInfoAggregation Avg { get; } = new DerivedMetricInfoAggregation(AvgValue);
        /// <summary> Sum. </summary>
        public static DerivedMetricInfoAggregation Sum { get; } = new DerivedMetricInfoAggregation(SumValue);
        /// <summary> Min. </summary>
        public static DerivedMetricInfoAggregation Min { get; } = new DerivedMetricInfoAggregation(MinValue);
        /// <summary> Max. </summary>
        public static DerivedMetricInfoAggregation Max { get; } = new DerivedMetricInfoAggregation(MaxValue);
        /// <summary> Determines if two <see cref="DerivedMetricInfoAggregation"/> values are the same. </summary>
        public static bool operator ==(DerivedMetricInfoAggregation left, DerivedMetricInfoAggregation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DerivedMetricInfoAggregation"/> values are not the same. </summary>
        public static bool operator !=(DerivedMetricInfoAggregation left, DerivedMetricInfoAggregation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DerivedMetricInfoAggregation"/>. </summary>
        public static implicit operator DerivedMetricInfoAggregation(string value) => new DerivedMetricInfoAggregation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DerivedMetricInfoAggregation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DerivedMetricInfoAggregation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
