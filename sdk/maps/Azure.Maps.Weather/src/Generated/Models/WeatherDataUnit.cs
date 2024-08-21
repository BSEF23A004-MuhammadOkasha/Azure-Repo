// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Weather
{
    /// <summary> The WeatherDataUnit. </summary>
    public readonly partial struct WeatherDataUnit : IEquatable<WeatherDataUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WeatherDataUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WeatherDataUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MetricValue = "metric";
        private const string ImperialValue = "imperial";

        /// <summary> Return data in metric units. Some example units of metric system are Celsius and kilometer. </summary>
        public static WeatherDataUnit Metric { get; } = new WeatherDataUnit(MetricValue);
        /// <summary> Return data in imperial units. Some example units of imperial system are Fahrenheit and mile. </summary>
        public static WeatherDataUnit Imperial { get; } = new WeatherDataUnit(ImperialValue);
        /// <summary> Determines if two <see cref="WeatherDataUnit"/> values are the same. </summary>
        public static bool operator ==(WeatherDataUnit left, WeatherDataUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WeatherDataUnit"/> values are not the same. </summary>
        public static bool operator !=(WeatherDataUnit left, WeatherDataUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WeatherDataUnit"/>. </summary>
        public static implicit operator WeatherDataUnit(string value) => new WeatherDataUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WeatherDataUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WeatherDataUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
