// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DataProviderMetadata : IUtf8JsonSerializable, IJsonModel<DataProviderMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProviderMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProviderMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProviderMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ProviderName != null)
            {
                writer.WritePropertyName("providerName"u8);
                writer.WriteStringValue(ProviderName);
            }
            if (options.Format != "W" && !(PropertyBag is ChangeTrackingList<DataProviderKeyValuePair> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyBag)
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

        DataProviderMetadata IJsonModel<DataProviderMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProviderMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProviderMetadata(document.RootElement, options);
        }

        internal static DataProviderMetadata DeserializeDataProviderMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> providerName = default;
            IReadOnlyList<DataProviderKeyValuePair> propertyBag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerName"u8))
                {
                    providerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataProviderKeyValuePair> array = new List<DataProviderKeyValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProviderKeyValuePair.DeserializeDataProviderKeyValuePair(item, options));
                    }
                    propertyBag = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataProviderMetadata(providerName.Value, propertyBag ?? new ChangeTrackingList<DataProviderKeyValuePair>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProviderMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProviderMetadata)} does not support '{options.Format}' format.");
            }
        }

        DataProviderMetadata IPersistableModel<DataProviderMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProviderMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProviderMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProviderMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
