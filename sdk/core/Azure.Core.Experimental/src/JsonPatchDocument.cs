// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using Azure.Core.JsonPatch;
using Azure.Core.Serialization;

namespace Azure.Core
{
    /// <summary>
    /// Represents a JSON Patch document.
    /// </summary>
    public class JsonPatchDocument
    {
        private readonly ObjectSerializer _serializer;
        private readonly Collection<JsonPatchOperation> _operations;

        /// <summary>
        /// Initializes a new instance of <see cref="JsonPatchDocument"/> that uses <see cref="JsonObjectSerializer"/> as the default serializer.
        /// </summary>
        public JsonPatchDocument() : this(new JsonObjectSerializer())
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="JsonPatchDocument"/>
        /// </summary>
        /// <param name="serializer">The <see cref="ObjectSerializer"/> instance to use for value serialization.</param>
        public JsonPatchDocument(ObjectSerializer serializer)
        {
            _operations = new Collection<JsonPatchOperation>();
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        /// <summary>
        /// Appends an "add" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="path">The path to apply the addition to.</param>
        /// <param name="rawJsonValue">The raw JSON value to add to the path.</param>
        public void AppendAddRaw(string path, string rawJsonValue)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Add, path, null, rawJsonValue));
        }

        /// <summary>
        /// Appends an "add" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="path">The path to apply the addition to.</param>
        /// <param name="value">The value to add to the path.</param>
        public void AppendAdd<T>(string path, T value)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Add, path, null, Serialize(value)));
        }

        /// <summary>
        /// Appends a "replace" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="path">The path to replace.</param>
        /// <param name="rawJsonValue">The raw JSON value to replace with.</param>
        public void AppendReplaceRaw(string path, string rawJsonValue)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Replace, path, null, rawJsonValue));
        }
        /// <summary>
        /// Appends a "replace" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="path">The path to replace.</param>
        /// <param name="value">The value to replace with.</param>
        public void AppendReplace<T>(string path, T value)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Replace, path, null, Serialize(value)));
        }

        /// <summary>
        /// Appends a "copy" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="from">The path to copy from.</param>
        /// <param name="path">The path to copy to.</param>
        public void AppendCopy(string from, string path)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Copy, path, from, null));
        }

        /// <summary>
        /// Appends a "move" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="from">The path to move from.</param>
        /// <param name="path">The path to move to.</param>
        public void AppendMove(string from, string path)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Move, path, from, null));
        }

        /// <summary>
        /// Appends a "remove" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="path">The path to remove.</param>
        public void AppendRemove(string path)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Remove, path, null, null));
        }

        /// <summary>
        /// Appends a "test" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <param name="rawJsonValue">The raw JSON value to test against.</param>
        public void AppendTestRaw(string path, string rawJsonValue)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Test, path, null, rawJsonValue));
        }

        /// <summary>
        /// Appends a "test" operation to this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <param name="value">The value to replace with.</param>
        public void AppendTest<T>(string path, T value)
        {
            _operations.Add(new JsonPatchOperation(JsonPatchOperationKind.Test, path, null, Serialize(value)));
        }

        /// <summary>
        /// Returns a formatted JSON string representation of this <see cref="JsonPatchDocument"/>.
        /// </summary>
        /// <returns>A formatted JSON string representation of this <see cref="JsonPatchDocument"/>.</returns>
        public override string ToString()
        {
            using var memoryStream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(memoryStream))
            {
                WriteTo(writer);
            }
            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }

        /// <summary>
        /// Writes the document to a <see cref="Utf8JsonWriter"/> in JSON Path format.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> instance to write this document to</param>
#pragma warning disable AZC0014 do not expose Json types in public APIs
        public void WriteTo(Utf8JsonWriter writer)
#pragma warning enable AZC0014
        {
            writer.WriteStartArray();
            foreach (var operation in _operations)
            {
                writer.WriteStartObject();
                writer.WriteString("op", operation.Kind.ToString());
                if (operation.From != null)
                {
                    writer.WriteString("from", operation.From);
                }
                writer.WriteString("path", operation.Path);
                if (operation.RawJsonValue != null)
                {
                    using var parsedValue = JsonDocument.Parse(operation.RawJsonValue);
                    writer.WritePropertyName("value");
                    parsedValue.WriteTo(writer);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndArray();
        }

        private string Serialize<T>(T value)
        {
            using MemoryStream memoryStream = new MemoryStream();
            _serializer.Serialize(memoryStream, value, typeof(T), default);
            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }
    }
}