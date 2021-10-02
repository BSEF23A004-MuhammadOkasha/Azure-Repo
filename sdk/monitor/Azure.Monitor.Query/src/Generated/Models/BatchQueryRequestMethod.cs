// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The BatchQueryRequestMethod. </summary>
    public readonly partial struct BatchQueryRequestMethod : IEquatable<BatchQueryRequestMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchQueryRequestMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchQueryRequestMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PostValue = "POST";

        /// <summary> POST. </summary>
        public static BatchQueryRequestMethod Post { get; } = new BatchQueryRequestMethod(PostValue);
        /// <summary> Determines if two <see cref="BatchQueryRequestMethod"/> values are the same. </summary>
        public static bool operator ==(BatchQueryRequestMethod left, BatchQueryRequestMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchQueryRequestMethod"/> values are not the same. </summary>
        public static bool operator !=(BatchQueryRequestMethod left, BatchQueryRequestMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BatchQueryRequestMethod"/>. </summary>
        public static implicit operator BatchQueryRequestMethod(string value) => new BatchQueryRequestMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchQueryRequestMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchQueryRequestMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
