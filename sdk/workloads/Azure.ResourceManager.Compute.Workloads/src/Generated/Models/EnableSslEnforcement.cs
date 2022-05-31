// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> Whether to enable SSL enforcement on the database. </summary>
    public readonly partial struct EnableSslEnforcement : IEquatable<EnableSslEnforcement>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnableSslEnforcement"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnableSslEnforcement(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static EnableSslEnforcement Enabled { get; } = new EnableSslEnforcement(EnabledValue);
        /// <summary> Disabled. </summary>
        public static EnableSslEnforcement Disabled { get; } = new EnableSslEnforcement(DisabledValue);
        /// <summary> Determines if two <see cref="EnableSslEnforcement"/> values are the same. </summary>
        public static bool operator ==(EnableSslEnforcement left, EnableSslEnforcement right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnableSslEnforcement"/> values are not the same. </summary>
        public static bool operator !=(EnableSslEnforcement left, EnableSslEnforcement right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnableSslEnforcement"/>. </summary>
        public static implicit operator EnableSslEnforcement(string value) => new EnableSslEnforcement(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnableSslEnforcement other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnableSslEnforcement other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
