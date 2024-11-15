// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the provisioning states. </summary>
    public readonly partial struct MoverProvisioningState : IEquatable<MoverProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MoverProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MoverProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";
        private const string CreatingValue = "Creating";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static MoverProvisioningState Succeeded { get; } = new MoverProvisioningState(SucceededValue);
        /// <summary> Updating. </summary>
        public static MoverProvisioningState Updating { get; } = new MoverProvisioningState(UpdatingValue);
        /// <summary> Creating. </summary>
        public static MoverProvisioningState Creating { get; } = new MoverProvisioningState(CreatingValue);
        /// <summary> Failed. </summary>
        public static MoverProvisioningState Failed { get; } = new MoverProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="MoverProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MoverProvisioningState left, MoverProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MoverProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MoverProvisioningState left, MoverProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MoverProvisioningState"/>. </summary>
        public static implicit operator MoverProvisioningState(string value) => new MoverProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MoverProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MoverProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
