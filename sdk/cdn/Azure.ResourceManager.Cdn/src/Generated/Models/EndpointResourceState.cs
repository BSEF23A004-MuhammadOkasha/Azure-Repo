// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Resource status of the endpoint. </summary>
    public readonly partial struct EndpointResourceState : IEquatable<EndpointResourceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EndpointResourceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointResourceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string RunningValue = "Running";
        private const string StartingValue = "Starting";
        private const string StoppedValue = "Stopped";
        private const string StoppingValue = "Stopping";

        /// <summary> Creating. </summary>
        public static EndpointResourceState Creating { get; } = new EndpointResourceState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static EndpointResourceState Deleting { get; } = new EndpointResourceState(DeletingValue);
        /// <summary> Running. </summary>
        public static EndpointResourceState Running { get; } = new EndpointResourceState(RunningValue);
        /// <summary> Starting. </summary>
        public static EndpointResourceState Starting { get; } = new EndpointResourceState(StartingValue);
        /// <summary> Stopped. </summary>
        public static EndpointResourceState Stopped { get; } = new EndpointResourceState(StoppedValue);
        /// <summary> Stopping. </summary>
        public static EndpointResourceState Stopping { get; } = new EndpointResourceState(StoppingValue);
        /// <summary> Determines if two <see cref="EndpointResourceState"/> values are the same. </summary>
        public static bool operator ==(EndpointResourceState left, EndpointResourceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointResourceState"/> values are not the same. </summary>
        public static bool operator !=(EndpointResourceState left, EndpointResourceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointResourceState"/>. </summary>
        public static implicit operator EndpointResourceState(string value) => new EndpointResourceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointResourceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointResourceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
