// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Track property type. </summary>
    public readonly partial struct TrackPropertyType : IEquatable<TrackPropertyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrackPropertyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrackPropertyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string FourCCValue = "FourCC";

        /// <summary> Unknown track property. </summary>
        public static TrackPropertyType Unknown { get; } = new TrackPropertyType(UnknownValue);
        /// <summary> Track FourCC. </summary>
        public static TrackPropertyType FourCC { get; } = new TrackPropertyType(FourCCValue);
        /// <summary> Determines if two <see cref="TrackPropertyType"/> values are the same. </summary>
        public static bool operator ==(TrackPropertyType left, TrackPropertyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrackPropertyType"/> values are not the same. </summary>
        public static bool operator !=(TrackPropertyType left, TrackPropertyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TrackPropertyType"/>. </summary>
        public static implicit operator TrackPropertyType(string value) => new TrackPropertyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrackPropertyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrackPropertyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
