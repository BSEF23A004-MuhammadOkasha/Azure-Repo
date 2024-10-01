// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct UriPathOperator : IEquatable<UriPathOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UriPathOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UriPathOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string LessThanValue = "LessThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string WildcardValue = "Wildcard";
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static UriPathOperator Any { get; } = new UriPathOperator(AnyValue);
        /// <summary> Equal. </summary>
        public static UriPathOperator Equal { get; } = new UriPathOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static UriPathOperator Contains { get; } = new UriPathOperator(ContainsValue);
        /// <summary> BeginsWith. </summary>
        public static UriPathOperator BeginsWith { get; } = new UriPathOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static UriPathOperator EndsWith { get; } = new UriPathOperator(EndsWithValue);
        /// <summary> LessThan. </summary>
        public static UriPathOperator LessThan { get; } = new UriPathOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static UriPathOperator LessThanOrEqual { get; } = new UriPathOperator(LessThanOrEqualValue);
        /// <summary> GreaterThan. </summary>
        public static UriPathOperator GreaterThan { get; } = new UriPathOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static UriPathOperator GreaterThanOrEqual { get; } = new UriPathOperator(GreaterThanOrEqualValue);
        /// <summary> Wildcard. </summary>
        public static UriPathOperator Wildcard { get; } = new UriPathOperator(WildcardValue);
        /// <summary> RegEx. </summary>
        public static UriPathOperator RegEx { get; } = new UriPathOperator(RegExValue);
        /// <summary> Determines if two <see cref="UriPathOperator"/> values are the same. </summary>
        public static bool operator ==(UriPathOperator left, UriPathOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UriPathOperator"/> values are not the same. </summary>
        public static bool operator !=(UriPathOperator left, UriPathOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="UriPathOperator"/>. </summary>
        public static implicit operator UriPathOperator(string value) => new UriPathOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UriPathOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UriPathOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
