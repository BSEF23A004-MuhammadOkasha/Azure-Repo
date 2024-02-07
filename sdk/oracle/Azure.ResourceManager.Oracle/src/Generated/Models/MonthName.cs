// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Oracle.Models
{
    /// <summary> MonthName enum. </summary>
    public readonly partial struct MonthName : IEquatable<MonthName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonthName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonthName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JanuaryValue = "January";
        private const string FebruaryValue = "February";
        private const string MarchValue = "March";
        private const string AprilValue = "April";
        private const string MayValue = "May";
        private const string JuneValue = "June";
        private const string JulyValue = "July";
        private const string AugustValue = "August";
        private const string SeptemberValue = "September";
        private const string OctoberValue = "October";
        private const string NovemberValue = "November";
        private const string DecemberValue = "December";

        /// <summary> January value. </summary>
        public static MonthName January { get; } = new MonthName(JanuaryValue);
        /// <summary> February value. </summary>
        public static MonthName February { get; } = new MonthName(FebruaryValue);
        /// <summary> March value. </summary>
        public static MonthName March { get; } = new MonthName(MarchValue);
        /// <summary> April value. </summary>
        public static MonthName April { get; } = new MonthName(AprilValue);
        /// <summary> May value. </summary>
        public static MonthName May { get; } = new MonthName(MayValue);
        /// <summary> June value. </summary>
        public static MonthName June { get; } = new MonthName(JuneValue);
        /// <summary> July value. </summary>
        public static MonthName July { get; } = new MonthName(JulyValue);
        /// <summary> August value. </summary>
        public static MonthName August { get; } = new MonthName(AugustValue);
        /// <summary> September value. </summary>
        public static MonthName September { get; } = new MonthName(SeptemberValue);
        /// <summary> October value. </summary>
        public static MonthName October { get; } = new MonthName(OctoberValue);
        /// <summary> November value. </summary>
        public static MonthName November { get; } = new MonthName(NovemberValue);
        /// <summary> December value. </summary>
        public static MonthName December { get; } = new MonthName(DecemberValue);
        /// <summary> Determines if two <see cref="MonthName"/> values are the same. </summary>
        public static bool operator ==(MonthName left, MonthName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonthName"/> values are not the same. </summary>
        public static bool operator !=(MonthName left, MonthName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonthName"/>. </summary>
        public static implicit operator MonthName(string value) => new MonthName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonthName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonthName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
