// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ListConnectionStringsResult : IUtf8JsonSerializable, IJsonModel<ListConnectionStringsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ListConnectionStringsResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ListConnectionStringsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListConnectionStringsResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(ConnectionStrings is ChangeTrackingList<CosmosDBConnectionString> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("connectionStrings"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionStrings)
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

        ListConnectionStringsResult IJsonModel<ListConnectionStringsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListConnectionStringsResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeListConnectionStringsResult(document.RootElement, options);
        }

        internal static ListConnectionStringsResult DeserializeListConnectionStringsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CosmosDBConnectionString> connectionStrings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionStrings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBConnectionString> array = new List<CosmosDBConnectionString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBConnectionString.DeserializeCosmosDBConnectionString(item, options));
                    }
                    connectionStrings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ListConnectionStringsResult(connectionStrings ?? new ChangeTrackingList<CosmosDBConnectionString>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ListConnectionStringsResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ListConnectionStringsResult)} does not support '{options.Format}' format.");
            }
        }

        ListConnectionStringsResult IPersistableModel<ListConnectionStringsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeListConnectionStringsResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ListConnectionStringsResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ListConnectionStringsResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
