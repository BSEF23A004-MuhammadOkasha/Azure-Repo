// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Whether requests from Public Network are allowed. </summary>
    public readonly partial struct CosmosDBPublicNetworkAccess : IEquatable<CosmosDBPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";
        private const string SecuredByPerimeterValue = "SecuredByPerimeter";

        /// <summary> Enabled. </summary>
        public static CosmosDBPublicNetworkAccess Enabled { get; } = new CosmosDBPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static CosmosDBPublicNetworkAccess Disabled { get; } = new CosmosDBPublicNetworkAccess(DisabledValue);
        /// <summary> SecuredByPerimeter. </summary>
        public static CosmosDBPublicNetworkAccess SecuredByPerimeter { get; } = new CosmosDBPublicNetworkAccess(SecuredByPerimeterValue);
        /// <summary> Determines if two <see cref="CosmosDBPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(CosmosDBPublicNetworkAccess left, CosmosDBPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBPublicNetworkAccess left, CosmosDBPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CosmosDBPublicNetworkAccess"/>. </summary>
        public static implicit operator CosmosDBPublicNetworkAccess(string value) => new CosmosDBPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
