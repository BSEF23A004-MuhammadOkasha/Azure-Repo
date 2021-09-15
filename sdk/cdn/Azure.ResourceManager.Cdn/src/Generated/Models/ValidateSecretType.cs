// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The secret type. </summary>
    public readonly partial struct ValidateSecretType : IEquatable<ValidateSecretType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ValidateSecretType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ValidateSecretType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UrlSigningKeyValue = "UrlSigningKey";
        private const string ManagedCertificateValue = "ManagedCertificate";
        private const string CustomerCertificateValue = "CustomerCertificate";

        /// <summary> UrlSigningKey. </summary>
        public static ValidateSecretType UrlSigningKey { get; } = new ValidateSecretType(UrlSigningKeyValue);
        /// <summary> ManagedCertificate. </summary>
        public static ValidateSecretType ManagedCertificate { get; } = new ValidateSecretType(ManagedCertificateValue);
        /// <summary> CustomerCertificate. </summary>
        public static ValidateSecretType CustomerCertificate { get; } = new ValidateSecretType(CustomerCertificateValue);
        /// <summary> Determines if two <see cref="ValidateSecretType"/> values are the same. </summary>
        public static bool operator ==(ValidateSecretType left, ValidateSecretType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ValidateSecretType"/> values are not the same. </summary>
        public static bool operator !=(ValidateSecretType left, ValidateSecretType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ValidateSecretType"/>. </summary>
        public static implicit operator ValidateSecretType(string value) => new ValidateSecretType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ValidateSecretType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ValidateSecretType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
