// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Package build state returned in package response. </summary>
    public readonly partial struct PackageBuildState : IEquatable<PackageBuildState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PackageBuildState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PackageBuildState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> NotStarted. </summary>
        public static PackageBuildState NotStarted { get; } = new PackageBuildState(NotStartedValue);
        /// <summary> Running. </summary>
        public static PackageBuildState Running { get; } = new PackageBuildState(RunningValue);
        /// <summary> Succeeded. </summary>
        public static PackageBuildState Succeeded { get; } = new PackageBuildState(SucceededValue);
        /// <summary> Failed. </summary>
        public static PackageBuildState Failed { get; } = new PackageBuildState(FailedValue);
        /// <summary> Determines if two <see cref="PackageBuildState"/> values are the same. </summary>
        public static bool operator ==(PackageBuildState left, PackageBuildState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PackageBuildState"/> values are not the same. </summary>
        public static bool operator !=(PackageBuildState left, PackageBuildState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PackageBuildState"/>. </summary>
        public static implicit operator PackageBuildState(string value) => new PackageBuildState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PackageBuildState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PackageBuildState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
