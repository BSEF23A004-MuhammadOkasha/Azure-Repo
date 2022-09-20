// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Status of the connection. </summary>
    public readonly partial struct EventGridPrivateEndpointPersistedConnectionStatus : IEquatable<EventGridPrivateEndpointPersistedConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridPrivateEndpointPersistedConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridPrivateEndpointPersistedConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static EventGridPrivateEndpointPersistedConnectionStatus Pending { get; } = new EventGridPrivateEndpointPersistedConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static EventGridPrivateEndpointPersistedConnectionStatus Approved { get; } = new EventGridPrivateEndpointPersistedConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static EventGridPrivateEndpointPersistedConnectionStatus Rejected { get; } = new EventGridPrivateEndpointPersistedConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static EventGridPrivateEndpointPersistedConnectionStatus Disconnected { get; } = new EventGridPrivateEndpointPersistedConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="EventGridPrivateEndpointPersistedConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(EventGridPrivateEndpointPersistedConnectionStatus left, EventGridPrivateEndpointPersistedConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridPrivateEndpointPersistedConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(EventGridPrivateEndpointPersistedConnectionStatus left, EventGridPrivateEndpointPersistedConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventGridPrivateEndpointPersistedConnectionStatus"/>. </summary>
        public static implicit operator EventGridPrivateEndpointPersistedConnectionStatus(string value) => new EventGridPrivateEndpointPersistedConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridPrivateEndpointPersistedConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridPrivateEndpointPersistedConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
