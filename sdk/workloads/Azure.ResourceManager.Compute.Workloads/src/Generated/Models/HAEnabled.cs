// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> Whether to enable HA for the server. </summary>
    public readonly partial struct HAEnabled : IEquatable<HAEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HAEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HAEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static HAEnabled Enabled { get; } = new HAEnabled(EnabledValue);
        /// <summary> Disabled. </summary>
        public static HAEnabled Disabled { get; } = new HAEnabled(DisabledValue);
        /// <summary> Determines if two <see cref="HAEnabled"/> values are the same. </summary>
        public static bool operator ==(HAEnabled left, HAEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HAEnabled"/> values are not the same. </summary>
        public static bool operator !=(HAEnabled left, HAEnabled right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HAEnabled"/>. </summary>
        public static implicit operator HAEnabled(string value) => new HAEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HAEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HAEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
