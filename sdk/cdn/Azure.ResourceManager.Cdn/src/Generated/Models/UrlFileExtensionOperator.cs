// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct UrlFileExtensionOperator : IEquatable<UrlFileExtensionOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="UrlFileExtensionOperator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UrlFileExtensionOperator(string value)
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
        public static UrlFileExtensionOperator Any { get; } = new UrlFileExtensionOperator(AnyValue);
        /// <summary> Equal. </summary>
        public static UrlFileExtensionOperator Equal { get; } = new UrlFileExtensionOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static UrlFileExtensionOperator Contains { get; } = new UrlFileExtensionOperator(ContainsValue);
        /// <summary> BeginsWith. </summary>
        public static UrlFileExtensionOperator BeginsWith { get; } = new UrlFileExtensionOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static UrlFileExtensionOperator EndsWith { get; } = new UrlFileExtensionOperator(EndsWithValue);
        /// <summary> LessThan. </summary>
        public static UrlFileExtensionOperator LessThan { get; } = new UrlFileExtensionOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static UrlFileExtensionOperator LessThanOrEqual { get; } = new UrlFileExtensionOperator(LessThanOrEqualValue);
        /// <summary> GreaterThan. </summary>
        public static UrlFileExtensionOperator GreaterThan { get; } = new UrlFileExtensionOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static UrlFileExtensionOperator GreaterThanOrEqual { get; } = new UrlFileExtensionOperator(GreaterThanOrEqualValue);
        /// <summary> RegEx. </summary>
        public static UrlFileExtensionOperator RegEx { get; } = new UrlFileExtensionOperator(RegExValue);
        /// <summary> Determines if two <see cref="UrlFileExtensionOperator"/> values are the same. </summary>
        public static bool operator ==(UrlFileExtensionOperator left, UrlFileExtensionOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UrlFileExtensionOperator"/> values are not the same. </summary>
        public static bool operator !=(UrlFileExtensionOperator left, UrlFileExtensionOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UrlFileExtensionOperator"/>. </summary>
        public static implicit operator UrlFileExtensionOperator(string value) => new UrlFileExtensionOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UrlFileExtensionOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UrlFileExtensionOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
