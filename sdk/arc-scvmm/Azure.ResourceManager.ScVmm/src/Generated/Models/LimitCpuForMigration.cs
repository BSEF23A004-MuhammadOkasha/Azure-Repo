// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ScVmm.Models
{
    /// <summary> Gets or sets a value indicating whether to enable processor compatibility mode for live migration of VMs. </summary>
    public readonly partial struct LimitCpuForMigration : IEquatable<LimitCpuForMigration>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LimitCpuForMigration"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LimitCpuForMigration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FalseValue = "false";
        private const string TrueValue = "true";

        /// <summary> false. </summary>
        public static LimitCpuForMigration False { get; } = new LimitCpuForMigration(FalseValue);
        /// <summary> true. </summary>
        public static LimitCpuForMigration True { get; } = new LimitCpuForMigration(TrueValue);
        /// <summary> Determines if two <see cref="LimitCpuForMigration"/> values are the same. </summary>
        public static bool operator ==(LimitCpuForMigration left, LimitCpuForMigration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LimitCpuForMigration"/> values are not the same. </summary>
        public static bool operator !=(LimitCpuForMigration left, LimitCpuForMigration right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LimitCpuForMigration"/>. </summary>
        public static implicit operator LimitCpuForMigration(string value) => new LimitCpuForMigration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LimitCpuForMigration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LimitCpuForMigration other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
