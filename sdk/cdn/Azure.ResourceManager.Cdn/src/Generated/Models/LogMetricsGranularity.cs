// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The LogMetricsGranularity. </summary>
    public readonly partial struct LogMetricsGranularity : IEquatable<LogMetricsGranularity>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LogMetricsGranularity"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogMetricsGranularity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PT5MValue = "PT5M";
        private const string PT1HValue = "PT1H";
        private const string P1DValue = "P1D";

        /// <summary> PT5M. </summary>
        public static LogMetricsGranularity PT5M { get; } = new LogMetricsGranularity(PT5MValue);
        /// <summary> PT1H. </summary>
        public static LogMetricsGranularity PT1H { get; } = new LogMetricsGranularity(PT1HValue);
        /// <summary> P1D. </summary>
        public static LogMetricsGranularity P1D { get; } = new LogMetricsGranularity(P1DValue);
        /// <summary> Determines if two <see cref="LogMetricsGranularity"/> values are the same. </summary>
        public static bool operator ==(LogMetricsGranularity left, LogMetricsGranularity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogMetricsGranularity"/> values are not the same. </summary>
        public static bool operator !=(LogMetricsGranularity left, LogMetricsGranularity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogMetricsGranularity"/>. </summary>
        public static implicit operator LogMetricsGranularity(string value) => new LogMetricsGranularity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogMetricsGranularity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogMetricsGranularity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
