// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RequestSchemeMatchConditionParametersMatchValuesItem. </summary>
    public readonly partial struct RequestSchemeMatchConditionParametersMatchValuesItem : IEquatable<RequestSchemeMatchConditionParametersMatchValuesItem>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RequestSchemeMatchConditionParametersMatchValuesItem"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestSchemeMatchConditionParametersMatchValuesItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "HTTP";
        private const string HttpsValue = "HTTPS";

        /// <summary> HTTP. </summary>
        public static RequestSchemeMatchConditionParametersMatchValuesItem Http { get; } = new RequestSchemeMatchConditionParametersMatchValuesItem(HttpValue);
        /// <summary> HTTPS. </summary>
        public static RequestSchemeMatchConditionParametersMatchValuesItem Https { get; } = new RequestSchemeMatchConditionParametersMatchValuesItem(HttpsValue);
        /// <summary> Determines if two <see cref="RequestSchemeMatchConditionParametersMatchValuesItem"/> values are the same. </summary>
        public static bool operator ==(RequestSchemeMatchConditionParametersMatchValuesItem left, RequestSchemeMatchConditionParametersMatchValuesItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestSchemeMatchConditionParametersMatchValuesItem"/> values are not the same. </summary>
        public static bool operator !=(RequestSchemeMatchConditionParametersMatchValuesItem left, RequestSchemeMatchConditionParametersMatchValuesItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RequestSchemeMatchConditionParametersMatchValuesItem"/>. </summary>
        public static implicit operator RequestSchemeMatchConditionParametersMatchValuesItem(string value) => new RequestSchemeMatchConditionParametersMatchValuesItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestSchemeMatchConditionParametersMatchValuesItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestSchemeMatchConditionParametersMatchValuesItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
