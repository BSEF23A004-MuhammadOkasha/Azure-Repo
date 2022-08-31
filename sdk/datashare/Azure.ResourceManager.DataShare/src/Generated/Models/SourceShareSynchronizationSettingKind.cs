// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Kind of synchronization setting on share. </summary>
    internal readonly partial struct SourceShareSynchronizationSettingKind : IEquatable<SourceShareSynchronizationSettingKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceShareSynchronizationSettingKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceShareSynchronizationSettingKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScheduleBasedValue = "ScheduleBased";

        /// <summary> ScheduleBased. </summary>
        public static SourceShareSynchronizationSettingKind ScheduleBased { get; } = new SourceShareSynchronizationSettingKind(ScheduleBasedValue);
        /// <summary> Determines if two <see cref="SourceShareSynchronizationSettingKind"/> values are the same. </summary>
        public static bool operator ==(SourceShareSynchronizationSettingKind left, SourceShareSynchronizationSettingKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceShareSynchronizationSettingKind"/> values are not the same. </summary>
        public static bool operator !=(SourceShareSynchronizationSettingKind left, SourceShareSynchronizationSettingKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SourceShareSynchronizationSettingKind"/>. </summary>
        public static implicit operator SourceShareSynchronizationSettingKind(string value) => new SourceShareSynchronizationSettingKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceShareSynchronizationSettingKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceShareSynchronizationSettingKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
