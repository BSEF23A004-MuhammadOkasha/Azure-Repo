// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Supported protocols for the customer&apos;s endpoint. </summary>
    public readonly partial struct AFDEndpointProtocols : IEquatable<AFDEndpointProtocols>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AFDEndpointProtocols"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AFDEndpointProtocols(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "Http";
        private const string HttpsValue = "Https";

        /// <summary> Http. </summary>
        public static AFDEndpointProtocols Http { get; } = new AFDEndpointProtocols(HttpValue);
        /// <summary> Https. </summary>
        public static AFDEndpointProtocols Https { get; } = new AFDEndpointProtocols(HttpsValue);
        /// <summary> Determines if two <see cref="AFDEndpointProtocols"/> values are the same. </summary>
        public static bool operator ==(AFDEndpointProtocols left, AFDEndpointProtocols right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AFDEndpointProtocols"/> values are not the same. </summary>
        public static bool operator !=(AFDEndpointProtocols left, AFDEndpointProtocols right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AFDEndpointProtocols"/>. </summary>
        public static implicit operator AFDEndpointProtocols(string value) => new AFDEndpointProtocols(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AFDEndpointProtocols other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AFDEndpointProtocols other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
