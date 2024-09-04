// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Content source to apply the Content Filters. </summary>
    public readonly partial struct RaiPolicyContentSource : IEquatable<RaiPolicyContentSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RaiPolicyContentSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RaiPolicyContentSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PromptValue = "Prompt";
        private const string CompletionValue = "Completion";

        /// <summary> Prompt. </summary>
        public static RaiPolicyContentSource Prompt { get; } = new RaiPolicyContentSource(PromptValue);
        /// <summary> Completion. </summary>
        public static RaiPolicyContentSource Completion { get; } = new RaiPolicyContentSource(CompletionValue);
        /// <summary> Determines if two <see cref="RaiPolicyContentSource"/> values are the same. </summary>
        public static bool operator ==(RaiPolicyContentSource left, RaiPolicyContentSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RaiPolicyContentSource"/> values are not the same. </summary>
        public static bool operator !=(RaiPolicyContentSource left, RaiPolicyContentSource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RaiPolicyContentSource"/>. </summary>
        public static implicit operator RaiPolicyContentSource(string value) => new RaiPolicyContentSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RaiPolicyContentSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RaiPolicyContentSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
