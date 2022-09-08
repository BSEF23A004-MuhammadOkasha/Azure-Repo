// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Type of storage accessed on the storage account. </summary>
    public readonly partial struct AccountType : IEquatable<AccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeneralPurposeStorageValue = "GeneralPurposeStorage";
        private const string BlobStorageValue = "BlobStorage";

        /// <summary> GeneralPurposeStorage. </summary>
        public static AccountType GeneralPurposeStorage { get; } = new AccountType(GeneralPurposeStorageValue);
        /// <summary> BlobStorage. </summary>
        public static AccountType BlobStorage { get; } = new AccountType(BlobStorageValue);
        /// <summary> Determines if two <see cref="AccountType"/> values are the same. </summary>
        public static bool operator ==(AccountType left, AccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccountType"/> values are not the same. </summary>
        public static bool operator !=(AccountType left, AccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccountType"/>. </summary>
        public static implicit operator AccountType(string value) => new AccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
