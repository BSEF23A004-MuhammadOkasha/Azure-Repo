// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace KeyVaultManagementClient.Models
{
    /// <summary> The KeyPermissions. </summary>
    public readonly partial struct KeyPermissions : IEquatable<KeyPermissions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="KeyPermissions"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyPermissions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EncryptValue = "encrypt";
        private const string DecryptValue = "decrypt";
        private const string WrapKeyValue = "wrapKey";
        private const string UnwrapKeyValue = "unwrapKey";
        private const string SignValue = "sign";
        private const string VerifyValue = "verify";
        private const string GetValue = "get";
        private const string ListValue = "list";
        private const string CreateValue = "create";
        private const string UpdateValue = "update";
        private const string ImportValue = "import";
        private const string DeleteValue = "delete";
        private const string BackupValue = "backup";
        private const string RestoreValue = "restore";
        private const string RecoverValue = "recover";
        private const string PurgeValue = "purge";
        private const string ReleaseValue = "release";

        /// <summary> encrypt. </summary>
        public static KeyPermissions Encrypt { get; } = new KeyPermissions(EncryptValue);
        /// <summary> decrypt. </summary>
        public static KeyPermissions Decrypt { get; } = new KeyPermissions(DecryptValue);
        /// <summary> wrapKey. </summary>
        public static KeyPermissions WrapKey { get; } = new KeyPermissions(WrapKeyValue);
        /// <summary> unwrapKey. </summary>
        public static KeyPermissions UnwrapKey { get; } = new KeyPermissions(UnwrapKeyValue);
        /// <summary> sign. </summary>
        public static KeyPermissions Sign { get; } = new KeyPermissions(SignValue);
        /// <summary> verify. </summary>
        public static KeyPermissions Verify { get; } = new KeyPermissions(VerifyValue);
        /// <summary> get. </summary>
        public static KeyPermissions Get { get; } = new KeyPermissions(GetValue);
        /// <summary> list. </summary>
        public static KeyPermissions List { get; } = new KeyPermissions(ListValue);
        /// <summary> create. </summary>
        public static KeyPermissions Create { get; } = new KeyPermissions(CreateValue);
        /// <summary> update. </summary>
        public static KeyPermissions Update { get; } = new KeyPermissions(UpdateValue);
        /// <summary> import. </summary>
        public static KeyPermissions Import { get; } = new KeyPermissions(ImportValue);
        /// <summary> delete. </summary>
        public static KeyPermissions Delete { get; } = new KeyPermissions(DeleteValue);
        /// <summary> backup. </summary>
        public static KeyPermissions Backup { get; } = new KeyPermissions(BackupValue);
        /// <summary> restore. </summary>
        public static KeyPermissions Restore { get; } = new KeyPermissions(RestoreValue);
        /// <summary> recover. </summary>
        public static KeyPermissions Recover { get; } = new KeyPermissions(RecoverValue);
        /// <summary> purge. </summary>
        public static KeyPermissions Purge { get; } = new KeyPermissions(PurgeValue);
        /// <summary> release. </summary>
        public static KeyPermissions Release { get; } = new KeyPermissions(ReleaseValue);
        /// <summary> Determines if two <see cref="KeyPermissions"/> values are the same. </summary>
        public static bool operator ==(KeyPermissions left, KeyPermissions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyPermissions"/> values are not the same. </summary>
        public static bool operator !=(KeyPermissions left, KeyPermissions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyPermissions"/>. </summary>
        public static implicit operator KeyPermissions(string value) => new KeyPermissions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyPermissions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyPermissions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
