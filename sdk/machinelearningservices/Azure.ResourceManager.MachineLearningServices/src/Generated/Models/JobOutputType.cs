// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Enum to determine the Job Output Type. </summary>
    public readonly partial struct JobOutputType : IEquatable<JobOutputType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobOutputType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobOutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UriValue = "Uri";
        private const string DatasetValue = "Dataset";

        /// <summary> Uri. </summary>
        public static JobOutputType Uri { get; } = new JobOutputType(UriValue);
        /// <summary> Dataset. </summary>
        public static JobOutputType Dataset { get; } = new JobOutputType(DatasetValue);
        /// <summary> Determines if two <see cref="JobOutputType"/> values are the same. </summary>
        public static bool operator ==(JobOutputType left, JobOutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobOutputType"/> values are not the same. </summary>
        public static bool operator !=(JobOutputType left, JobOutputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobOutputType"/>. </summary>
        public static implicit operator JobOutputType(string value) => new JobOutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobOutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobOutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
