// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified. </summary>
    public readonly partial struct ManagedRuleSetupState : IEquatable<ManagedRuleSetupState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSetupState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedRuleSetupState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static ManagedRuleSetupState Disabled { get; } = new ManagedRuleSetupState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ManagedRuleSetupState Enabled { get; } = new ManagedRuleSetupState(EnabledValue);
        /// <summary> Determines if two <see cref="ManagedRuleSetupState"/> values are the same. </summary>
        public static bool operator ==(ManagedRuleSetupState left, ManagedRuleSetupState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedRuleSetupState"/> values are not the same. </summary>
        public static bool operator !=(ManagedRuleSetupState left, ManagedRuleSetupState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedRuleSetupState"/>. </summary>
        public static implicit operator ManagedRuleSetupState(string value) => new ManagedRuleSetupState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedRuleSetupState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedRuleSetupState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
