// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Whether the operation refers to the primary or secondary key. </summary>
    public readonly partial struct MapsKeyType : IEquatable<MapsKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapsKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapsKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "primary";
        private const string SecondaryValue = "secondary";

        /// <summary> primary. </summary>
        public static MapsKeyType Primary { get; } = new MapsKeyType(PrimaryValue);
        /// <summary> secondary. </summary>
        public static MapsKeyType Secondary { get; } = new MapsKeyType(SecondaryValue);
        /// <summary> Determines if two <see cref="MapsKeyType"/> values are the same. </summary>
        public static bool operator ==(MapsKeyType left, MapsKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapsKeyType"/> values are not the same. </summary>
        public static bool operator !=(MapsKeyType left, MapsKeyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MapsKeyType"/>. </summary>
        public static implicit operator MapsKeyType(string value) => new MapsKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapsKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapsKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
