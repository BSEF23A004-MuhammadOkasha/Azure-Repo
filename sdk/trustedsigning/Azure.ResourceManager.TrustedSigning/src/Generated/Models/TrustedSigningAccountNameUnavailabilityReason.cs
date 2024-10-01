// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.TrustedSigning.Models
{
    /// <summary> The reason that a trusted signing account name could not be used. The Reason element is only returned if nameAvailable is false. </summary>
    public readonly partial struct TrustedSigningAccountNameUnavailabilityReason : IEquatable<TrustedSigningAccountNameUnavailabilityReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrustedSigningAccountNameUnavailabilityReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrustedSigningAccountNameUnavailabilityReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountNameInvalidValue = "AccountNameInvalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Account name is invalid. </summary>
        public static TrustedSigningAccountNameUnavailabilityReason AccountNameInvalid { get; } = new TrustedSigningAccountNameUnavailabilityReason(AccountNameInvalidValue);
        /// <summary> Account name already exists. </summary>
        public static TrustedSigningAccountNameUnavailabilityReason AlreadyExists { get; } = new TrustedSigningAccountNameUnavailabilityReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="TrustedSigningAccountNameUnavailabilityReason"/> values are the same. </summary>
        public static bool operator ==(TrustedSigningAccountNameUnavailabilityReason left, TrustedSigningAccountNameUnavailabilityReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrustedSigningAccountNameUnavailabilityReason"/> values are not the same. </summary>
        public static bool operator !=(TrustedSigningAccountNameUnavailabilityReason left, TrustedSigningAccountNameUnavailabilityReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TrustedSigningAccountNameUnavailabilityReason"/>. </summary>
        public static implicit operator TrustedSigningAccountNameUnavailabilityReason(string value) => new TrustedSigningAccountNameUnavailabilityReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrustedSigningAccountNameUnavailabilityReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrustedSigningAccountNameUnavailabilityReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
