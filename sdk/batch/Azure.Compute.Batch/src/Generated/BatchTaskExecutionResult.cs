// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> BatchTaskExecutionResult enums. </summary>
    public readonly partial struct BatchTaskExecutionResult : IEquatable<BatchTaskExecutionResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchTaskExecutionResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchTaskExecutionResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SuccessValue = "success";
        private const string FailureValue = "failure";

        /// <summary> The Task ran successfully. </summary>
        public static BatchTaskExecutionResult Success { get; } = new BatchTaskExecutionResult(SuccessValue);
        /// <summary> There was an error during processing of the Task. The failure may have occurred before the Task process was launched, while the Task process was executing, or after the Task process exited. </summary>
        public static BatchTaskExecutionResult Failure { get; } = new BatchTaskExecutionResult(FailureValue);
        /// <summary> Determines if two <see cref="BatchTaskExecutionResult"/> values are the same. </summary>
        public static bool operator ==(BatchTaskExecutionResult left, BatchTaskExecutionResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchTaskExecutionResult"/> values are not the same. </summary>
        public static bool operator !=(BatchTaskExecutionResult left, BatchTaskExecutionResult right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchTaskExecutionResult"/>. </summary>
        public static implicit operator BatchTaskExecutionResult(string value) => new BatchTaskExecutionResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchTaskExecutionResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchTaskExecutionResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
