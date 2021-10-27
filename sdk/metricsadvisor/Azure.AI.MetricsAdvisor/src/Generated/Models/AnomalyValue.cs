// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyValue. </summary>
    public readonly partial struct AnomalyValue : IEquatable<AnomalyValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnomalyValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnomalyValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoDetectValue = "AutoDetect";
        private const string AnomalyValue1 = "Anomaly";
        private const string NotAnomalyValue = "NotAnomaly";
        /// <summary> Determines if two <see cref="AnomalyValue"/> values are the same. </summary>
        public static bool operator ==(AnomalyValue left, AnomalyValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnomalyValue"/> values are not the same. </summary>
        public static bool operator !=(AnomalyValue left, AnomalyValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnomalyValue"/>. </summary>
        public static implicit operator AnomalyValue(string value) => new AnomalyValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnomalyValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnomalyValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
