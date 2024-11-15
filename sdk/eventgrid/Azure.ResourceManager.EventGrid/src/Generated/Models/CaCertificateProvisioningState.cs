// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the CA Certificate resource. </summary>
    public readonly partial struct CaCertificateProvisioningState : IEquatable<CaCertificateProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CaCertificateProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CaCertificateProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string DeletedValue = "Deleted";

        /// <summary> Creating. </summary>
        public static CaCertificateProvisioningState Creating { get; } = new CaCertificateProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static CaCertificateProvisioningState Updating { get; } = new CaCertificateProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static CaCertificateProvisioningState Deleting { get; } = new CaCertificateProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static CaCertificateProvisioningState Succeeded { get; } = new CaCertificateProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static CaCertificateProvisioningState Canceled { get; } = new CaCertificateProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static CaCertificateProvisioningState Failed { get; } = new CaCertificateProvisioningState(FailedValue);
        /// <summary> Deleted. </summary>
        public static CaCertificateProvisioningState Deleted { get; } = new CaCertificateProvisioningState(DeletedValue);
        /// <summary> Determines if two <see cref="CaCertificateProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CaCertificateProvisioningState left, CaCertificateProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CaCertificateProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CaCertificateProvisioningState left, CaCertificateProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CaCertificateProvisioningState"/>. </summary>
        public static implicit operator CaCertificateProvisioningState(string value) => new CaCertificateProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CaCertificateProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CaCertificateProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
