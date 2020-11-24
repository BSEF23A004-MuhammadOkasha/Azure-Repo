// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> Defines the level of severity for the event. </summary>
    internal readonly partial struct SeverityLevel : IEquatable<SeverityLevel>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SeverityLevel"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SeverityLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VerboseValue = "Verbose";
        private const string InformationValue = "Information";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string CriticalValue = "Critical";

        /// <summary> Verbose. </summary>
        public static SeverityLevel Verbose { get; } = new SeverityLevel(VerboseValue);
        /// <summary> Information. </summary>
        public static SeverityLevel Information { get; } = new SeverityLevel(InformationValue);
        /// <summary> Warning. </summary>
        public static SeverityLevel Warning { get; } = new SeverityLevel(WarningValue);
        /// <summary> Error. </summary>
        public static SeverityLevel Error { get; } = new SeverityLevel(ErrorValue);
        /// <summary> Critical. </summary>
        public static SeverityLevel Critical { get; } = new SeverityLevel(CriticalValue);
        /// <summary> Determines if two <see cref="SeverityLevel"/> values are the same. </summary>
        public static bool operator ==(SeverityLevel left, SeverityLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SeverityLevel"/> values are not the same. </summary>
        public static bool operator !=(SeverityLevel left, SeverityLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SeverityLevel"/>. </summary>
        public static implicit operator SeverityLevel(string value) => new SeverityLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SeverityLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SeverityLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
