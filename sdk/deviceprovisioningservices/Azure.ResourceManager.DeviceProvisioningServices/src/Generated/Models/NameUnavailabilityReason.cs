// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> specifies the reason a name is unavailable. </summary>
    public readonly partial struct NameUnavailabilityReason : IEquatable<NameUnavailabilityReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NameUnavailabilityReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NameUnavailabilityReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static NameUnavailabilityReason Invalid { get; } = new NameUnavailabilityReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static NameUnavailabilityReason AlreadyExists { get; } = new NameUnavailabilityReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="NameUnavailabilityReason"/> values are the same. </summary>
        public static bool operator ==(NameUnavailabilityReason left, NameUnavailabilityReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NameUnavailabilityReason"/> values are not the same. </summary>
        public static bool operator !=(NameUnavailabilityReason left, NameUnavailabilityReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NameUnavailabilityReason"/>. </summary>
        public static implicit operator NameUnavailabilityReason(string value) => new NameUnavailabilityReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NameUnavailabilityReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NameUnavailabilityReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
