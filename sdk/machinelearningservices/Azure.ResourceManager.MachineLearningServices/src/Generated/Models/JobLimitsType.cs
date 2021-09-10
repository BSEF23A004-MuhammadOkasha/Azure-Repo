// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The JobLimitsType. </summary>
    public readonly partial struct JobLimitsType : IEquatable<JobLimitsType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobLimitsType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobLimitsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CommandValue = "Command";
        private const string SweepValue = "Sweep";

        /// <summary> Command. </summary>
        public static JobLimitsType Command { get; } = new JobLimitsType(CommandValue);
        /// <summary> Sweep. </summary>
        public static JobLimitsType Sweep { get; } = new JobLimitsType(SweepValue);
        /// <summary> Determines if two <see cref="JobLimitsType"/> values are the same. </summary>
        public static bool operator ==(JobLimitsType left, JobLimitsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobLimitsType"/> values are not the same. </summary>
        public static bool operator !=(JobLimitsType left, JobLimitsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobLimitsType"/>. </summary>
        public static implicit operator JobLimitsType(string value) => new JobLimitsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobLimitsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobLimitsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
