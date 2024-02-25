// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class AccessListEnvironmentsSuccessResponse : IUtf8JsonSerializable, IJsonModel<AccessListEnvironmentsSuccessResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessListEnvironmentsSuccessResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessListEnvironmentsSuccessResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessListEnvironmentsSuccessResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessListEnvironmentsSuccessResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Metadata != null)
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
            }
            if (!(Data is ChangeTrackingList<EnvironmentRecord> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
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

        AccessListEnvironmentsSuccessResponse IJsonModel<AccessListEnvironmentsSuccessResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessListEnvironmentsSuccessResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessListEnvironmentsSuccessResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessListEnvironmentsSuccessResponse(document.RootElement, options);
        }

        internal static AccessListEnvironmentsSuccessResponse DeserializeAccessListEnvironmentsSuccessResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<ConfluentListMetadata> metadata = default;
            IReadOnlyList<EnvironmentRecord> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ConfluentListMetadata.DeserializeConfluentListMetadata(property.Value, options);
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EnvironmentRecord> array = new List<EnvironmentRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EnvironmentRecord.DeserializeEnvironmentRecord(item, options));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessListEnvironmentsSuccessResponse(kind.Value, metadata.Value, data ?? new ChangeTrackingList<EnvironmentRecord>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AccessListEnvironmentsSuccessResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessListEnvironmentsSuccessResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AccessListEnvironmentsSuccessResponse)} does not support '{options.Format}' format.");
            }
        }

        AccessListEnvironmentsSuccessResponse IPersistableModel<AccessListEnvironmentsSuccessResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessListEnvironmentsSuccessResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessListEnvironmentsSuccessResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessListEnvironmentsSuccessResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessListEnvironmentsSuccessResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
