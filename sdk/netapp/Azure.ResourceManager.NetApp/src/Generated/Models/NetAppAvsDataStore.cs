// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Specifies whether the volume is enabled for Azure VMware Solution (AVS) datastore purpose
    /// Serialized Name: AvsDataStore
    /// </summary>
    public readonly partial struct NetAppAvsDataStore : IEquatable<NetAppAvsDataStore>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppAvsDataStore"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppAvsDataStore(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary>
        /// avsDataStore is enabled
        /// Serialized Name: AvsDataStore.Enabled
        /// </summary>
        public static NetAppAvsDataStore Enabled { get; } = new NetAppAvsDataStore(EnabledValue);
        /// <summary>
        /// avsDataStore is disabled
        /// Serialized Name: AvsDataStore.Disabled
        /// </summary>
        public static NetAppAvsDataStore Disabled { get; } = new NetAppAvsDataStore(DisabledValue);
        /// <summary> Determines if two <see cref="NetAppAvsDataStore"/> values are the same. </summary>
        public static bool operator ==(NetAppAvsDataStore left, NetAppAvsDataStore right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppAvsDataStore"/> values are not the same. </summary>
        public static bool operator !=(NetAppAvsDataStore left, NetAppAvsDataStore right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppAvsDataStore"/>. </summary>
        public static implicit operator NetAppAvsDataStore(string value) => new NetAppAvsDataStore(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppAvsDataStore other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppAvsDataStore other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
