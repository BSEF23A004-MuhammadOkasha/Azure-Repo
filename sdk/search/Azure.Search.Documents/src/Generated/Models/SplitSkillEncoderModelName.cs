// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A value indicating which tokenizer to use. </summary>
    public readonly partial struct SplitSkillEncoderModelName : IEquatable<SplitSkillEncoderModelName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SplitSkillEncoderModelName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SplitSkillEncoderModelName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string R50KBaseValue = "r50k_base";
        private const string P50KBaseValue = "p50k_base";
        private const string P50KEditValue = "p50k_edit";
        private const string CL100KBaseValue = "cl100k_base";

        /// <summary> Refers to a base model trained with a 50,000 token vocabulary, often used in general natural language processing tasks. </summary>
        public static SplitSkillEncoderModelName R50KBase { get; } = new SplitSkillEncoderModelName(R50KBaseValue);
        /// <summary> A base model with a 50,000 token vocabulary, optimized for prompt-based tasks. </summary>
        public static SplitSkillEncoderModelName P50KBase { get; } = new SplitSkillEncoderModelName(P50KBaseValue);
        /// <summary> Similar to p50k_base but fine-tuned for editing or rephrasing tasks with a 50,000 token vocabulary. </summary>
        public static SplitSkillEncoderModelName P50KEdit { get; } = new SplitSkillEncoderModelName(P50KEditValue);
        /// <summary> A base model with a 100,000 token vocabulary. </summary>
        public static SplitSkillEncoderModelName CL100KBase { get; } = new SplitSkillEncoderModelName(CL100KBaseValue);
        /// <summary> Determines if two <see cref="SplitSkillEncoderModelName"/> values are the same. </summary>
        public static bool operator ==(SplitSkillEncoderModelName left, SplitSkillEncoderModelName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SplitSkillEncoderModelName"/> values are not the same. </summary>
        public static bool operator !=(SplitSkillEncoderModelName left, SplitSkillEncoderModelName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SplitSkillEncoderModelName"/>. </summary>
        public static implicit operator SplitSkillEncoderModelName(string value) => new SplitSkillEncoderModelName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SplitSkillEncoderModelName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SplitSkillEncoderModelName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
