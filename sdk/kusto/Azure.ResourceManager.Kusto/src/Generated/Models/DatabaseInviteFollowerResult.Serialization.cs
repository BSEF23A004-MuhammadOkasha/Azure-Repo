// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class DatabaseInviteFollowerResult : IUtf8JsonSerializable, IJsonModel<DatabaseInviteFollowerResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseInviteFollowerResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DatabaseInviteFollowerResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseInviteFollowerResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(GeneratedInvitation))
            {
                writer.WritePropertyName("generatedInvitation"u8);
                writer.WriteStringValue(GeneratedInvitation);
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

        DatabaseInviteFollowerResult IJsonModel<DatabaseInviteFollowerResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseInviteFollowerResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseInviteFollowerResult(document.RootElement, options);
        }

        internal static DatabaseInviteFollowerResult DeserializeDatabaseInviteFollowerResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string generatedInvitation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("generatedInvitation"u8))
                {
                    generatedInvitation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DatabaseInviteFollowerResult(generatedInvitation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatabaseInviteFollowerResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseInviteFollowerResult)} does not support writing '{options.Format}' format.");
            }
        }

        DatabaseInviteFollowerResult IPersistableModel<DatabaseInviteFollowerResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseInviteFollowerResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseInviteFollowerResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseInviteFollowerResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseInviteFollowerResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
