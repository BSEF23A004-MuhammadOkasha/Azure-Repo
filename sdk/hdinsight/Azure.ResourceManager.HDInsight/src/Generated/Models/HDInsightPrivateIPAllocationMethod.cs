// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The method that private IP address is allocated. </summary>
    public readonly partial struct HDInsightPrivateIPAllocationMethod : IEquatable<HDInsightPrivateIPAllocationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightPrivateIPAllocationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightPrivateIPAllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DynamicValue = "dynamic";
        private const string StaticValue = "static";

        /// <summary> dynamic. </summary>
        public static HDInsightPrivateIPAllocationMethod Dynamic { get; } = new HDInsightPrivateIPAllocationMethod(DynamicValue);
        /// <summary> static. </summary>
        public static HDInsightPrivateIPAllocationMethod Static { get; } = new HDInsightPrivateIPAllocationMethod(StaticValue);
        /// <summary> Determines if two <see cref="HDInsightPrivateIPAllocationMethod"/> values are the same. </summary>
        public static bool operator ==(HDInsightPrivateIPAllocationMethod left, HDInsightPrivateIPAllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightPrivateIPAllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(HDInsightPrivateIPAllocationMethod left, HDInsightPrivateIPAllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HDInsightPrivateIPAllocationMethod"/>. </summary>
        public static implicit operator HDInsightPrivateIPAllocationMethod(string value) => new HDInsightPrivateIPAllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightPrivateIPAllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightPrivateIPAllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
