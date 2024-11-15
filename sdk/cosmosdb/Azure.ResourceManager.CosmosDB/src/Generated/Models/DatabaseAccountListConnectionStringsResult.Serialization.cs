// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class DatabaseAccountListConnectionStringsResult : IUtf8JsonSerializable, IJsonModel<DatabaseAccountListConnectionStringsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseAccountListConnectionStringsResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DatabaseAccountListConnectionStringsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseAccountListConnectionStringsResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(ConnectionStrings))
            {
                writer.WritePropertyName("connectionStrings"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionStrings)
                {
                    writer.WriteObjectValue(item, options);
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
        }

        DatabaseAccountListConnectionStringsResult IJsonModel<DatabaseAccountListConnectionStringsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseAccountListConnectionStringsResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseAccountListConnectionStringsResult(document.RootElement, options);
        }

        internal static DatabaseAccountListConnectionStringsResult DeserializeDatabaseAccountListConnectionStringsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CosmosDBAccountConnectionString> connectionStrings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionStrings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBAccountConnectionString> array = new List<CosmosDBAccountConnectionString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBAccountConnectionString.DeserializeCosmosDBAccountConnectionString(item, options));
                    }
                    connectionStrings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DatabaseAccountListConnectionStringsResult(connectionStrings ?? new ChangeTrackingList<CosmosDBAccountConnectionString>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectionStrings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectionStrings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ConnectionStrings))
                {
                    if (ConnectionStrings.Any())
                    {
                        builder.Append("  connectionStrings: ");
                        builder.AppendLine("[");
                        foreach (var item in ConnectionStrings)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  connectionStrings: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DatabaseAccountListConnectionStringsResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseAccountListConnectionStringsResult)} does not support writing '{options.Format}' format.");
            }
        }

        DatabaseAccountListConnectionStringsResult IPersistableModel<DatabaseAccountListConnectionStringsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseAccountListConnectionStringsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseAccountListConnectionStringsResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseAccountListConnectionStringsResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseAccountListConnectionStringsResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
