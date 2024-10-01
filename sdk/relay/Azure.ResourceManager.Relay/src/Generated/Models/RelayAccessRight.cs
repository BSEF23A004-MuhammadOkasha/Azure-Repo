// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> The RelayAccessRight. </summary>
    public readonly partial struct RelayAccessRight : IEquatable<RelayAccessRight>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelayAccessRight"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelayAccessRight(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManageValue = "Manage";
        private const string SendValue = "Send";
        private const string ListenValue = "Listen";

        /// <summary> Manage. </summary>
        public static RelayAccessRight Manage { get; } = new RelayAccessRight(ManageValue);
        /// <summary> Send. </summary>
        public static RelayAccessRight Send { get; } = new RelayAccessRight(SendValue);
        /// <summary> Listen. </summary>
        public static RelayAccessRight Listen { get; } = new RelayAccessRight(ListenValue);
        /// <summary> Determines if two <see cref="RelayAccessRight"/> values are the same. </summary>
        public static bool operator ==(RelayAccessRight left, RelayAccessRight right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelayAccessRight"/> values are not the same. </summary>
        public static bool operator !=(RelayAccessRight left, RelayAccessRight right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RelayAccessRight"/>. </summary>
        public static implicit operator RelayAccessRight(string value) => new RelayAccessRight(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelayAccessRight other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelayAccessRight other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
