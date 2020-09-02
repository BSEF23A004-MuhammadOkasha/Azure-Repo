// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Health of backend server. </summary>
    public readonly partial struct ApplicationGatewayBackendHealthServerHealth : IEquatable<ApplicationGatewayBackendHealthServerHealth>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationGatewayBackendHealthServerHealth"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayBackendHealthServerHealth(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string UpValue = "Up";
        private const string DownValue = "Down";
        private const string PartialValue = "Partial";
        private const string DrainingValue = "Draining";

        /// <summary> Unknown. </summary>
        public static ApplicationGatewayBackendHealthServerHealth Unknown { get; } = new ApplicationGatewayBackendHealthServerHealth(UnknownValue);
        /// <summary> Up. </summary>
        public static ApplicationGatewayBackendHealthServerHealth Up { get; } = new ApplicationGatewayBackendHealthServerHealth(UpValue);
        /// <summary> Down. </summary>
        public static ApplicationGatewayBackendHealthServerHealth Down { get; } = new ApplicationGatewayBackendHealthServerHealth(DownValue);
        /// <summary> Partial. </summary>
        public static ApplicationGatewayBackendHealthServerHealth Partial { get; } = new ApplicationGatewayBackendHealthServerHealth(PartialValue);
        /// <summary> Draining. </summary>
        public static ApplicationGatewayBackendHealthServerHealth Draining { get; } = new ApplicationGatewayBackendHealthServerHealth(DrainingValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayBackendHealthServerHealth"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayBackendHealthServerHealth left, ApplicationGatewayBackendHealthServerHealth right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayBackendHealthServerHealth"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayBackendHealthServerHealth left, ApplicationGatewayBackendHealthServerHealth right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayBackendHealthServerHealth"/>. </summary>
        public static implicit operator ApplicationGatewayBackendHealthServerHealth(string value) => new ApplicationGatewayBackendHealthServerHealth(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayBackendHealthServerHealth other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayBackendHealthServerHealth other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
