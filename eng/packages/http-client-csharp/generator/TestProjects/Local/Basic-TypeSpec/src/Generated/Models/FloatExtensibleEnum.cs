// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace BasicTypeSpec.Models
{
    /// <summary> Float based extensible enum. </summary>
    public readonly partial struct FloatExtensibleEnum : IEquatable<FloatExtensibleEnum>
    {
        private readonly float _value;
        private const float OneDotOneValue = 1.1F;
        private const float TwoDotTwoValue = 2.2F;
        private const float FourDotFourValue = 4.4F;

        /// <summary> Initializes a new instance of <see cref="FloatExtensibleEnum"/>. </summary>
        /// <param name="value"> The value. </param>
        public FloatExtensibleEnum(float value)
        {
            _value = value;
        }

        /// <summary> Gets the OneDotOne. </summary>
        public static FloatExtensibleEnum OneDotOne { get; } = new FloatExtensibleEnum(OneDotOneValue);

        /// <summary> Gets the TwoDotTwo. </summary>
        public static FloatExtensibleEnum TwoDotTwo { get; } = new FloatExtensibleEnum(TwoDotTwoValue);

        /// <summary> Gets the FourDotFour. </summary>
        public static FloatExtensibleEnum FourDotFour { get; } = new FloatExtensibleEnum(FourDotFourValue);

        /// <summary> Determines if two <see cref="FloatExtensibleEnum"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(FloatExtensibleEnum left, FloatExtensibleEnum right) => left.Equals(right);

        /// <summary> Determines if two <see cref="FloatExtensibleEnum"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(FloatExtensibleEnum left, FloatExtensibleEnum right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="FloatExtensibleEnum"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator FloatExtensibleEnum(float value) => new FloatExtensibleEnum(value);

        /// <param name="obj"> The object to compare. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FloatExtensibleEnum other && Equals(other);

        /// <param name="other"> The instance to compare. </param>
        public bool Equals(FloatExtensibleEnum other) => Equals(_value, other._value);

        /// <inheritdoc/>
        public override int GetHashCode() => _value.GetHashCode();

        /// <inheritdoc/>
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
