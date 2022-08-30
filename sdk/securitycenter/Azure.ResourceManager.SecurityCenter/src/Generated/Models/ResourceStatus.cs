// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The status of the resource regarding a single assessment. </summary>
    public readonly partial struct ResourceStatus : IEquatable<ResourceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HealthyValue = "Healthy";
        private const string NotApplicableValue = "NotApplicable";
        private const string OffByPolicyValue = "OffByPolicy";
        private const string NotHealthyValue = "NotHealthy";

        /// <summary> This assessment on the resource is healthy. </summary>
        public static ResourceStatus Healthy { get; } = new ResourceStatus(HealthyValue);
        /// <summary> This assessment is not applicable to this resource. </summary>
        public static ResourceStatus NotApplicable { get; } = new ResourceStatus(NotApplicableValue);
        /// <summary> This assessment is turned off by policy on this subscription. </summary>
        public static ResourceStatus OffByPolicy { get; } = new ResourceStatus(OffByPolicyValue);
        /// <summary> This assessment on the resource is not healthy. </summary>
        public static ResourceStatus NotHealthy { get; } = new ResourceStatus(NotHealthyValue);
        /// <summary> Determines if two <see cref="ResourceStatus"/> values are the same. </summary>
        public static bool operator ==(ResourceStatus left, ResourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceStatus"/> values are not the same. </summary>
        public static bool operator !=(ResourceStatus left, ResourceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceStatus"/>. </summary>
        public static implicit operator ResourceStatus(string value) => new ResourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
