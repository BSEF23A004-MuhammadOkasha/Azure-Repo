// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableGremlinResourcesListResult : IUtf8JsonSerializable, IJsonModel<RestorableGremlinResourcesListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestorableGremlinResourcesListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestorableGremlinResourcesListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableGremlinResourcesListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableGremlinResourcesListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        RestorableGremlinResourcesListResult IJsonModel<RestorableGremlinResourcesListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableGremlinResourcesListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableGremlinResourcesListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableGremlinResourcesListResult(document.RootElement, options);
        }

        internal static RestorableGremlinResourcesListResult DeserializeRestorableGremlinResourcesListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RestorableGremlinResourceData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorableGremlinResourceData> array = new List<RestorableGremlinResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableGremlinResourceData.DeserializeRestorableGremlinResourceData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestorableGremlinResourcesListResult(value ?? new ChangeTrackingList<RestorableGremlinResourceData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestorableGremlinResourcesListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableGremlinResourcesListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestorableGremlinResourcesListResult)} does not support writing '{options.Format}' format.");
            }
        }

        RestorableGremlinResourcesListResult IPersistableModel<RestorableGremlinResourcesListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableGremlinResourcesListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestorableGremlinResourcesListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestorableGremlinResourcesListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestorableGremlinResourcesListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
