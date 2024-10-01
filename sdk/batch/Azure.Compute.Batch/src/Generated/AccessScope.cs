// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> AccessScope enums. </summary>
    public readonly partial struct AccessScope : IEquatable<AccessScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JobValue = "job";

        /// <summary> Grants access to perform all operations on the Job containing the Task. </summary>
        public static AccessScope Job { get; } = new AccessScope(JobValue);
        /// <summary> Determines if two <see cref="AccessScope"/> values are the same. </summary>
        public static bool operator ==(AccessScope left, AccessScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessScope"/> values are not the same. </summary>
        public static bool operator !=(AccessScope left, AccessScope right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AccessScope"/>. </summary>
        public static implicit operator AccessScope(string value) => new AccessScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
