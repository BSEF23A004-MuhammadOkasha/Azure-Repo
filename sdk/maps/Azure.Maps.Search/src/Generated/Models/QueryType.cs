// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search.Models
{
    /// <summary> The type of query being returned: NEARBY or NON_NEAR. </summary>
    public readonly partial struct QueryType : IEquatable<QueryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NearbyValue = "NEARBY";
        private const string GlobalValue = "NON_NEAR";

        /// <summary> Search was performed around a certain latitude and longitude with a defined radius. </summary>
        public static QueryType Nearby { get; } = new QueryType(NearbyValue);
        /// <summary> Search was performed globally, without biasing to a certain latitude and longitude, and no defined radius. </summary>
        public static QueryType Global { get; } = new QueryType(GlobalValue);
        /// <summary> Determines if two <see cref="QueryType"/> values are the same. </summary>
        public static bool operator ==(QueryType left, QueryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryType"/> values are not the same. </summary>
        public static bool operator !=(QueryType left, QueryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryType"/>. </summary>
        public static implicit operator QueryType(string value) => new QueryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
