// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(NotebookConverter))]
    public partial class Notebook : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(BigDataPool))
            {
                if (BigDataPool != null)
                {
                    writer.WritePropertyName("bigDataPool");
                    writer.WriteObjectValue(BigDataPool);
                }
                else
                {
                    writer.WriteNull("bigDataPool");
                }
            }
            if (Optional.IsDefined(SessionProperties))
            {
                if (SessionProperties != null)
                {
                    writer.WritePropertyName("sessionProperties");
                    writer.WriteObjectValue(SessionProperties);
                }
                else
                {
                    writer.WriteNull("sessionProperties");
                }
            }
            writer.WritePropertyName("metadata");
            writer.WriteObjectValue(Metadata);
            writer.WritePropertyName("nbformat");
            writer.WriteNumberValue(Nbformat);
            writer.WritePropertyName("nbformat_minor");
            writer.WriteNumberValue(NbformatMinor);
            writer.WritePropertyName("cells");
            writer.WriteStartArray();
            foreach (var item in Cells)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static Notebook DeserializeNotebook(JsonElement element)
        {
            Optional<string> description = default;
            Optional<BigDataPoolReference> bigDataPool = default;
            Optional<NotebookSessionProperties> sessionProperties = default;
            NotebookMetadata metadata = default;
            int nbformat = default;
            int nbformatMinor = default;
            IList<NotebookCell> cells = default;
            Optional<NotebookFolder> folder = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bigDataPool"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bigDataPool = null;
                        continue;
                    }
                    bigDataPool = BigDataPoolReference.DeserializeBigDataPoolReference(property.Value);
                    continue;
                }
                if (property.NameEquals("sessionProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sessionProperties = null;
                        continue;
                    }
                    sessionProperties = NotebookSessionProperties.DeserializeNotebookSessionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    metadata = NotebookMetadata.DeserializeNotebookMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("nbformat"))
                {
                    nbformat = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nbformat_minor"))
                {
                    nbformatMinor = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cells"))
                {
                    List<NotebookCell> array = new List<NotebookCell>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotebookCell.DeserializeNotebookCell(item));
                    }
                    cells = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folder = NotebookFolder.DeserializeNotebookFolder(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new Notebook(description.Value, bigDataPool.Value, sessionProperties.Value, metadata, nbformat, nbformatMinor, cells, folder.Value, additionalProperties);
        }

        internal partial class NotebookConverter : JsonConverter<Notebook>
        {
            public override void Write(Utf8JsonWriter writer, Notebook model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override Notebook Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebook(document.RootElement);
            }
        }
    }
}
