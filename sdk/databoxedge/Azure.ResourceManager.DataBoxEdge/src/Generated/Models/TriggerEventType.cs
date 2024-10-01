// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Trigger Kind. </summary>
    internal readonly partial struct TriggerEventType : IEquatable<TriggerEventType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TriggerEventType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TriggerEventType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileEventValue = "FileEvent";
        private const string PeriodicTimerEventValue = "PeriodicTimerEvent";

        /// <summary> FileEvent. </summary>
        public static TriggerEventType FileEvent { get; } = new TriggerEventType(FileEventValue);
        /// <summary> PeriodicTimerEvent. </summary>
        public static TriggerEventType PeriodicTimerEvent { get; } = new TriggerEventType(PeriodicTimerEventValue);
        /// <summary> Determines if two <see cref="TriggerEventType"/> values are the same. </summary>
        public static bool operator ==(TriggerEventType left, TriggerEventType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TriggerEventType"/> values are not the same. </summary>
        public static bool operator !=(TriggerEventType left, TriggerEventType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TriggerEventType"/>. </summary>
        public static implicit operator TriggerEventType(string value) => new TriggerEventType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TriggerEventType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TriggerEventType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
