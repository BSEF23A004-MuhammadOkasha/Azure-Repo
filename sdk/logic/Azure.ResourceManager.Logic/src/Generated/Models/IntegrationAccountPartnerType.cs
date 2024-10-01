// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The partner type. </summary>
    public readonly partial struct IntegrationAccountPartnerType : IEquatable<IntegrationAccountPartnerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountPartnerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationAccountPartnerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string B2BValue = "B2B";

        /// <summary> NotSpecified. </summary>
        public static IntegrationAccountPartnerType NotSpecified { get; } = new IntegrationAccountPartnerType(NotSpecifiedValue);
        /// <summary> B2B. </summary>
        public static IntegrationAccountPartnerType B2B { get; } = new IntegrationAccountPartnerType(B2BValue);
        /// <summary> Determines if two <see cref="IntegrationAccountPartnerType"/> values are the same. </summary>
        public static bool operator ==(IntegrationAccountPartnerType left, IntegrationAccountPartnerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationAccountPartnerType"/> values are not the same. </summary>
        public static bool operator !=(IntegrationAccountPartnerType left, IntegrationAccountPartnerType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IntegrationAccountPartnerType"/>. </summary>
        public static implicit operator IntegrationAccountPartnerType(string value) => new IntegrationAccountPartnerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationAccountPartnerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationAccountPartnerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
