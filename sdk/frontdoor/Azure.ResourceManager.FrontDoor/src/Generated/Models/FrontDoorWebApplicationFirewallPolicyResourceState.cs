// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Resource status of the policy. </summary>
    public readonly partial struct FrontDoorWebApplicationFirewallPolicyResourceState : IEquatable<FrontDoorWebApplicationFirewallPolicyResourceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorWebApplicationFirewallPolicyResourceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorWebApplicationFirewallPolicyResourceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string EnablingValue = "Enabling";
        private const string EnabledValue = "Enabled";
        private const string DisablingValue = "Disabling";
        private const string DisabledValue = "Disabled";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static FrontDoorWebApplicationFirewallPolicyResourceState Creating { get; } = new FrontDoorWebApplicationFirewallPolicyResourceState(CreatingValue);
        /// <summary> Enabling. </summary>
        public static FrontDoorWebApplicationFirewallPolicyResourceState Enabling { get; } = new FrontDoorWebApplicationFirewallPolicyResourceState(EnablingValue);
        /// <summary> Enabled. </summary>
        public static FrontDoorWebApplicationFirewallPolicyResourceState Enabled { get; } = new FrontDoorWebApplicationFirewallPolicyResourceState(EnabledValue);
        /// <summary> Disabling. </summary>
        public static FrontDoorWebApplicationFirewallPolicyResourceState Disabling { get; } = new FrontDoorWebApplicationFirewallPolicyResourceState(DisablingValue);
        /// <summary> Disabled. </summary>
        public static FrontDoorWebApplicationFirewallPolicyResourceState Disabled { get; } = new FrontDoorWebApplicationFirewallPolicyResourceState(DisabledValue);
        /// <summary> Deleting. </summary>
        public static FrontDoorWebApplicationFirewallPolicyResourceState Deleting { get; } = new FrontDoorWebApplicationFirewallPolicyResourceState(DeletingValue);
        /// <summary> Determines if two <see cref="FrontDoorWebApplicationFirewallPolicyResourceState"/> values are the same. </summary>
        public static bool operator ==(FrontDoorWebApplicationFirewallPolicyResourceState left, FrontDoorWebApplicationFirewallPolicyResourceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorWebApplicationFirewallPolicyResourceState"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorWebApplicationFirewallPolicyResourceState left, FrontDoorWebApplicationFirewallPolicyResourceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FrontDoorWebApplicationFirewallPolicyResourceState"/>. </summary>
        public static implicit operator FrontDoorWebApplicationFirewallPolicyResourceState(string value) => new FrontDoorWebApplicationFirewallPolicyResourceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorWebApplicationFirewallPolicyResourceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorWebApplicationFirewallPolicyResourceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
