// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Signifies whether SSL needs to be enabled or not. </summary>
    public readonly partial struct DataBoxEdgeStorageAccountSslStatus : IEquatable<DataBoxEdgeStorageAccountSslStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeStorageAccountSslStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeStorageAccountSslStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DataBoxEdgeStorageAccountSslStatus Enabled { get; } = new DataBoxEdgeStorageAccountSslStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DataBoxEdgeStorageAccountSslStatus Disabled { get; } = new DataBoxEdgeStorageAccountSslStatus(DisabledValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeStorageAccountSslStatus"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeStorageAccountSslStatus left, DataBoxEdgeStorageAccountSslStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeStorageAccountSslStatus"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeStorageAccountSslStatus left, DataBoxEdgeStorageAccountSslStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataBoxEdgeStorageAccountSslStatus"/>. </summary>
        public static implicit operator DataBoxEdgeStorageAccountSslStatus(string value) => new DataBoxEdgeStorageAccountSslStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeStorageAccountSslStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeStorageAccountSslStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
