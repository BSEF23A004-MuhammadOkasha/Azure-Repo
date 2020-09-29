// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> time mode to filter feedback. </summary>
    internal readonly partial struct FeedbackQueryTimeMode : IEquatable<FeedbackQueryTimeMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FeedbackQueryTimeMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FeedbackQueryTimeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MetricTimestampValue = "MetricTimestamp";
        private const string FeedbackCreatedTimeValue = "FeedbackCreatedTime";

        /// <summary> MetricTimestamp. </summary>
        public static FeedbackQueryTimeMode MetricTimestamp { get; } = new FeedbackQueryTimeMode(MetricTimestampValue);
        /// <summary> FeedbackCreatedTime. </summary>
        public static FeedbackQueryTimeMode FeedbackCreatedTime { get; } = new FeedbackQueryTimeMode(FeedbackCreatedTimeValue);
        /// <summary> Determines if two <see cref="FeedbackQueryTimeMode"/> values are the same. </summary>
        public static bool operator ==(FeedbackQueryTimeMode left, FeedbackQueryTimeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FeedbackQueryTimeMode"/> values are not the same. </summary>
        public static bool operator !=(FeedbackQueryTimeMode left, FeedbackQueryTimeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FeedbackQueryTimeMode"/>. </summary>
        public static implicit operator FeedbackQueryTimeMode(string value) => new FeedbackQueryTimeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FeedbackQueryTimeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FeedbackQueryTimeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
