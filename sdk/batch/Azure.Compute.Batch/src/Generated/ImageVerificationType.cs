// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> ImageVerificationType enums. </summary>
    public readonly partial struct ImageVerificationType : IEquatable<ImageVerificationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageVerificationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageVerificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VerifiedValue = "verified";
        private const string UnverifiedValue = "unverified";

        /// <summary> The Image is guaranteed to be compatible with the associated Compute Node agent SKU and all Batch features have been confirmed to work as expected. </summary>
        public static ImageVerificationType Verified { get; } = new ImageVerificationType(VerifiedValue);
        /// <summary> The associated Compute Node agent SKU should have binary compatibility with the Image, but specific functionality has not been verified. </summary>
        public static ImageVerificationType Unverified { get; } = new ImageVerificationType(UnverifiedValue);
        /// <summary> Determines if two <see cref="ImageVerificationType"/> values are the same. </summary>
        public static bool operator ==(ImageVerificationType left, ImageVerificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageVerificationType"/> values are not the same. </summary>
        public static bool operator !=(ImageVerificationType left, ImageVerificationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ImageVerificationType"/>. </summary>
        public static implicit operator ImageVerificationType(string value) => new ImageVerificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageVerificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageVerificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
