// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Indicates whether AAD logs are being sent. </summary>
    public readonly partial struct AadLogsSendingStatus : IEquatable<AadLogsSendingStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AadLogsSendingStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AadLogsSendingStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static AadLogsSendingStatus Enabled { get; } = new AadLogsSendingStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static AadLogsSendingStatus Disabled { get; } = new AadLogsSendingStatus(DisabledValue);
        /// <summary> Determines if two <see cref="AadLogsSendingStatus"/> values are the same. </summary>
        public static bool operator ==(AadLogsSendingStatus left, AadLogsSendingStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AadLogsSendingStatus"/> values are not the same. </summary>
        public static bool operator !=(AadLogsSendingStatus left, AadLogsSendingStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AadLogsSendingStatus"/>. </summary>
        public static implicit operator AadLogsSendingStatus(string value) => new AadLogsSendingStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AadLogsSendingStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AadLogsSendingStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
