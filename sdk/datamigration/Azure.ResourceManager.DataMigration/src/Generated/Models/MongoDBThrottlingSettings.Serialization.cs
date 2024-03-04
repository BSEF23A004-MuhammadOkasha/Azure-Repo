// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBThrottlingSettings : IUtf8JsonSerializable, IJsonModel<MongoDBThrottlingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBThrottlingSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBThrottlingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBThrottlingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBThrottlingSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinFreeCpu))
            {
                writer.WritePropertyName("minFreeCpu"u8);
                writer.WriteNumberValue(MinFreeCpu.Value);
            }
            if (Optional.IsDefined(MinFreeMemoryMb))
            {
                writer.WritePropertyName("minFreeMemoryMb"u8);
                writer.WriteNumberValue(MinFreeMemoryMb.Value);
            }
            if (Optional.IsDefined(MaxParallelism))
            {
                writer.WritePropertyName("maxParallelism"u8);
                writer.WriteNumberValue(MaxParallelism.Value);
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

        MongoDBThrottlingSettings IJsonModel<MongoDBThrottlingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBThrottlingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBThrottlingSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBThrottlingSettings(document.RootElement, options);
        }

        internal static MongoDBThrottlingSettings DeserializeMongoDBThrottlingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? minFreeCpu = default;
            int? minFreeMemoryMb = default;
            int? maxParallelism = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minFreeCpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minFreeCpu = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minFreeMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minFreeMemoryMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxParallelism"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelism = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoDBThrottlingSettings(minFreeCpu, minFreeMemoryMb, maxParallelism, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBThrottlingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBThrottlingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBThrottlingSettings)} does not support '{options.Format}' format.");
            }
        }

        MongoDBThrottlingSettings IPersistableModel<MongoDBThrottlingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBThrottlingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBThrottlingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBThrottlingSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBThrottlingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
