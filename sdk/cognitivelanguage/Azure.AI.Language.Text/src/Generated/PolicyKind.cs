// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> Kinds of overlap policies supported. </summary>
    internal readonly partial struct PolicyKind : IEquatable<PolicyKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MatchLongestValue = "matchLongest";
        private const string AllowOverlapValue = "allowOverlap";

        /// <summary> Represents MatchLongestEntityPolicyType. </summary>
        public static PolicyKind MatchLongest { get; } = new PolicyKind(MatchLongestValue);
        /// <summary> Represents AllowOverlapEntityPolicyType. </summary>
        public static PolicyKind AllowOverlap { get; } = new PolicyKind(AllowOverlapValue);
        /// <summary> Determines if two <see cref="PolicyKind"/> values are the same. </summary>
        public static bool operator ==(PolicyKind left, PolicyKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyKind"/> values are not the same. </summary>
        public static bool operator !=(PolicyKind left, PolicyKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyKind"/>. </summary>
        public static implicit operator PolicyKind(string value) => new PolicyKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
