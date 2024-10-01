// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Indicates whether subscription logs are being sent. </summary>
    public readonly partial struct SubscriptionLogsSendingStatus : IEquatable<SubscriptionLogsSendingStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SubscriptionLogsSendingStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SubscriptionLogsSendingStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static SubscriptionLogsSendingStatus Enabled { get; } = new SubscriptionLogsSendingStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static SubscriptionLogsSendingStatus Disabled { get; } = new SubscriptionLogsSendingStatus(DisabledValue);
        /// <summary> Determines if two <see cref="SubscriptionLogsSendingStatus"/> values are the same. </summary>
        public static bool operator ==(SubscriptionLogsSendingStatus left, SubscriptionLogsSendingStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SubscriptionLogsSendingStatus"/> values are not the same. </summary>
        public static bool operator !=(SubscriptionLogsSendingStatus left, SubscriptionLogsSendingStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SubscriptionLogsSendingStatus"/>. </summary>
        public static implicit operator SubscriptionLogsSendingStatus(string value) => new SubscriptionLogsSendingStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SubscriptionLogsSendingStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SubscriptionLogsSendingStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
