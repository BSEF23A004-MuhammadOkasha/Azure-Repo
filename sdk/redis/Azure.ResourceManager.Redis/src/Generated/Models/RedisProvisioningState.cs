// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Redis instance provisioning status. </summary>
    public readonly partial struct RedisProvisioningState : IEquatable<RedisProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string DisabledValue = "Disabled";
        private const string FailedValue = "Failed";
        private const string LinkingValue = "Linking";
        private const string ProvisioningValue = "Provisioning";
        private const string RecoveringScaleFailureValue = "RecoveringScaleFailure";
        private const string ScalingValue = "Scaling";
        private const string SucceededValue = "Succeeded";
        private const string UnlinkingValue = "Unlinking";
        private const string UnprovisioningValue = "Unprovisioning";
        private const string UpdatingValue = "Updating";
        private const string ConfiguringAADValue = "ConfiguringAAD";

        /// <summary> Creating. </summary>
        public static RedisProvisioningState Creating { get; } = new RedisProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static RedisProvisioningState Deleting { get; } = new RedisProvisioningState(DeletingValue);
        /// <summary> Disabled. </summary>
        public static RedisProvisioningState Disabled { get; } = new RedisProvisioningState(DisabledValue);
        /// <summary> Failed. </summary>
        public static RedisProvisioningState Failed { get; } = new RedisProvisioningState(FailedValue);
        /// <summary> Linking. </summary>
        public static RedisProvisioningState Linking { get; } = new RedisProvisioningState(LinkingValue);
        /// <summary> Provisioning. </summary>
        public static RedisProvisioningState Provisioning { get; } = new RedisProvisioningState(ProvisioningValue);
        /// <summary> RecoveringScaleFailure. </summary>
        public static RedisProvisioningState RecoveringScaleFailure { get; } = new RedisProvisioningState(RecoveringScaleFailureValue);
        /// <summary> Scaling. </summary>
        public static RedisProvisioningState Scaling { get; } = new RedisProvisioningState(ScalingValue);
        /// <summary> Succeeded. </summary>
        public static RedisProvisioningState Succeeded { get; } = new RedisProvisioningState(SucceededValue);
        /// <summary> Unlinking. </summary>
        public static RedisProvisioningState Unlinking { get; } = new RedisProvisioningState(UnlinkingValue);
        /// <summary> Unprovisioning. </summary>
        public static RedisProvisioningState Unprovisioning { get; } = new RedisProvisioningState(UnprovisioningValue);
        /// <summary> Updating. </summary>
        public static RedisProvisioningState Updating { get; } = new RedisProvisioningState(UpdatingValue);
        /// <summary> ConfiguringAAD. </summary>
        public static RedisProvisioningState ConfiguringAAD { get; } = new RedisProvisioningState(ConfiguringAADValue);
        /// <summary> Determines if two <see cref="RedisProvisioningState"/> values are the same. </summary>
        public static bool operator ==(RedisProvisioningState left, RedisProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(RedisProvisioningState left, RedisProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisProvisioningState"/>. </summary>
        public static implicit operator RedisProvisioningState(string value) => new RedisProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
