// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Messages
{
    /// <summary> The ChannelType. </summary>
    public readonly partial struct CommunicationMessagesChannelType : IEquatable<CommunicationMessagesChannelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommunicationMessagesChannelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationMessagesChannelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WhatsAppValue = "whatsApp";

        /// <summary> whatsApp. </summary>
        public static CommunicationMessagesChannelType WhatsApp { get; } = new CommunicationMessagesChannelType(WhatsAppValue);
        /// <summary> Determines if two <see cref="CommunicationMessagesChannelType"/> values are the same. </summary>
        public static bool operator ==(CommunicationMessagesChannelType left, CommunicationMessagesChannelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationMessagesChannelType"/> values are not the same. </summary>
        public static bool operator !=(CommunicationMessagesChannelType left, CommunicationMessagesChannelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommunicationMessagesChannelType"/>. </summary>
        public static implicit operator CommunicationMessagesChannelType(string value) => new CommunicationMessagesChannelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationMessagesChannelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationMessagesChannelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
