// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> Capability value for calling. </summary>
    public readonly partial struct PhoneNumberCapabilityValue : IEquatable<PhoneNumberCapabilityValue>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PhoneNumberCapabilityValue"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhoneNumberCapabilityValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string InboundValue = "inbound";
        private const string OutboundValue = "outbound";
        private const string InboundOutboundValue = "inbound+outbound";

        /// <summary> none. </summary>
        public static PhoneNumberCapabilityValue None { get; } = new PhoneNumberCapabilityValue(NoneValue);
        /// <summary> inbound. </summary>
        public static PhoneNumberCapabilityValue Inbound { get; } = new PhoneNumberCapabilityValue(InboundValue);
        /// <summary> outbound. </summary>
        public static PhoneNumberCapabilityValue Outbound { get; } = new PhoneNumberCapabilityValue(OutboundValue);
        /// <summary> inbound+outbound. </summary>
        public static PhoneNumberCapabilityValue InboundOutbound { get; } = new PhoneNumberCapabilityValue(InboundOutboundValue);
        /// <summary> Determines if two <see cref="PhoneNumberCapabilityValue"/> values are the same. </summary>
        public static bool operator ==(PhoneNumberCapabilityValue left, PhoneNumberCapabilityValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhoneNumberCapabilityValue"/> values are not the same. </summary>
        public static bool operator !=(PhoneNumberCapabilityValue left, PhoneNumberCapabilityValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PhoneNumberCapabilityValue"/>. </summary>
        public static implicit operator PhoneNumberCapabilityValue(string value) => new PhoneNumberCapabilityValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhoneNumberCapabilityValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhoneNumberCapabilityValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
