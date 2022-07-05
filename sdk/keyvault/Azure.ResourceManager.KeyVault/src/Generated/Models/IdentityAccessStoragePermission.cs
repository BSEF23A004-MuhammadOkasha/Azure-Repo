// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The IdentityAccessStoragePermission. </summary>
    public readonly partial struct IdentityAccessStoragePermission : IEquatable<IdentityAccessStoragePermission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IdentityAccessStoragePermission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IdentityAccessStoragePermission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "all";
        private const string GetValue = "get";
        private const string ListValue = "list";
        private const string DeleteValue = "delete";
        private const string SetValue = "set";
        private const string UpdateValue = "update";
        private const string RegenerateKeyValue = "regeneratekey";
        private const string RecoverValue = "recover";
        private const string PurgeValue = "purge";
        private const string BackupValue = "backup";
        private const string RestoreValue = "restore";
        private const string SetSasValue = "setsas";
        private const string ListSasValue = "listsas";
        private const string GetSasValue = "getsas";
        private const string DeleteSasValue = "deletesas";

        /// <summary> all. </summary>
        public static IdentityAccessStoragePermission All { get; } = new IdentityAccessStoragePermission(AllValue);
        /// <summary> get. </summary>
        public static IdentityAccessStoragePermission Get { get; } = new IdentityAccessStoragePermission(GetValue);
        /// <summary> list. </summary>
        public static IdentityAccessStoragePermission List { get; } = new IdentityAccessStoragePermission(ListValue);
        /// <summary> delete. </summary>
        public static IdentityAccessStoragePermission Delete { get; } = new IdentityAccessStoragePermission(DeleteValue);
        /// <summary> set. </summary>
        public static IdentityAccessStoragePermission Set { get; } = new IdentityAccessStoragePermission(SetValue);
        /// <summary> update. </summary>
        public static IdentityAccessStoragePermission Update { get; } = new IdentityAccessStoragePermission(UpdateValue);
        /// <summary> regeneratekey. </summary>
        public static IdentityAccessStoragePermission RegenerateKey { get; } = new IdentityAccessStoragePermission(RegenerateKeyValue);
        /// <summary> recover. </summary>
        public static IdentityAccessStoragePermission Recover { get; } = new IdentityAccessStoragePermission(RecoverValue);
        /// <summary> purge. </summary>
        public static IdentityAccessStoragePermission Purge { get; } = new IdentityAccessStoragePermission(PurgeValue);
        /// <summary> backup. </summary>
        public static IdentityAccessStoragePermission Backup { get; } = new IdentityAccessStoragePermission(BackupValue);
        /// <summary> restore. </summary>
        public static IdentityAccessStoragePermission Restore { get; } = new IdentityAccessStoragePermission(RestoreValue);
        /// <summary> setsas. </summary>
        public static IdentityAccessStoragePermission SetSas { get; } = new IdentityAccessStoragePermission(SetSasValue);
        /// <summary> listsas. </summary>
        public static IdentityAccessStoragePermission ListSas { get; } = new IdentityAccessStoragePermission(ListSasValue);
        /// <summary> getsas. </summary>
        public static IdentityAccessStoragePermission GetSas { get; } = new IdentityAccessStoragePermission(GetSasValue);
        /// <summary> deletesas. </summary>
        public static IdentityAccessStoragePermission DeleteSas { get; } = new IdentityAccessStoragePermission(DeleteSasValue);
        /// <summary> Determines if two <see cref="IdentityAccessStoragePermission"/> values are the same. </summary>
        public static bool operator ==(IdentityAccessStoragePermission left, IdentityAccessStoragePermission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IdentityAccessStoragePermission"/> values are not the same. </summary>
        public static bool operator !=(IdentityAccessStoragePermission left, IdentityAccessStoragePermission right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IdentityAccessStoragePermission"/>. </summary>
        public static implicit operator IdentityAccessStoragePermission(string value) => new IdentityAccessStoragePermission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IdentityAccessStoragePermission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IdentityAccessStoragePermission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
