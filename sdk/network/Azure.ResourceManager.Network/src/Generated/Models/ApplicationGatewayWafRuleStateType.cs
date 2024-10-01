// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The string representation of the web application firewall rule state. </summary>
    public readonly partial struct ApplicationGatewayWafRuleStateType : IEquatable<ApplicationGatewayWafRuleStateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWafRuleStateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayWafRuleStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ApplicationGatewayWafRuleStateType Enabled { get; } = new ApplicationGatewayWafRuleStateType(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ApplicationGatewayWafRuleStateType Disabled { get; } = new ApplicationGatewayWafRuleStateType(DisabledValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayWafRuleStateType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayWafRuleStateType left, ApplicationGatewayWafRuleStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayWafRuleStateType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayWafRuleStateType left, ApplicationGatewayWafRuleStateType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApplicationGatewayWafRuleStateType"/>. </summary>
        public static implicit operator ApplicationGatewayWafRuleStateType(string value) => new ApplicationGatewayWafRuleStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayWafRuleStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayWafRuleStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
