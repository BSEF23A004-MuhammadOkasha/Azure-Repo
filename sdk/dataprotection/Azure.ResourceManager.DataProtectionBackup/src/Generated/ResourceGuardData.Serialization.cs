// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    public partial class ResourceGuardData : IUtf8JsonSerializable, IJsonModel<ResourceGuardData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceGuardData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceGuardData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
        }

        ResourceGuardData IJsonModel<ResourceGuardData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceGuardData(document.RootElement, options);
        }

        internal static ResourceGuardData DeserializeResourceGuardData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceGuardProperties properties = default;
            ETag? eTag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ResourceGuardProperties.DeserializeResourceGuardProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceGuardData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                properties,
                eTag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceGuardData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardData)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceGuardData IPersistableModel<ResourceGuardData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceGuardData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceGuardData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
