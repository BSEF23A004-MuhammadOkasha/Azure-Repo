// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Resource provisioning states. </summary>
    public readonly partial struct AppComplianceProvisioningState : IEquatable<AppComplianceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppComplianceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppComplianceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FixingValue = "Fixing";
        private const string VerifyingValue = "Verifying";
        private const string UpdatingValue = "Updating";

        /// <summary> The provision is succeeded. </summary>
        public static AppComplianceProvisioningState Succeeded { get; } = new AppComplianceProvisioningState(SucceededValue);
        /// <summary> The provision is failed. </summary>
        public static AppComplianceProvisioningState Failed { get; } = new AppComplianceProvisioningState(FailedValue);
        /// <summary> The provision is canceled. </summary>
        public static AppComplianceProvisioningState Canceled { get; } = new AppComplianceProvisioningState(CanceledValue);
        /// <summary> The creation is in progress. </summary>
        public static AppComplianceProvisioningState Creating { get; } = new AppComplianceProvisioningState(CreatingValue);
        /// <summary> The deletion is in progress. </summary>
        public static AppComplianceProvisioningState Deleting { get; } = new AppComplianceProvisioningState(DeletingValue);
        /// <summary> The fix of the resource in progress. </summary>
        public static AppComplianceProvisioningState Fixing { get; } = new AppComplianceProvisioningState(FixingValue);
        /// <summary> The verification of the resource in progress. </summary>
        public static AppComplianceProvisioningState Verifying { get; } = new AppComplianceProvisioningState(VerifyingValue);
        /// <summary> The update of the resource in progress. </summary>
        public static AppComplianceProvisioningState Updating { get; } = new AppComplianceProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="AppComplianceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppComplianceProvisioningState left, AppComplianceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppComplianceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppComplianceProvisioningState left, AppComplianceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppComplianceProvisioningState"/>. </summary>
        public static implicit operator AppComplianceProvisioningState(string value) => new AppComplianceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppComplianceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppComplianceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
