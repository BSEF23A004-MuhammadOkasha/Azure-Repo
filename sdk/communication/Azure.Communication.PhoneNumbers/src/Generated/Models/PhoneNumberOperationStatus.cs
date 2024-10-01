// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Status of operation. </summary>
    internal readonly partial struct PhoneNumberOperationStatus : IEquatable<PhoneNumberOperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberOperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhoneNumberOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "notStarted";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string FailedValue = "failed";

        /// <summary> notStarted. </summary>
        public static PhoneNumberOperationStatus NotStarted { get; } = new PhoneNumberOperationStatus(NotStartedValue);
        /// <summary> running. </summary>
        public static PhoneNumberOperationStatus Running { get; } = new PhoneNumberOperationStatus(RunningValue);
        /// <summary> succeeded. </summary>
        public static PhoneNumberOperationStatus Succeeded { get; } = new PhoneNumberOperationStatus(SucceededValue);
        /// <summary> failed. </summary>
        public static PhoneNumberOperationStatus Failed { get; } = new PhoneNumberOperationStatus(FailedValue);
        /// <summary> Determines if two <see cref="PhoneNumberOperationStatus"/> values are the same. </summary>
        public static bool operator ==(PhoneNumberOperationStatus left, PhoneNumberOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhoneNumberOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(PhoneNumberOperationStatus left, PhoneNumberOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PhoneNumberOperationStatus"/>. </summary>
        public static implicit operator PhoneNumberOperationStatus(string value) => new PhoneNumberOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhoneNumberOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhoneNumberOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
