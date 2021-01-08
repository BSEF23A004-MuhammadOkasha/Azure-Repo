// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The format definition of a storage. </summary>
    internal partial class DatasetStorageFormat : IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of DatasetStorageFormat. </summary>
        internal DatasetStorageFormat()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            Type = "DatasetStorageFormat";
        }

        /// <summary> Type of dataset storage format. </summary>
        internal string Type { get; set; }
        /// <summary> Serializer. Type: string (or Expression with resultType string). </summary>
        public object Serializer { get; }
        /// <summary> Deserializer. Type: string (or Expression with resultType string). </summary>
        public object Deserializer { get; }
        internal IReadOnlyDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<object> Values => AdditionalProperties.Values;
        /// <inheritdoc cref="IReadOnlyCollection{T}.Count"/>
        int IReadOnlyCollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}
