// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SecurityCenterConnectionType. </summary>
    public readonly partial struct SecurityCenterConnectionType : IEquatable<SecurityCenterConnectionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityCenterConnectionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityCenterConnectionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InternalValue = "Internal";
        private const string ExternalValue = "External";

        /// <summary> Internal. </summary>
        public static SecurityCenterConnectionType Internal { get; } = new SecurityCenterConnectionType(InternalValue);
        /// <summary> External. </summary>
        public static SecurityCenterConnectionType External { get; } = new SecurityCenterConnectionType(ExternalValue);
        /// <summary> Determines if two <see cref="SecurityCenterConnectionType"/> values are the same. </summary>
        public static bool operator ==(SecurityCenterConnectionType left, SecurityCenterConnectionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityCenterConnectionType"/> values are not the same. </summary>
        public static bool operator !=(SecurityCenterConnectionType left, SecurityCenterConnectionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityCenterConnectionType"/>. </summary>
        public static implicit operator SecurityCenterConnectionType(string value) => new SecurityCenterConnectionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityCenterConnectionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityCenterConnectionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
