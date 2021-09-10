// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Different Binding types. </summary>
    public readonly partial struct BindingType : IEquatable<BindingType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="BindingType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BindingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";

        /// <summary> Basic. </summary>
        public static BindingType Basic { get; } = new BindingType(BasicValue);
        /// <summary> Determines if two <see cref="BindingType"/> values are the same. </summary>
        public static bool operator ==(BindingType left, BindingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BindingType"/> values are not the same. </summary>
        public static bool operator !=(BindingType left, BindingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BindingType"/>. </summary>
        public static implicit operator BindingType(string value) => new BindingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BindingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BindingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
