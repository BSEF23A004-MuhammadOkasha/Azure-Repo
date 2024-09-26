// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Type of the elastic filter. </summary>
    public readonly partial struct ElasticModelType : IEquatable<ElasticModelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticModelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPValue = "ip";
        private const string AzurePrivateEndpointValue = "azure_private_endpoint";

        /// <summary> ip. </summary>
        public static ElasticModelType IP { get; } = new ElasticModelType(IPValue);
        /// <summary> azure_private_endpoint. </summary>
        public static ElasticModelType AzurePrivateEndpoint { get; } = new ElasticModelType(AzurePrivateEndpointValue);
        /// <summary> Determines if two <see cref="ElasticModelType"/> values are the same. </summary>
        public static bool operator ==(ElasticModelType left, ElasticModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticModelType"/> values are not the same. </summary>
        public static bool operator !=(ElasticModelType left, ElasticModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ElasticModelType"/>. </summary>
        public static implicit operator ElasticModelType(string value) => new ElasticModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
