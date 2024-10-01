// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'. </summary>
    public readonly partial struct EnabledState : IEquatable<EnabledState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnabledState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnabledState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static EnabledState Enabled { get; } = new EnabledState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static EnabledState Disabled { get; } = new EnabledState(DisabledValue);
        /// <summary> Determines if two <see cref="EnabledState"/> values are the same. </summary>
        public static bool operator ==(EnabledState left, EnabledState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnabledState"/> values are not the same. </summary>
        public static bool operator !=(EnabledState left, EnabledState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EnabledState"/>. </summary>
        public static implicit operator EnabledState(string value) => new EnabledState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnabledState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnabledState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
