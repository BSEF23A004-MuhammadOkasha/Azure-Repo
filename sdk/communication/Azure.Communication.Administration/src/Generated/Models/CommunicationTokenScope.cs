// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Administration
{
    /// <summary> List of scopes for an access token. </summary>
    public readonly partial struct CommunicationTokenScope : IEquatable<CommunicationTokenScope>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CommunicationTokenScope"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationTokenScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ChatValue = "chat";
        private const string VoIPValue = "voip";

        /// <summary> chat. </summary>
        public static CommunicationTokenScope Chat { get; } = new CommunicationTokenScope(ChatValue);
        /// <summary> Determines if two <see cref="CommunicationTokenScope"/> values are the same. </summary>
        public static bool operator ==(CommunicationTokenScope left, CommunicationTokenScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationTokenScope"/> values are not the same. </summary>
        public static bool operator !=(CommunicationTokenScope left, CommunicationTokenScope right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommunicationTokenScope"/>. </summary>
        public static implicit operator CommunicationTokenScope(string value) => new CommunicationTokenScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationTokenScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationTokenScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
