// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Provisioning state of the resource. </summary>
    public readonly partial struct HybridContainerServiceResourceProvisioningState : IEquatable<HybridContainerServiceResourceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceResourceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridContainerServiceResourceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string UpgradingValue = "Upgrading";
        private const string InProgressValue = "InProgress";
        private const string AcceptedValue = "Accepted";
        private const string CreatedValue = "Created";

        /// <summary> Succeeded. </summary>
        public static HybridContainerServiceResourceProvisioningState Succeeded { get; } = new HybridContainerServiceResourceProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static HybridContainerServiceResourceProvisioningState Failed { get; } = new HybridContainerServiceResourceProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static HybridContainerServiceResourceProvisioningState Canceled { get; } = new HybridContainerServiceResourceProvisioningState(CanceledValue);
        /// <summary> Creating. </summary>
        public static HybridContainerServiceResourceProvisioningState Creating { get; } = new HybridContainerServiceResourceProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static HybridContainerServiceResourceProvisioningState Deleting { get; } = new HybridContainerServiceResourceProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static HybridContainerServiceResourceProvisioningState Updating { get; } = new HybridContainerServiceResourceProvisioningState(UpdatingValue);
        /// <summary> Upgrading. </summary>
        public static HybridContainerServiceResourceProvisioningState Upgrading { get; } = new HybridContainerServiceResourceProvisioningState(UpgradingValue);
        /// <summary> InProgress. </summary>
        public static HybridContainerServiceResourceProvisioningState InProgress { get; } = new HybridContainerServiceResourceProvisioningState(InProgressValue);
        /// <summary> Accepted. </summary>
        public static HybridContainerServiceResourceProvisioningState Accepted { get; } = new HybridContainerServiceResourceProvisioningState(AcceptedValue);
        /// <summary> Created. </summary>
        public static HybridContainerServiceResourceProvisioningState Created { get; } = new HybridContainerServiceResourceProvisioningState(CreatedValue);
        /// <summary> Determines if two <see cref="HybridContainerServiceResourceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(HybridContainerServiceResourceProvisioningState left, HybridContainerServiceResourceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridContainerServiceResourceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(HybridContainerServiceResourceProvisioningState left, HybridContainerServiceResourceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HybridContainerServiceResourceProvisioningState"/>. </summary>
        public static implicit operator HybridContainerServiceResourceProvisioningState(string value) => new HybridContainerServiceResourceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridContainerServiceResourceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridContainerServiceResourceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
