// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning status. </summary>
    public readonly partial struct AfdProvisioningState : IEquatable<AfdProvisioningState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AfdProvisioningState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AfdProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string CreatingValue = "Creating";

        /// <summary> Succeeded. </summary>
        public static AfdProvisioningState Succeeded { get; } = new AfdProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AfdProvisioningState Failed { get; } = new AfdProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static AfdProvisioningState Updating { get; } = new AfdProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static AfdProvisioningState Deleting { get; } = new AfdProvisioningState(DeletingValue);
        /// <summary> Creating. </summary>
        public static AfdProvisioningState Creating { get; } = new AfdProvisioningState(CreatingValue);
        /// <summary> Determines if two <see cref="AfdProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AfdProvisioningState left, AfdProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AfdProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AfdProvisioningState left, AfdProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AfdProvisioningState"/>. </summary>
        public static implicit operator AfdProvisioningState(string value) => new AfdProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AfdProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AfdProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
