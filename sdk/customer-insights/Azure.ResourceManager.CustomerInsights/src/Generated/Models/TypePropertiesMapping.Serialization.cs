// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class TypePropertiesMapping : IUtf8JsonSerializable, IJsonModel<TypePropertiesMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TypePropertiesMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TypePropertiesMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TypePropertiesMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TypePropertiesMapping)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourcePropertyName"u8);
            writer.WriteStringValue(SourcePropertyName);
            writer.WritePropertyName("targetPropertyName"u8);
            writer.WriteStringValue(TargetPropertyName);
            if (LinkType.HasValue)
            {
                writer.WritePropertyName("linkType"u8);
                writer.WriteStringValue(LinkType.Value.ToSerialString());
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

        TypePropertiesMapping IJsonModel<TypePropertiesMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TypePropertiesMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TypePropertiesMapping)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTypePropertiesMapping(document.RootElement, options);
        }

        internal static TypePropertiesMapping DeserializeTypePropertiesMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourcePropertyName = default;
            string targetPropertyName = default;
            Optional<LinkType> linkType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourcePropertyName"u8))
                {
                    sourcePropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPropertyName"u8))
                {
                    targetPropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkType = property.Value.GetString().ToLinkType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TypePropertiesMapping(sourcePropertyName, targetPropertyName, Optional.ToNullable(linkType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TypePropertiesMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TypePropertiesMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TypePropertiesMapping)} does not support '{options.Format}' format.");
            }
        }

        TypePropertiesMapping IPersistableModel<TypePropertiesMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TypePropertiesMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTypePropertiesMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TypePropertiesMapping)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TypePropertiesMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
