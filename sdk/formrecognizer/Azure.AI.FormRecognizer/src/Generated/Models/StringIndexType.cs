// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Method used to compute string offset and length. </summary>
    internal readonly partial struct StringIndexType : IEquatable<StringIndexType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StringIndexType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StringIndexType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextElementsValue = "textElements";
        private const string UnicodeCodePointValue = "unicodeCodePoint";
        private const string Utf16CodeUnitValue = "utf16CodeUnit";

        /// <summary> textElements. </summary>
        public static StringIndexType TextElements { get; } = new StringIndexType(TextElementsValue);
        /// <summary> unicodeCodePoint. </summary>
        public static StringIndexType UnicodeCodePoint { get; } = new StringIndexType(UnicodeCodePointValue);
        /// <summary> utf16CodeUnit. </summary>
        public static StringIndexType Utf16CodeUnit { get; } = new StringIndexType(Utf16CodeUnitValue);
        /// <summary> Determines if two <see cref="StringIndexType"/> values are the same. </summary>
        public static bool operator ==(StringIndexType left, StringIndexType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StringIndexType"/> values are not the same. </summary>
        public static bool operator !=(StringIndexType left, StringIndexType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StringIndexType"/>. </summary>
        public static implicit operator StringIndexType(string value) => new StringIndexType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StringIndexType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StringIndexType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
