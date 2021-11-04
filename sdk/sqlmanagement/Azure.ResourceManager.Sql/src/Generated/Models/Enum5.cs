// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The Enum5. </summary>
    public readonly partial struct Enum5 : IEquatable<Enum5>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum5"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum5(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static Enum5 Default { get; } = new Enum5(DefaultValue);
        /// <summary> Determines if two <see cref="Enum5"/> values are the same. </summary>
        public static bool operator ==(Enum5 left, Enum5 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum5"/> values are not the same. </summary>
        public static bool operator !=(Enum5 left, Enum5 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum5"/>. </summary>
        public static implicit operator Enum5(string value) => new Enum5(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum5 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum5 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
