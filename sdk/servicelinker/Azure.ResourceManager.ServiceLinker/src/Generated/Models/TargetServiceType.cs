// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The target service type. </summary>
    internal readonly partial struct TargetServiceType : IEquatable<TargetServiceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TargetServiceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetServiceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureResourceValue = "AzureResource";
        private const string ConfluentBootstrapServerValue = "ConfluentBootstrapServer";
        private const string ConfluentSchemaRegistryValue = "ConfluentSchemaRegistry";

        /// <summary> AzureResource. </summary>
        public static TargetServiceType AzureResource { get; } = new TargetServiceType(AzureResourceValue);
        /// <summary> ConfluentBootstrapServer. </summary>
        public static TargetServiceType ConfluentBootstrapServer { get; } = new TargetServiceType(ConfluentBootstrapServerValue);
        /// <summary> ConfluentSchemaRegistry. </summary>
        public static TargetServiceType ConfluentSchemaRegistry { get; } = new TargetServiceType(ConfluentSchemaRegistryValue);
        /// <summary> Determines if two <see cref="TargetServiceType"/> values are the same. </summary>
        public static bool operator ==(TargetServiceType left, TargetServiceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetServiceType"/> values are not the same. </summary>
        public static bool operator !=(TargetServiceType left, TargetServiceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TargetServiceType"/>. </summary>
        public static implicit operator TargetServiceType(string value) => new TargetServiceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetServiceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetServiceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
