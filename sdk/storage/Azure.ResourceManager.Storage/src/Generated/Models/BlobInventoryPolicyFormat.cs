// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> This is a required field, it specifies the format for the inventory files. </summary>
    public readonly partial struct BlobInventoryPolicyFormat : IEquatable<BlobInventoryPolicyFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobInventoryPolicyFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CsvValue = "Csv";
        private const string ParquetValue = "Parquet";

        /// <summary> Csv. </summary>
        public static BlobInventoryPolicyFormat Csv { get; } = new BlobInventoryPolicyFormat(CsvValue);
        /// <summary> Parquet. </summary>
        public static BlobInventoryPolicyFormat Parquet { get; } = new BlobInventoryPolicyFormat(ParquetValue);
        /// <summary> Determines if two <see cref="BlobInventoryPolicyFormat"/> values are the same. </summary>
        public static bool operator ==(BlobInventoryPolicyFormat left, BlobInventoryPolicyFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobInventoryPolicyFormat"/> values are not the same. </summary>
        public static bool operator !=(BlobInventoryPolicyFormat left, BlobInventoryPolicyFormat right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BlobInventoryPolicyFormat"/>. </summary>
        public static implicit operator BlobInventoryPolicyFormat(string value) => new BlobInventoryPolicyFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobInventoryPolicyFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobInventoryPolicyFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
