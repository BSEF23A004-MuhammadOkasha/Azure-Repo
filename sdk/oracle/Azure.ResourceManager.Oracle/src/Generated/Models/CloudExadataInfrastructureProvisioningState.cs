// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Oracle.Models
{
    /// <summary> CloudExadataInfrastructureProvisioningState enum. </summary>
    public readonly partial struct CloudExadataInfrastructureProvisioningState : IEquatable<CloudExadataInfrastructureProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudExadataInfrastructureProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudExadataInfrastructureProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";
        private const string AvailableValue = "Available";
        private const string UpdatingValue = "Updating";
        private const string TerminatingValue = "Terminating";
        private const string TerminatedValue = "Terminated";
        private const string MaintenanceInProgressValue = "MaintenanceInProgress";

        /// <summary> Resource has been created. </summary>
        public static CloudExadataInfrastructureProvisioningState Succeeded { get; } = new CloudExadataInfrastructureProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static CloudExadataInfrastructureProvisioningState Failed { get; } = new CloudExadataInfrastructureProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static CloudExadataInfrastructureProvisioningState Canceled { get; } = new CloudExadataInfrastructureProvisioningState(CanceledValue);
        /// <summary> Provisioning value. </summary>
        public static CloudExadataInfrastructureProvisioningState Provisioning { get; } = new CloudExadataInfrastructureProvisioningState(ProvisioningValue);
        /// <summary> Available value. </summary>
        public static CloudExadataInfrastructureProvisioningState Available { get; } = new CloudExadataInfrastructureProvisioningState(AvailableValue);
        /// <summary> Updating value. </summary>
        public static CloudExadataInfrastructureProvisioningState Updating { get; } = new CloudExadataInfrastructureProvisioningState(UpdatingValue);
        /// <summary> Terminating value. </summary>
        public static CloudExadataInfrastructureProvisioningState Terminating { get; } = new CloudExadataInfrastructureProvisioningState(TerminatingValue);
        /// <summary> Terminated value. </summary>
        public static CloudExadataInfrastructureProvisioningState Terminated { get; } = new CloudExadataInfrastructureProvisioningState(TerminatedValue);
        /// <summary> MaintenanceInProgress value. </summary>
        public static CloudExadataInfrastructureProvisioningState MaintenanceInProgress { get; } = new CloudExadataInfrastructureProvisioningState(MaintenanceInProgressValue);
        /// <summary> Determines if two <see cref="CloudExadataInfrastructureProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CloudExadataInfrastructureProvisioningState left, CloudExadataInfrastructureProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudExadataInfrastructureProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CloudExadataInfrastructureProvisioningState left, CloudExadataInfrastructureProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudExadataInfrastructureProvisioningState"/>. </summary>
        public static implicit operator CloudExadataInfrastructureProvisioningState(string value) => new CloudExadataInfrastructureProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudExadataInfrastructureProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudExadataInfrastructureProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
