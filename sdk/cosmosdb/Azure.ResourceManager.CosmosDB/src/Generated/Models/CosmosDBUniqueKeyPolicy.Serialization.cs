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
    internal partial class CosmosDBUniqueKeyPolicy : IUtf8JsonSerializable, IJsonModel<CosmosDBUniqueKeyPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBUniqueKeyPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBUniqueKeyPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBUniqueKeyPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBUniqueKeyPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(UniqueKeys is ChangeTrackingList<CosmosDBUniqueKey> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("uniqueKeys"u8);
                writer.WriteStartArray();
                foreach (var item in UniqueKeys)
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

        CosmosDBUniqueKeyPolicy IJsonModel<CosmosDBUniqueKeyPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBUniqueKeyPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBUniqueKeyPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBUniqueKeyPolicy(document.RootElement, options);
        }

        internal static CosmosDBUniqueKeyPolicy DeserializeCosmosDBUniqueKeyPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CosmosDBUniqueKey> uniqueKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uniqueKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBUniqueKey> array = new List<CosmosDBUniqueKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBUniqueKey.DeserializeCosmosDBUniqueKey(item, options));
                    }
                    uniqueKeys = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBUniqueKeyPolicy(uniqueKeys ?? new ChangeTrackingList<CosmosDBUniqueKey>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBUniqueKeyPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBUniqueKeyPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBUniqueKeyPolicy)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBUniqueKeyPolicy IPersistableModel<CosmosDBUniqueKeyPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBUniqueKeyPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBUniqueKeyPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBUniqueKeyPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBUniqueKeyPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
