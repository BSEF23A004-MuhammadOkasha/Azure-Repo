// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The IdentityAccessCertificatePermission. </summary>
    public readonly partial struct IdentityAccessCertificatePermission : IEquatable<IdentityAccessCertificatePermission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IdentityAccessCertificatePermission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IdentityAccessCertificatePermission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "all";
        private const string GetValue = "get";
        private const string ListValue = "list";
        private const string DeleteValue = "delete";
        private const string CreateValue = "create";
        private const string ImportValue = "import";
        private const string UpdateValue = "update";
        private const string ManageContactsValue = "managecontacts";
        private const string GetIssuersValue = "getissuers";
        private const string ListIssuersValue = "listissuers";
        private const string SetIssuersValue = "setissuers";
        private const string DeleteIssuersValue = "deleteissuers";
        private const string ManageIssuersValue = "manageissuers";
        private const string RecoverValue = "recover";
        private const string PurgeValue = "purge";
        private const string BackupValue = "backup";
        private const string RestoreValue = "restore";

        /// <summary> all. </summary>
        public static IdentityAccessCertificatePermission All { get; } = new IdentityAccessCertificatePermission(AllValue);
        /// <summary> get. </summary>
        public static IdentityAccessCertificatePermission Get { get; } = new IdentityAccessCertificatePermission(GetValue);
        /// <summary> list. </summary>
        public static IdentityAccessCertificatePermission List { get; } = new IdentityAccessCertificatePermission(ListValue);
        /// <summary> delete. </summary>
        public static IdentityAccessCertificatePermission Delete { get; } = new IdentityAccessCertificatePermission(DeleteValue);
        /// <summary> create. </summary>
        public static IdentityAccessCertificatePermission Create { get; } = new IdentityAccessCertificatePermission(CreateValue);
        /// <summary> import. </summary>
        public static IdentityAccessCertificatePermission Import { get; } = new IdentityAccessCertificatePermission(ImportValue);
        /// <summary> update. </summary>
        public static IdentityAccessCertificatePermission Update { get; } = new IdentityAccessCertificatePermission(UpdateValue);
        /// <summary> managecontacts. </summary>
        public static IdentityAccessCertificatePermission ManageContacts { get; } = new IdentityAccessCertificatePermission(ManageContactsValue);
        /// <summary> getissuers. </summary>
        public static IdentityAccessCertificatePermission GetIssuers { get; } = new IdentityAccessCertificatePermission(GetIssuersValue);
        /// <summary> listissuers. </summary>
        public static IdentityAccessCertificatePermission ListIssuers { get; } = new IdentityAccessCertificatePermission(ListIssuersValue);
        /// <summary> setissuers. </summary>
        public static IdentityAccessCertificatePermission SetIssuers { get; } = new IdentityAccessCertificatePermission(SetIssuersValue);
        /// <summary> deleteissuers. </summary>
        public static IdentityAccessCertificatePermission DeleteIssuers { get; } = new IdentityAccessCertificatePermission(DeleteIssuersValue);
        /// <summary> manageissuers. </summary>
        public static IdentityAccessCertificatePermission ManageIssuers { get; } = new IdentityAccessCertificatePermission(ManageIssuersValue);
        /// <summary> recover. </summary>
        public static IdentityAccessCertificatePermission Recover { get; } = new IdentityAccessCertificatePermission(RecoverValue);
        /// <summary> purge. </summary>
        public static IdentityAccessCertificatePermission Purge { get; } = new IdentityAccessCertificatePermission(PurgeValue);
        /// <summary> backup. </summary>
        public static IdentityAccessCertificatePermission Backup { get; } = new IdentityAccessCertificatePermission(BackupValue);
        /// <summary> restore. </summary>
        public static IdentityAccessCertificatePermission Restore { get; } = new IdentityAccessCertificatePermission(RestoreValue);
        /// <summary> Determines if two <see cref="IdentityAccessCertificatePermission"/> values are the same. </summary>
        public static bool operator ==(IdentityAccessCertificatePermission left, IdentityAccessCertificatePermission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IdentityAccessCertificatePermission"/> values are not the same. </summary>
        public static bool operator !=(IdentityAccessCertificatePermission left, IdentityAccessCertificatePermission right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IdentityAccessCertificatePermission"/>. </summary>
        public static implicit operator IdentityAccessCertificatePermission(string value) => new IdentityAccessCertificatePermission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IdentityAccessCertificatePermission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IdentityAccessCertificatePermission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
