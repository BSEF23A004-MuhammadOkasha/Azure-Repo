// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search.Models
{
    /// <summary> The ResultTypeEnum. </summary>
    public readonly partial struct ResultTypeEnum : IEquatable<ResultTypeEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResultTypeEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResultTypeEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AddressValue = "Address";
        private const string NeighborhoodValue = "Neighborhood";
        private const string PopulatedPlaceValue = "PopulatedPlace";
        private const string Postcode1Value = "Postcode1";
        private const string AdminDivision1Value = "AdminDivision1";
        private const string AdminDivision2Value = "AdminDivision2";
        private const string CountryRegionValue = "CountryRegion";

        /// <summary> Address. </summary>
        public static ResultTypeEnum Address { get; } = new ResultTypeEnum(AddressValue);
        /// <summary> Neighborhood. </summary>
        public static ResultTypeEnum Neighborhood { get; } = new ResultTypeEnum(NeighborhoodValue);
        /// <summary> PopulatedPlace. </summary>
        public static ResultTypeEnum PopulatedPlace { get; } = new ResultTypeEnum(PopulatedPlaceValue);
        /// <summary> Postcode1. </summary>
        public static ResultTypeEnum Postcode1 { get; } = new ResultTypeEnum(Postcode1Value);
        /// <summary> AdminDivision1. </summary>
        public static ResultTypeEnum AdminDivision1 { get; } = new ResultTypeEnum(AdminDivision1Value);
        /// <summary> AdminDivision2. </summary>
        public static ResultTypeEnum AdminDivision2 { get; } = new ResultTypeEnum(AdminDivision2Value);
        /// <summary> CountryRegion. </summary>
        public static ResultTypeEnum CountryRegion { get; } = new ResultTypeEnum(CountryRegionValue);
        /// <summary> Determines if two <see cref="ResultTypeEnum"/> values are the same. </summary>
        public static bool operator ==(ResultTypeEnum left, ResultTypeEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResultTypeEnum"/> values are not the same. </summary>
        public static bool operator !=(ResultTypeEnum left, ResultTypeEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResultTypeEnum"/>. </summary>
        public static implicit operator ResultTypeEnum(string value) => new ResultTypeEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResultTypeEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResultTypeEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
