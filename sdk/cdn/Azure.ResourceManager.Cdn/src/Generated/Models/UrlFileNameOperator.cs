// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct UrlFileNameOperator : IEquatable<UrlFileNameOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="UrlFileNameOperator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UrlFileNameOperator(string value)
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
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static UrlFileNameOperator Any { get; } = new UrlFileNameOperator(AnyValue);
        /// <summary> Equal. </summary>
        public static UrlFileNameOperator Equal { get; } = new UrlFileNameOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static UrlFileNameOperator Contains { get; } = new UrlFileNameOperator(ContainsValue);
        /// <summary> BeginsWith. </summary>
        public static UrlFileNameOperator BeginsWith { get; } = new UrlFileNameOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static UrlFileNameOperator EndsWith { get; } = new UrlFileNameOperator(EndsWithValue);
        /// <summary> LessThan. </summary>
        public static UrlFileNameOperator LessThan { get; } = new UrlFileNameOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static UrlFileNameOperator LessThanOrEqual { get; } = new UrlFileNameOperator(LessThanOrEqualValue);
        /// <summary> GreaterThan. </summary>
        public static UrlFileNameOperator GreaterThan { get; } = new UrlFileNameOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static UrlFileNameOperator GreaterThanOrEqual { get; } = new UrlFileNameOperator(GreaterThanOrEqualValue);
        /// <summary> RegEx. </summary>
        public static UrlFileNameOperator RegEx { get; } = new UrlFileNameOperator(RegExValue);
        /// <summary> Determines if two <see cref="UrlFileNameOperator"/> values are the same. </summary>
        public static bool operator ==(UrlFileNameOperator left, UrlFileNameOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UrlFileNameOperator"/> values are not the same. </summary>
        public static bool operator !=(UrlFileNameOperator left, UrlFileNameOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UrlFileNameOperator"/>. </summary>
        public static implicit operator UrlFileNameOperator(string value) => new UrlFileNameOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UrlFileNameOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UrlFileNameOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
