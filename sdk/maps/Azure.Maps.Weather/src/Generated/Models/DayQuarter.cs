// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.Maps.Weather
{
    /// <summary> Quarter of the day. </summary>
    public readonly partial struct DayQuarter : IEquatable<DayQuarter>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="DayQuarter"/>. </summary>
        public DayQuarter(int value)
        {
            _value = value;
        }

        private const int FirstQuarterValue = 0;
        private const int SecondQuarterValue = 1;
        private const int ThirdQuarterValue = 2;
        private const int ForthQuarterValue = 3;

        /// <summary> 7:00 am - 1:00 pm / 7:00- 13:00. </summary>
        public static DayQuarter FirstQuarter { get; } = new DayQuarter(FirstQuarterValue);
        /// <summary> 1:00 pm - 7:00 pm/ 13:00- 19:00. </summary>
        public static DayQuarter SecondQuarter { get; } = new DayQuarter(SecondQuarterValue);
        /// <summary> 7:00 pm - 1:00 am/ 19:00 - 01:00. </summary>
        public static DayQuarter ThirdQuarter { get; } = new DayQuarter(ThirdQuarterValue);
        /// <summary> 1:00 am - 7:00 am/ 01:00 - 07:00. </summary>
        public static DayQuarter ForthQuarter { get; } = new DayQuarter(ForthQuarterValue);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="DayQuarter"/> values are the same. </summary>
        public static bool operator ==(DayQuarter left, DayQuarter right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DayQuarter"/> values are not the same. </summary>
        public static bool operator !=(DayQuarter left, DayQuarter right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DayQuarter"/>. </summary>
        public static implicit operator DayQuarter(int value) => new DayQuarter(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DayQuarter other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DayQuarter other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
