// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The origin of the issue. </summary>
    public readonly partial struct Origin : IEquatable<Origin>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Origin"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Origin(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocalValue = "Local";
        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Local. </summary>
        public static Origin Local { get; } = new Origin(LocalValue);
        /// <summary> Inbound. </summary>
        public static Origin Inbound { get; } = new Origin(InboundValue);
        /// <summary> Outbound. </summary>
        public static Origin Outbound { get; } = new Origin(OutboundValue);
        /// <summary> Determines if two <see cref="Origin"/> values are the same. </summary>
        public static bool operator ==(Origin left, Origin right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Origin"/> values are not the same. </summary>
        public static bool operator !=(Origin left, Origin right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Origin"/>. </summary>
        public static implicit operator Origin(string value) => new Origin(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Origin other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Origin other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
