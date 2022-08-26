// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The version of the source control. </summary>
    public readonly partial struct Version : IEquatable<Version>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Version"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Version(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string V1Value = "V1";
        private const string V2Value = "V2";

        /// <summary> V1. </summary>
        public static Version V1 { get; } = new Version(V1Value);
        /// <summary> V2. </summary>
        public static Version V2 { get; } = new Version(V2Value);
        /// <summary> Determines if two <see cref="Version"/> values are the same. </summary>
        public static bool operator ==(Version left, Version right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Version"/> values are not the same. </summary>
        public static bool operator !=(Version left, Version right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Version"/>. </summary>
        public static implicit operator Version(string value) => new Version(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Version other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Version other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
