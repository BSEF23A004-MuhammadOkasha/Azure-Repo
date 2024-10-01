// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Operational status of the Front Door load balancer. Permitted values are 'Enabled' or 'Disabled'. </summary>
    public readonly partial struct FrontDoorEnabledState : IEquatable<FrontDoorEnabledState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorEnabledState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorEnabledState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static FrontDoorEnabledState Enabled { get; } = new FrontDoorEnabledState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static FrontDoorEnabledState Disabled { get; } = new FrontDoorEnabledState(DisabledValue);
        /// <summary> Determines if two <see cref="FrontDoorEnabledState"/> values are the same. </summary>
        public static bool operator ==(FrontDoorEnabledState left, FrontDoorEnabledState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorEnabledState"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorEnabledState left, FrontDoorEnabledState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FrontDoorEnabledState"/>. </summary>
        public static implicit operator FrontDoorEnabledState(string value) => new FrontDoorEnabledState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorEnabledState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorEnabledState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
