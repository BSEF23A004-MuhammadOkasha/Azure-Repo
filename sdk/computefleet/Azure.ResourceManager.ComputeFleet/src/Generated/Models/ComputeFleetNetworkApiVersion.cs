// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary>
    /// specifies the Microsoft.Network API version used when creating networking
    /// resources in the Network Interface Configurations for Virtual Machine Scale Set
    /// with orchestration mode 'Flexible'
    /// </summary>
    public readonly partial struct ComputeFleetNetworkApiVersion : IEquatable<ComputeFleetNetworkApiVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetNetworkApiVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetNetworkApiVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string V20201101Value = "2020-11-01";

        /// <summary> Initial version supported. Later versions are supported as well. </summary>
        public static ComputeFleetNetworkApiVersion V20201101 { get; } = new ComputeFleetNetworkApiVersion(V20201101Value);
        /// <summary> Determines if two <see cref="ComputeFleetNetworkApiVersion"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetNetworkApiVersion left, ComputeFleetNetworkApiVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetNetworkApiVersion"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetNetworkApiVersion left, ComputeFleetNetworkApiVersion right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputeFleetNetworkApiVersion"/>. </summary>
        public static implicit operator ComputeFleetNetworkApiVersion(string value) => new ComputeFleetNetworkApiVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetNetworkApiVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetNetworkApiVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
