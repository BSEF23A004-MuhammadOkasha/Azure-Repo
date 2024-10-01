// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Voice kind type. </summary>
    public readonly partial struct VoiceKind : IEquatable<VoiceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VoiceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VoiceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MaleValue = "male";
        private const string FemaleValue = "female";

        /// <summary> male. </summary>
        public static VoiceKind Male { get; } = new VoiceKind(MaleValue);
        /// <summary> female. </summary>
        public static VoiceKind Female { get; } = new VoiceKind(FemaleValue);
        /// <summary> Determines if two <see cref="VoiceKind"/> values are the same. </summary>
        public static bool operator ==(VoiceKind left, VoiceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VoiceKind"/> values are not the same. </summary>
        public static bool operator !=(VoiceKind left, VoiceKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VoiceKind"/>. </summary>
        public static implicit operator VoiceKind(string value) => new VoiceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VoiceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VoiceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
