// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary>
    /// The type of the secret object which determines how the value of the secret object has to be
    /// interpreted.
    /// </summary>
    public readonly partial struct ContainerRegistrySecretObjectType : IEquatable<ContainerRegistrySecretObjectType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySecretObjectType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistrySecretObjectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OpaqueValue = "Opaque";
        private const string VaultSecretValue = "Vaultsecret";

        /// <summary> Opaque. </summary>
        public static ContainerRegistrySecretObjectType Opaque { get; } = new ContainerRegistrySecretObjectType(OpaqueValue);
        /// <summary> Vaultsecret. </summary>
        public static ContainerRegistrySecretObjectType VaultSecret { get; } = new ContainerRegistrySecretObjectType(VaultSecretValue);
        /// <summary> Determines if two <see cref="ContainerRegistrySecretObjectType"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistrySecretObjectType left, ContainerRegistrySecretObjectType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistrySecretObjectType"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistrySecretObjectType left, ContainerRegistrySecretObjectType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistrySecretObjectType"/>. </summary>
        public static implicit operator ContainerRegistrySecretObjectType(string value) => new ContainerRegistrySecretObjectType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistrySecretObjectType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistrySecretObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
