// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Human-readable error code. </summary>
    internal readonly partial struct InnerErrorCode : IEquatable<InnerErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InnerErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InnerErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidRequestValue = "InvalidRequest";
        private const string InvalidParameterValueValue = "InvalidParameterValue";
        private const string KnowledgeBaseNotFoundValue = "KnowledgeBaseNotFound";
        private const string AzureCognitiveSearchNotFoundValue = "AzureCognitiveSearchNotFound";
        private const string AzureCognitiveSearchThrottlingValue = "AzureCognitiveSearchThrottling";
        private const string ExtractionFailureValue = "ExtractionFailure";

        /// <summary> InvalidRequest. </summary>
        public static InnerErrorCode InvalidRequest { get; } = new InnerErrorCode(InvalidRequestValue);
        /// <summary> InvalidParameterValue. </summary>
        public static InnerErrorCode InvalidParameterValue { get; } = new InnerErrorCode(InvalidParameterValueValue);
        /// <summary> KnowledgeBaseNotFound. </summary>
        public static InnerErrorCode KnowledgeBaseNotFound { get; } = new InnerErrorCode(KnowledgeBaseNotFoundValue);
        /// <summary> AzureCognitiveSearchNotFound. </summary>
        public static InnerErrorCode AzureCognitiveSearchNotFound { get; } = new InnerErrorCode(AzureCognitiveSearchNotFoundValue);
        /// <summary> AzureCognitiveSearchThrottling. </summary>
        public static InnerErrorCode AzureCognitiveSearchThrottling { get; } = new InnerErrorCode(AzureCognitiveSearchThrottlingValue);
        /// <summary> ExtractionFailure. </summary>
        public static InnerErrorCode ExtractionFailure { get; } = new InnerErrorCode(ExtractionFailureValue);
        /// <summary> Determines if two <see cref="InnerErrorCode"/> values are the same. </summary>
        public static bool operator ==(InnerErrorCode left, InnerErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InnerErrorCode"/> values are not the same. </summary>
        public static bool operator !=(InnerErrorCode left, InnerErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InnerErrorCode"/>. </summary>
        public static implicit operator InnerErrorCode(string value) => new InnerErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InnerErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InnerErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
