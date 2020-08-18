// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The state of peering. </summary>
    public readonly partial struct ExpressRoutePeeringState : IEquatable<ExpressRoutePeeringState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ExpressRoutePeeringState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRoutePeeringState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static ExpressRoutePeeringState Disabled { get; } = new ExpressRoutePeeringState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ExpressRoutePeeringState Enabled { get; } = new ExpressRoutePeeringState(EnabledValue);
        /// <summary> Determines if two <see cref="ExpressRoutePeeringState"/> values are the same. </summary>
        public static bool operator ==(ExpressRoutePeeringState left, ExpressRoutePeeringState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRoutePeeringState"/> values are not the same. </summary>
        public static bool operator !=(ExpressRoutePeeringState left, ExpressRoutePeeringState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpressRoutePeeringState"/>. </summary>
        public static implicit operator ExpressRoutePeeringState(string value) => new ExpressRoutePeeringState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRoutePeeringState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRoutePeeringState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
