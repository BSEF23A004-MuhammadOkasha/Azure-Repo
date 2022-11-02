// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> The SchemaFormat. </summary>
    public readonly partial struct SchemaFormat : IEquatable<SchemaFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SchemaFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SchemaFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplicationJsonSerializationAvroValue = "application/json; serialization=Avro";
        private const string ApplicationJsonSerializationJsonValue = "application/json; serialization=Json";
        private const string TextPlainCharsetUtf8Value = "text/plain; charset=utf-8";

        /// <summary> application/json; serialization=Avro. </summary>
        public static SchemaFormat ApplicationJsonSerializationAvro { get; } = new SchemaFormat(ApplicationJsonSerializationAvroValue);
        /// <summary> application/json; serialization=Json. </summary>
        public static SchemaFormat ApplicationJsonSerializationJson { get; } = new SchemaFormat(ApplicationJsonSerializationJsonValue);
        /// <summary> text/plain; charset=utf-8. </summary>
        public static SchemaFormat TextPlainCharsetUtf8 { get; } = new SchemaFormat(TextPlainCharsetUtf8Value);
        /// <summary> Determines if two <see cref="SchemaFormat"/> values are the same. </summary>
        public static bool operator ==(SchemaFormat left, SchemaFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SchemaFormat"/> values are not the same. </summary>
        public static bool operator !=(SchemaFormat left, SchemaFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SchemaFormat"/>. </summary>
        public static implicit operator SchemaFormat(string value) => new SchemaFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SchemaFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SchemaFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
