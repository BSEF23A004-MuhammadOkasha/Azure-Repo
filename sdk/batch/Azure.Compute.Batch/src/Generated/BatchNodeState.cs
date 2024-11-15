// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> BatchNodeState enums. </summary>
    public readonly partial struct BatchNodeState : IEquatable<BatchNodeState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchNodeState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchNodeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IdleValue = "idle";
        private const string RebootingValue = "rebooting";
        private const string ReimagingValue = "reimaging";
        private const string RunningValue = "running";
        private const string UnusableValue = "unusable";
        private const string CreatingValue = "creating";
        private const string StartingValue = "starting";
        private const string WaitingForStartTaskValue = "waitingforstarttask";
        private const string StartTaskFailedValue = "starttaskfailed";
        private const string UnknownValue = "unknown";
        private const string LeavingPoolValue = "leavingpool";
        private const string OfflineValue = "offline";
        private const string PreemptedValue = "preempted";
        private const string UpgradingOSValue = "upgradingos";

        /// <summary> The Compute Node is not currently running a Task. </summary>
        public static BatchNodeState Idle { get; } = new BatchNodeState(IdleValue);
        /// <summary> The Compute Node is rebooting. </summary>
        public static BatchNodeState Rebooting { get; } = new BatchNodeState(RebootingValue);
        /// <summary> The Compute Node is reimaging. </summary>
        public static BatchNodeState Reimaging { get; } = new BatchNodeState(ReimagingValue);
        /// <summary> The Compute Node is running one or more Tasks (other than a StartTask). </summary>
        public static BatchNodeState Running { get; } = new BatchNodeState(RunningValue);
        /// <summary> The Compute Node cannot be used for Task execution due to errors. </summary>
        public static BatchNodeState Unusable { get; } = new BatchNodeState(UnusableValue);
        /// <summary> The Batch service has obtained the underlying virtual machine from Azure Compute, but it has not yet started to join the Pool. </summary>
        public static BatchNodeState Creating { get; } = new BatchNodeState(CreatingValue);
        /// <summary> The Batch service is starting on the underlying virtual machine. </summary>
        public static BatchNodeState Starting { get; } = new BatchNodeState(StartingValue);
        /// <summary> The StartTask has started running on the Compute Node, but waitForSuccess is set and the StartTask has not yet completed. </summary>
        public static BatchNodeState WaitingForStartTask { get; } = new BatchNodeState(WaitingForStartTaskValue);
        /// <summary> The StartTask has failed on the Compute Node (and exhausted all retries), and waitForSuccess is set. The Compute Node is not usable for running Tasks. </summary>
        public static BatchNodeState StartTaskFailed { get; } = new BatchNodeState(StartTaskFailedValue);
        /// <summary> The Batch service has lost contact with the Compute Node, and does not know its true state. </summary>
        public static BatchNodeState Unknown { get; } = new BatchNodeState(UnknownValue);
        /// <summary> The Compute Node is leaving the Pool, either because the user explicitly removed it or because the Pool is resizing or autoscaling down. </summary>
        public static BatchNodeState LeavingPool { get; } = new BatchNodeState(LeavingPoolValue);
        /// <summary> The Compute Node is not currently running a Task, and scheduling of new Tasks to the Compute Node is disabled. </summary>
        public static BatchNodeState Offline { get; } = new BatchNodeState(OfflineValue);
        /// <summary> The Spot/Low-priority Compute Node has been preempted. Tasks which were running on the Compute Node when it was preempted will be rescheduled when another Compute Node becomes available. </summary>
        public static BatchNodeState Preempted { get; } = new BatchNodeState(PreemptedValue);
        /// <summary> The Compute Node is undergoing an OS upgrade operation. </summary>
        public static BatchNodeState UpgradingOS { get; } = new BatchNodeState(UpgradingOSValue);
        /// <summary> Determines if two <see cref="BatchNodeState"/> values are the same. </summary>
        public static bool operator ==(BatchNodeState left, BatchNodeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchNodeState"/> values are not the same. </summary>
        public static bool operator !=(BatchNodeState left, BatchNodeState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchNodeState"/>. </summary>
        public static implicit operator BatchNodeState(string value) => new BatchNodeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchNodeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchNodeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
