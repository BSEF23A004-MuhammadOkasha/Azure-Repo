// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> HA mode supported for a server. </summary>
    public readonly partial struct PostgreSqlFlexibleServerHAMode : IEquatable<PostgreSqlFlexibleServerHAMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerHAMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerHAMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SameZoneValue = "SameZone";
        private const string ZoneRedundantValue = "ZoneRedundant";

        /// <summary> SameZone. </summary>
        public static PostgreSqlFlexibleServerHAMode SameZone { get; } = new PostgreSqlFlexibleServerHAMode(SameZoneValue);
        /// <summary> ZoneRedundant. </summary>
        public static PostgreSqlFlexibleServerHAMode ZoneRedundant { get; } = new PostgreSqlFlexibleServerHAMode(ZoneRedundantValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerHAMode"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerHAMode left, PostgreSqlFlexibleServerHAMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerHAMode"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerHAMode left, PostgreSqlFlexibleServerHAMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerHAMode"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerHAMode(string value) => new PostgreSqlFlexibleServerHAMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerHAMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerHAMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
