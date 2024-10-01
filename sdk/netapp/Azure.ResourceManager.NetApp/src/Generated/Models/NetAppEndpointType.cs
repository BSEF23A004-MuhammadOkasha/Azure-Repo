// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Indicates whether the local volume is the source or destination for the Volume Replication. </summary>
    public readonly partial struct NetAppEndpointType : IEquatable<NetAppEndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppEndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppEndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SourceValue = "src";
        private const string DestinationValue = "dst";

        /// <summary> src. </summary>
        public static NetAppEndpointType Source { get; } = new NetAppEndpointType(SourceValue);
        /// <summary> dst. </summary>
        public static NetAppEndpointType Destination { get; } = new NetAppEndpointType(DestinationValue);
        /// <summary> Determines if two <see cref="NetAppEndpointType"/> values are the same. </summary>
        public static bool operator ==(NetAppEndpointType left, NetAppEndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppEndpointType"/> values are not the same. </summary>
        public static bool operator !=(NetAppEndpointType left, NetAppEndpointType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppEndpointType"/>. </summary>
        public static implicit operator NetAppEndpointType(string value) => new NetAppEndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppEndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppEndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
