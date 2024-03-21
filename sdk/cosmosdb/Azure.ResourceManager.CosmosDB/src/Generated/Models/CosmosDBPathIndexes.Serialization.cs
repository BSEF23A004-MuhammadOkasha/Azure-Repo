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
    public partial class CosmosDBPathIndexes : IUtf8JsonSerializable, IJsonModel<CosmosDBPathIndexes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBPathIndexes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBPathIndexes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPathIndexes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBPathIndexes)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType.Value.ToString());
            }
            if (Optional.IsDefined(Precision))
            {
                writer.WritePropertyName("precision"u8);
                writer.WriteNumberValue(Precision.Value);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
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

        CosmosDBPathIndexes IJsonModel<CosmosDBPathIndexes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPathIndexes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBPathIndexes)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBPathIndexes(document.RootElement, options);
        }

        internal static CosmosDBPathIndexes DeserializeCosmosDBPathIndexes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CosmosDBDataType? dataType = default;
            int? precision = default;
            CosmosDBIndexKind? kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataType = new CosmosDBDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("precision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    precision = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new CosmosDBIndexKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBPathIndexes(dataType, precision, kind, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBPathIndexes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPathIndexes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBPathIndexes)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBPathIndexes IPersistableModel<CosmosDBPathIndexes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPathIndexes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBPathIndexes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBPathIndexes)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBPathIndexes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
