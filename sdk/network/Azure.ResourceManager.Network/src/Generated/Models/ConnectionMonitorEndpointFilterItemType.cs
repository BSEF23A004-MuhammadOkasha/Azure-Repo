// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The type of item included in the filter. Currently only 'AgentAddress' is supported. </summary>
    public readonly partial struct ConnectionMonitorEndpointFilterItemType : IEquatable<ConnectionMonitorEndpointFilterItemType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpointFilterItemType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionMonitorEndpointFilterItemType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AgentAddressValue = "AgentAddress";

        /// <summary> AgentAddress. </summary>
        public static ConnectionMonitorEndpointFilterItemType AgentAddress { get; } = new ConnectionMonitorEndpointFilterItemType(AgentAddressValue);
        /// <summary> Determines if two <see cref="ConnectionMonitorEndpointFilterItemType"/> values are the same. </summary>
        public static bool operator ==(ConnectionMonitorEndpointFilterItemType left, ConnectionMonitorEndpointFilterItemType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionMonitorEndpointFilterItemType"/> values are not the same. </summary>
        public static bool operator !=(ConnectionMonitorEndpointFilterItemType left, ConnectionMonitorEndpointFilterItemType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectionMonitorEndpointFilterItemType"/>. </summary>
        public static implicit operator ConnectionMonitorEndpointFilterItemType(string value) => new ConnectionMonitorEndpointFilterItemType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionMonitorEndpointFilterItemType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionMonitorEndpointFilterItemType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
