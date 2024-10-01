// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Enumerates the ways that a service can be partitioned. </summary>
    internal readonly partial struct ServiceScalingTriggerKind : IEquatable<ServiceScalingTriggerKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceScalingTriggerKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceScalingTriggerKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AveragePartitionLoadTriggerValue = "AveragePartitionLoadTrigger";
        private const string AverageServiceLoadTriggerValue = "AverageServiceLoadTrigger";

        /// <summary> Represents a scaling trigger related to an average load of a metric/resource of a partition. The value is 0. </summary>
        public static ServiceScalingTriggerKind AveragePartitionLoadTrigger { get; } = new ServiceScalingTriggerKind(AveragePartitionLoadTriggerValue);
        /// <summary> Represents a scaling policy related to an average load of a metric/resource of a service. The value is 1. </summary>
        public static ServiceScalingTriggerKind AverageServiceLoadTrigger { get; } = new ServiceScalingTriggerKind(AverageServiceLoadTriggerValue);
        /// <summary> Determines if two <see cref="ServiceScalingTriggerKind"/> values are the same. </summary>
        public static bool operator ==(ServiceScalingTriggerKind left, ServiceScalingTriggerKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceScalingTriggerKind"/> values are not the same. </summary>
        public static bool operator !=(ServiceScalingTriggerKind left, ServiceScalingTriggerKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServiceScalingTriggerKind"/>. </summary>
        public static implicit operator ServiceScalingTriggerKind(string value) => new ServiceScalingTriggerKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceScalingTriggerKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceScalingTriggerKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
