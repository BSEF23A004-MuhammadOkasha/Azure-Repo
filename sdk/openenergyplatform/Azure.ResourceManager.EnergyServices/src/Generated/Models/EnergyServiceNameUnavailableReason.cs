// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EnergyServices.Models
{
    /// <summary> The reason why the given name is not available. </summary>
    public readonly partial struct EnergyServiceNameUnavailableReason : IEquatable<EnergyServiceNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnergyServiceNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyServiceNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static EnergyServiceNameUnavailableReason Invalid { get; } = new EnergyServiceNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static EnergyServiceNameUnavailableReason AlreadyExists { get; } = new EnergyServiceNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="EnergyServiceNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(EnergyServiceNameUnavailableReason left, EnergyServiceNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyServiceNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(EnergyServiceNameUnavailableReason left, EnergyServiceNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyServiceNameUnavailableReason"/>. </summary>
        public static implicit operator EnergyServiceNameUnavailableReason(string value) => new EnergyServiceNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyServiceNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyServiceNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
