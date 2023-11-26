// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class KnowledgeStoreObjectProjectionSelector : IUtf8JsonSerializable, IJsonModel<KnowledgeStoreObjectProjectionSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KnowledgeStoreObjectProjectionSelector>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KnowledgeStoreObjectProjectionSelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeStoreObjectProjectionSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KnowledgeStoreObjectProjectionSelector)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageContainer"u8);
            writer.WriteStringValue(StorageContainer);
            if (Optional.IsDefined(ReferenceKeyName))
            {
                writer.WritePropertyName("referenceKeyName"u8);
                writer.WriteStringValue(ReferenceKeyName);
            }
            if (Optional.IsDefined(GeneratedKeyName))
            {
                writer.WritePropertyName("generatedKeyName"u8);
                writer.WriteStringValue(GeneratedKeyName);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(SourceContext))
            {
                writer.WritePropertyName("sourceContext"u8);
                writer.WriteStringValue(SourceContext);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        KnowledgeStoreObjectProjectionSelector IJsonModel<KnowledgeStoreObjectProjectionSelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeStoreObjectProjectionSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KnowledgeStoreObjectProjectionSelector)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKnowledgeStoreObjectProjectionSelector(document.RootElement, options);
        }

        internal static KnowledgeStoreObjectProjectionSelector DeserializeKnowledgeStoreObjectProjectionSelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageContainer = default;
            Optional<string> referenceKeyName = default;
            Optional<string> generatedKeyName = default;
            Optional<string> source = default;
            Optional<string> sourceContext = default;
            Optional<IList<InputFieldMappingEntry>> inputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageContainer"u8))
                {
                    storageContainer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceKeyName"u8))
                {
                    referenceKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generatedKeyName"u8))
                {
                    generatedKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceContext"u8))
                {
                    sourceContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KnowledgeStoreObjectProjectionSelector(referenceKeyName.Value, generatedKeyName.Value, source.Value, sourceContext.Value, Optional.ToList(inputs), serializedAdditionalRawData, storageContainer);
        }

        BinaryData IPersistableModel<KnowledgeStoreObjectProjectionSelector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeStoreObjectProjectionSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(KnowledgeStoreObjectProjectionSelector)} does not support '{options.Format}' format.");
            }
        }

        KnowledgeStoreObjectProjectionSelector IPersistableModel<KnowledgeStoreObjectProjectionSelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeStoreObjectProjectionSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKnowledgeStoreObjectProjectionSelector(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(KnowledgeStoreObjectProjectionSelector)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KnowledgeStoreObjectProjectionSelector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
