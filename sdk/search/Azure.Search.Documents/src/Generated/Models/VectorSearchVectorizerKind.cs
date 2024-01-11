// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The vectorization method to be used during query time. </summary>
    public readonly partial struct VectorSearchVectorizerKind : IEquatable<VectorSearchVectorizerKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorSearchVectorizerKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorSearchVectorizerKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureOpenAIValue = "azureOpenAI";
        private const string CustomWebApiValue = "customWebApi";

        /// <summary> Generate embeddings using an Azure OpenAI resource at query time. </summary>
        public static VectorSearchVectorizerKind AzureOpenAI { get; } = new VectorSearchVectorizerKind(AzureOpenAIValue);
        /// <summary> Generate embeddings using a custom web endpoint at query time. </summary>
        public static VectorSearchVectorizerKind CustomWebApi { get; } = new VectorSearchVectorizerKind(CustomWebApiValue);
        /// <summary> Determines if two <see cref="VectorSearchVectorizerKind"/> values are the same. </summary>
        public static bool operator ==(VectorSearchVectorizerKind left, VectorSearchVectorizerKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorSearchVectorizerKind"/> values are not the same. </summary>
        public static bool operator !=(VectorSearchVectorizerKind left, VectorSearchVectorizerKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VectorSearchVectorizerKind"/>. </summary>
        public static implicit operator VectorSearchVectorizerKind(string value) => new VectorSearchVectorizerKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorSearchVectorizerKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorSearchVectorizerKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
