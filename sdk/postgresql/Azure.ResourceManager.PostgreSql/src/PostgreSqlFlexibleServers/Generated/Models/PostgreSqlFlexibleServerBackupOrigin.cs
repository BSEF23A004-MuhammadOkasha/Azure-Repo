// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Backup type. </summary>
    public readonly partial struct PostgreSqlFlexibleServerBackupOrigin : IEquatable<PostgreSqlFlexibleServerBackupOrigin>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupOrigin"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerBackupOrigin(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullValue = "Full";
        private const string CustomerOnDemandValue = "Customer On-Demand";

        /// <summary> Full. </summary>
        public static PostgreSqlFlexibleServerBackupOrigin Full { get; } = new PostgreSqlFlexibleServerBackupOrigin(FullValue);
        /// <summary> Customer On-Demand. </summary>
        public static PostgreSqlFlexibleServerBackupOrigin CustomerOnDemand { get; } = new PostgreSqlFlexibleServerBackupOrigin(CustomerOnDemandValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerBackupOrigin"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerBackupOrigin left, PostgreSqlFlexibleServerBackupOrigin right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerBackupOrigin"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerBackupOrigin left, PostgreSqlFlexibleServerBackupOrigin right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlFlexibleServerBackupOrigin"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerBackupOrigin(string value) => new PostgreSqlFlexibleServerBackupOrigin(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerBackupOrigin other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerBackupOrigin other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
