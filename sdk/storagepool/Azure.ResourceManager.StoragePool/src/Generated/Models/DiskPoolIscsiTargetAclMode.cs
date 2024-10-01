// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> ACL mode for iSCSI Target. </summary>
    public readonly partial struct DiskPoolIscsiTargetAclMode : IEquatable<DiskPoolIscsiTargetAclMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetAclMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskPoolIscsiTargetAclMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DynamicValue = "Dynamic";
        private const string StaticValue = "Static";

        /// <summary> Dynamic. </summary>
        public static DiskPoolIscsiTargetAclMode Dynamic { get; } = new DiskPoolIscsiTargetAclMode(DynamicValue);
        /// <summary> Static. </summary>
        public static DiskPoolIscsiTargetAclMode Static { get; } = new DiskPoolIscsiTargetAclMode(StaticValue);
        /// <summary> Determines if two <see cref="DiskPoolIscsiTargetAclMode"/> values are the same. </summary>
        public static bool operator ==(DiskPoolIscsiTargetAclMode left, DiskPoolIscsiTargetAclMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskPoolIscsiTargetAclMode"/> values are not the same. </summary>
        public static bool operator !=(DiskPoolIscsiTargetAclMode left, DiskPoolIscsiTargetAclMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiskPoolIscsiTargetAclMode"/>. </summary>
        public static implicit operator DiskPoolIscsiTargetAclMode(string value) => new DiskPoolIscsiTargetAclMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskPoolIscsiTargetAclMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskPoolIscsiTargetAclMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
