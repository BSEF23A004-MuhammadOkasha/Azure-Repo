// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Learn.Computation.Models
{
    /// <summary> The current status of the operation. </summary>
    public readonly partial struct ComputeOperationStatus : IEquatable<ComputeOperationStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ComputeOperationStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotstartedValue = "notstarted";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";

        /// <summary> notstarted. </summary>
        public static ComputeOperationStatus Notstarted { get; } = new ComputeOperationStatus(NotstartedValue);
        /// <summary> running. </summary>
        public static ComputeOperationStatus Running { get; } = new ComputeOperationStatus(RunningValue);
        /// <summary> succeeded. </summary>
        public static ComputeOperationStatus Succeeded { get; } = new ComputeOperationStatus(SucceededValue);
        /// <summary> failed. </summary>
        public static ComputeOperationStatus Failed { get; } = new ComputeOperationStatus(FailedValue);
        /// <summary> cancelled. </summary>
        public static ComputeOperationStatus Cancelled { get; } = new ComputeOperationStatus(CancelledValue);
        /// <summary> Determines if two <see cref="ComputeOperationStatus"/> values are the same. </summary>
        public static bool operator ==(ComputeOperationStatus left, ComputeOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(ComputeOperationStatus left, ComputeOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeOperationStatus"/>. </summary>
        public static implicit operator ComputeOperationStatus(string value) => new ComputeOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
