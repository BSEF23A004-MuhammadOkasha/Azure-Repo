﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.Core.Serialization
{
    /// <summary>
    /// Enumerator representing format of the serialized model.
    /// </summary>
    public readonly partial struct ModelSerializerFormat : IEquatable<ModelSerializerFormat>
    {
        internal const string JsonValue = "J";
        internal const string WireValue = "W";

        /// <summary>
        /// Specifies the data format where IgnoreReadOnly and IgnoreAdditionalProperties are false.
        /// </summary>
        public static readonly ModelSerializerFormat Json = new ModelSerializerFormat(JsonValue);

        /// <summary>
        /// Specifies the wire format IgnoreReadOnly and IgnoreAdditionalProperties are true.
        /// </summary>
        public static readonly ModelSerializerFormat Wire = new ModelSerializerFormat(WireValue);

        private readonly string _value;

        /// <summary>
        /// Instantiate a new <see cref="ModelSerializerFormat"/>.
        /// </summary>
        public ModelSerializerFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Determines if two <see cref="ModelSerializerFormat"/> values are the same.
        /// </summary>
        /// <param name="left">The first <see cref="ModelSerializerFormat"/> to compare.</param>
        /// <param name="right">The second <see cref="ModelSerializerFormat"/> to compare.</param>
        /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are the same; otherwise, false.</returns>
        public static bool operator ==(ModelSerializerFormat left, ModelSerializerFormat right) => left.Equals(right);

        /// <summary>
        /// Determines if two <see cref="ModelSerializerFormat"/> values are different.
        /// </summary>
        /// <param name="left">The first <see cref="ModelSerializerFormat"/> to compare.</param>
        /// <param name="right">The second <see cref="ModelSerializerFormat"/> to compare.</param>
        /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are different; otherwise, false.</returns>
        public static bool operator !=(ModelSerializerFormat left, ModelSerializerFormat right) => !left.Equals(right);

        /// <summary>
        /// Converts a string to a <see cref="ModelSerializerFormat"/>.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        public static implicit operator ModelSerializerFormat(string value) => new ModelSerializerFormat(value);

        /// <summary>
        /// Converts a <see cref="ModelSerializerFormat"/> to a string.
        /// </summary>
        /// <param name="value">The ModelSerializerFormat value to convert.</param>
        public static implicit operator string(ModelSerializerFormat value) => value.ToString();

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals([System.Diagnostics.CodeAnalysis.AllowNull] object obj) => obj is ModelSerializerFormat other && Equals(other);

        /// <inheritdoc/>
        public bool Equals(ModelSerializerFormat other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}
