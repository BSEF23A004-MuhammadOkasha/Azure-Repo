// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files. </summary>
    public readonly partial struct SignedResourceTypes : IEquatable<SignedResourceTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SignedResourceTypes"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignedResourceTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SValue = "s";
        private const string CValue = "c";
        private const string OValue = "o";

        /// <summary> s. </summary>
        public static SignedResourceTypes S { get; } = new SignedResourceTypes(SValue);
        /// <summary> c. </summary>
        public static SignedResourceTypes C { get; } = new SignedResourceTypes(CValue);
        /// <summary> o. </summary>
        public static SignedResourceTypes O { get; } = new SignedResourceTypes(OValue);
        /// <summary> Determines if two <see cref="SignedResourceTypes"/> values are the same. </summary>
        public static bool operator ==(SignedResourceTypes left, SignedResourceTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SignedResourceTypes"/> values are not the same. </summary>
        public static bool operator !=(SignedResourceTypes left, SignedResourceTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SignedResourceTypes"/>. </summary>
        public static implicit operator SignedResourceTypes(string value) => new SignedResourceTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SignedResourceTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SignedResourceTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
