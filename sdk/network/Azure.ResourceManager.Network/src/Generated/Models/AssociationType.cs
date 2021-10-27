// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The association type of the child resource to the parent resource. </summary>
    public readonly partial struct AssociationType : IEquatable<AssociationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssociationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssociationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssociatedValue = "Associated";
        private const string ContainsValue = "Contains";

        /// <summary> Associated. </summary>
        public static AssociationType Associated { get; } = new AssociationType(AssociatedValue);
        /// <summary> Contains. </summary>
        public static AssociationType Contains { get; } = new AssociationType(ContainsValue);
        /// <summary> Determines if two <see cref="AssociationType"/> values are the same. </summary>
        public static bool operator ==(AssociationType left, AssociationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssociationType"/> values are not the same. </summary>
        public static bool operator !=(AssociationType left, AssociationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AssociationType"/>. </summary>
        public static implicit operator AssociationType(string value) => new AssociationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssociationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssociationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
