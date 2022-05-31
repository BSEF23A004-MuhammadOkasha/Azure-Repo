// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> Whether to enable Azure backup for the workload. </summary>
    public readonly partial struct EnableBackup : IEquatable<EnableBackup>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnableBackup"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnableBackup(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static EnableBackup Enabled { get; } = new EnableBackup(EnabledValue);
        /// <summary> Disabled. </summary>
        public static EnableBackup Disabled { get; } = new EnableBackup(DisabledValue);
        /// <summary> Determines if two <see cref="EnableBackup"/> values are the same. </summary>
        public static bool operator ==(EnableBackup left, EnableBackup right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnableBackup"/> values are not the same. </summary>
        public static bool operator !=(EnableBackup left, EnableBackup right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnableBackup"/>. </summary>
        public static implicit operator EnableBackup(string value) => new EnableBackup(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnableBackup other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnableBackup other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
