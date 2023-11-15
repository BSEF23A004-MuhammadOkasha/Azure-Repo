// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobServiceChangeFeed : IUtf8JsonSerializable, IJsonModel<BlobServiceChangeFeed>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobServiceChangeFeed>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BlobServiceChangeFeed>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BlobServiceChangeFeed>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BlobServiceChangeFeed>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(RetentionInDays))
            {
                writer.WritePropertyName("retentionInDays"u8);
                writer.WriteNumberValue(RetentionInDays.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        BlobServiceChangeFeed IJsonModel<BlobServiceChangeFeed>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobServiceChangeFeed)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobServiceChangeFeed(document.RootElement, options);
        }

        internal static BlobServiceChangeFeed DeserializeBlobServiceChangeFeed(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<int> retentionInDays = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retentionInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionInDays = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlobServiceChangeFeed(Optional.ToNullable(enabled), Optional.ToNullable(retentionInDays), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlobServiceChangeFeed>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobServiceChangeFeed)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BlobServiceChangeFeed IPersistableModel<BlobServiceChangeFeed>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobServiceChangeFeed)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBlobServiceChangeFeed(document.RootElement, options);
        }

        string IPersistableModel<BlobServiceChangeFeed>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
