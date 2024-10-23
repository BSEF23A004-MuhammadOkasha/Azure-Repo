// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Source of key used to encrypt data in volume. Applicable if NetApp account has encryption.keySource = 'Microsoft.KeyVault'. Possible values (case-insensitive) are: 'Microsoft.NetApp, Microsoft.KeyVault'
    /// Serialized Name: EncryptionKeySource
    /// </summary>
    public readonly partial struct NetAppEncryptionKeySource : IEquatable<NetAppEncryptionKeySource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppEncryptionKeySource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppEncryptionKeySource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftNetAppValue = "Microsoft.NetApp";
        private const string MicrosoftKeyVaultValue = "Microsoft.KeyVault";

        /// <summary>
        /// Microsoft-managed key encryption
        /// Serialized Name: EncryptionKeySource.Microsoft.NetApp
        /// </summary>
        public static NetAppEncryptionKeySource MicrosoftNetApp { get; } = new NetAppEncryptionKeySource(MicrosoftNetAppValue);
        /// <summary>
        /// Customer-managed key encryption
        /// Serialized Name: EncryptionKeySource.Microsoft.KeyVault
        /// </summary>
        public static NetAppEncryptionKeySource MicrosoftKeyVault { get; } = new NetAppEncryptionKeySource(MicrosoftKeyVaultValue);
        /// <summary> Determines if two <see cref="NetAppEncryptionKeySource"/> values are the same. </summary>
        public static bool operator ==(NetAppEncryptionKeySource left, NetAppEncryptionKeySource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppEncryptionKeySource"/> values are not the same. </summary>
        public static bool operator !=(NetAppEncryptionKeySource left, NetAppEncryptionKeySource right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppEncryptionKeySource"/>. </summary>
        public static implicit operator NetAppEncryptionKeySource(string value) => new NetAppEncryptionKeySource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppEncryptionKeySource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppEncryptionKeySource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
