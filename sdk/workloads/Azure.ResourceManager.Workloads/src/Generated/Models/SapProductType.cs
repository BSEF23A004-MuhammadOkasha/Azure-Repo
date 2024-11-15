// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the SAP Product type. </summary>
    public readonly partial struct SapProductType : IEquatable<SapProductType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapProductType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapProductType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EccValue = "ECC";
        private const string S4HanaValue = "S4HANA";
        private const string OtherValue = "Other";

        /// <summary> ECC. </summary>
        public static SapProductType Ecc { get; } = new SapProductType(EccValue);
        /// <summary> S4HANA. </summary>
        public static SapProductType S4Hana { get; } = new SapProductType(S4HanaValue);
        /// <summary> Other. </summary>
        public static SapProductType Other { get; } = new SapProductType(OtherValue);
        /// <summary> Determines if two <see cref="SapProductType"/> values are the same. </summary>
        public static bool operator ==(SapProductType left, SapProductType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapProductType"/> values are not the same. </summary>
        public static bool operator !=(SapProductType left, SapProductType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SapProductType"/>. </summary>
        public static implicit operator SapProductType(string value) => new SapProductType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapProductType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapProductType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
