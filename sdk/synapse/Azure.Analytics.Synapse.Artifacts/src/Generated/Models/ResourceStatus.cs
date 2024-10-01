// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Enumerates possible Status of the resource. </summary>
    public readonly partial struct ResourceStatus : IEquatable<ResourceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string CreatedValue = "Created";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static ResourceStatus Creating { get; } = new ResourceStatus(CreatingValue);
        /// <summary> Created. </summary>
        public static ResourceStatus Created { get; } = new ResourceStatus(CreatedValue);
        /// <summary> Failed. </summary>
        public static ResourceStatus Failed { get; } = new ResourceStatus(FailedValue);
        /// <summary> Determines if two <see cref="ResourceStatus"/> values are the same. </summary>
        public static bool operator ==(ResourceStatus left, ResourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceStatus"/> values are not the same. </summary>
        public static bool operator !=(ResourceStatus left, ResourceStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResourceStatus"/>. </summary>
        public static implicit operator ResourceStatus(string value) => new ResourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
