// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Replica commit mode in availability group. </summary>
    public readonly partial struct AvailabilityGroupReplicaCommitMode : IEquatable<AvailabilityGroupReplicaCommitMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupReplicaCommitMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvailabilityGroupReplicaCommitMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SynchronousCommitValue = "SYNCHRONOUS_COMMIT";
        private const string AsynchronousCommitValue = "ASYNCHRONOUS_COMMIT";

        /// <summary> SYNCHRONOUS_COMMIT. </summary>
        public static AvailabilityGroupReplicaCommitMode SynchronousCommit { get; } = new AvailabilityGroupReplicaCommitMode(SynchronousCommitValue);
        /// <summary> ASYNCHRONOUS_COMMIT. </summary>
        public static AvailabilityGroupReplicaCommitMode AsynchronousCommit { get; } = new AvailabilityGroupReplicaCommitMode(AsynchronousCommitValue);
        /// <summary> Determines if two <see cref="AvailabilityGroupReplicaCommitMode"/> values are the same. </summary>
        public static bool operator ==(AvailabilityGroupReplicaCommitMode left, AvailabilityGroupReplicaCommitMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvailabilityGroupReplicaCommitMode"/> values are not the same. </summary>
        public static bool operator !=(AvailabilityGroupReplicaCommitMode left, AvailabilityGroupReplicaCommitMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AvailabilityGroupReplicaCommitMode"/>. </summary>
        public static implicit operator AvailabilityGroupReplicaCommitMode(string value) => new AvailabilityGroupReplicaCommitMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvailabilityGroupReplicaCommitMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvailabilityGroupReplicaCommitMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
