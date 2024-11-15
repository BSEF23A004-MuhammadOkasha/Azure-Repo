// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The entity query kind. </summary>
    public readonly partial struct EntityTimelineKind : IEquatable<EntityTimelineKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EntityTimelineKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EntityTimelineKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActivityValue = "Activity";
        private const string BookmarkValue = "Bookmark";
        private const string SecurityAlertValue = "SecurityAlert";
        private const string AnomalyValue = "Anomaly";

        /// <summary> activity. </summary>
        public static EntityTimelineKind Activity { get; } = new EntityTimelineKind(ActivityValue);
        /// <summary> bookmarks. </summary>
        public static EntityTimelineKind Bookmark { get; } = new EntityTimelineKind(BookmarkValue);
        /// <summary> security alerts. </summary>
        public static EntityTimelineKind SecurityAlert { get; } = new EntityTimelineKind(SecurityAlertValue);
        /// <summary> anomaly. </summary>
        public static EntityTimelineKind Anomaly { get; } = new EntityTimelineKind(AnomalyValue);
        /// <summary> Determines if two <see cref="EntityTimelineKind"/> values are the same. </summary>
        public static bool operator ==(EntityTimelineKind left, EntityTimelineKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntityTimelineKind"/> values are not the same. </summary>
        public static bool operator !=(EntityTimelineKind left, EntityTimelineKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EntityTimelineKind"/>. </summary>
        public static implicit operator EntityTimelineKind(string value) => new EntityTimelineKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntityTimelineKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntityTimelineKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
