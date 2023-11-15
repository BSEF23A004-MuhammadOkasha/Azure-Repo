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
    public partial class StorageAccountEncryptionServices : IUtf8JsonSerializable, IJsonModel<StorageAccountEncryptionServices>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountEncryptionServices>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StorageAccountEncryptionServices>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StorageAccountEncryptionServices>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StorageAccountEncryptionServices>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Blob))
            {
                writer.WritePropertyName("blob"u8);
                writer.WriteObjectValue(Blob);
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteObjectValue(File);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteObjectValue(Table);
            }
            if (Optional.IsDefined(Queue))
            {
                writer.WritePropertyName("queue"u8);
                writer.WriteObjectValue(Queue);
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

        StorageAccountEncryptionServices IJsonModel<StorageAccountEncryptionServices>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountEncryptionServices)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountEncryptionServices(document.RootElement, options);
        }

        internal static StorageAccountEncryptionServices DeserializeStorageAccountEncryptionServices(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageEncryptionService> blob = default;
            Optional<StorageEncryptionService> file = default;
            Optional<StorageEncryptionService> table = default;
            Optional<StorageEncryptionService> queue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blob = StorageEncryptionService.DeserializeStorageEncryptionService(property.Value);
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    file = StorageEncryptionService.DeserializeStorageEncryptionService(property.Value);
                    continue;
                }
                if (property.NameEquals("table"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    table = StorageEncryptionService.DeserializeStorageEncryptionService(property.Value);
                    continue;
                }
                if (property.NameEquals("queue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queue = StorageEncryptionService.DeserializeStorageEncryptionService(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountEncryptionServices(blob.Value, file.Value, table.Value, queue.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountEncryptionServices>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountEncryptionServices)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StorageAccountEncryptionServices IPersistableModel<StorageAccountEncryptionServices>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountEncryptionServices)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStorageAccountEncryptionServices(document.RootElement, options);
        }

        string IPersistableModel<StorageAccountEncryptionServices>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
