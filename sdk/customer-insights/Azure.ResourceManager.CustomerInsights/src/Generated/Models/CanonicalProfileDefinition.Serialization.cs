// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class CanonicalProfileDefinition : IUtf8JsonSerializable, IJsonModel<CanonicalProfileDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CanonicalProfileDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CanonicalProfileDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CanonicalProfileId.HasValue)
            {
                writer.WritePropertyName("canonicalProfileId"u8);
                writer.WriteNumberValue(CanonicalProfileId.Value);
            }
            if (!(Properties is ChangeTrackingList<CanonicalProfileDefinitionPropertiesItem> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartArray();
                foreach (var item in Properties)
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

        CanonicalProfileDefinition IJsonModel<CanonicalProfileDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCanonicalProfileDefinition(document.RootElement, options);
        }

        internal static CanonicalProfileDefinition DeserializeCanonicalProfileDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? canonicalProfileId = default;
            IReadOnlyList<CanonicalProfileDefinitionPropertiesItem> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canonicalProfileId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canonicalProfileId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CanonicalProfileDefinitionPropertiesItem> array = new List<CanonicalProfileDefinitionPropertiesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CanonicalProfileDefinitionPropertiesItem.DeserializeCanonicalProfileDefinitionPropertiesItem(item, options));
                    }
                    properties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CanonicalProfileDefinition(canonicalProfileId, properties ?? new ChangeTrackingList<CanonicalProfileDefinitionPropertiesItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CanonicalProfileDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support '{options.Format}' format.");
            }
        }

        CanonicalProfileDefinition IPersistableModel<CanonicalProfileDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCanonicalProfileDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CanonicalProfileDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
