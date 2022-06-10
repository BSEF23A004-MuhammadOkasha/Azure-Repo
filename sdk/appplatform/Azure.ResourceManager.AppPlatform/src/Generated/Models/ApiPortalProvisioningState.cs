// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> State of the API portal. </summary>
    public readonly partial struct ApiPortalProvisioningState : IEquatable<ApiPortalProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiPortalProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiPortalProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static ApiPortalProvisioningState Creating { get; } = new ApiPortalProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static ApiPortalProvisioningState Updating { get; } = new ApiPortalProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static ApiPortalProvisioningState Succeeded { get; } = new ApiPortalProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ApiPortalProvisioningState Failed { get; } = new ApiPortalProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static ApiPortalProvisioningState Deleting { get; } = new ApiPortalProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="ApiPortalProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ApiPortalProvisioningState left, ApiPortalProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiPortalProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ApiPortalProvisioningState left, ApiPortalProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApiPortalProvisioningState"/>. </summary>
        public static implicit operator ApiPortalProvisioningState(string value) => new ApiPortalProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiPortalProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiPortalProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
