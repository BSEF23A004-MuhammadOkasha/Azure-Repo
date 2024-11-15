// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Variable type. </summary>
    public readonly partial struct PipelineVariableType : IEquatable<PipelineVariableType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PipelineVariableType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PipelineVariableType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "String";
        private const string BoolValue = "Bool";
        private const string ArrayValue = "Array";

        /// <summary> String. </summary>
        public static PipelineVariableType String { get; } = new PipelineVariableType(StringValue);
        /// <summary> Bool. </summary>
        public static PipelineVariableType Bool { get; } = new PipelineVariableType(BoolValue);
        /// <summary> Array. </summary>
        public static PipelineVariableType Array { get; } = new PipelineVariableType(ArrayValue);
        /// <summary> Determines if two <see cref="PipelineVariableType"/> values are the same. </summary>
        public static bool operator ==(PipelineVariableType left, PipelineVariableType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PipelineVariableType"/> values are not the same. </summary>
        public static bool operator !=(PipelineVariableType left, PipelineVariableType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PipelineVariableType"/>. </summary>
        public static implicit operator PipelineVariableType(string value) => new PipelineVariableType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PipelineVariableType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PipelineVariableType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
