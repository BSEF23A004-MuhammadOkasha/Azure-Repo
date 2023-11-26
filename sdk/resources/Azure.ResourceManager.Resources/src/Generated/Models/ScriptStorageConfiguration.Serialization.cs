// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ScriptStorageConfiguration : IUtf8JsonSerializable, IJsonModel<ScriptStorageConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScriptStorageConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScriptStorageConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ScriptStorageConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountName))
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            if (Optional.IsDefined(StorageAccountKey))
            {
                writer.WritePropertyName("storageAccountKey"u8);
                writer.WriteStringValue(StorageAccountKey);
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

        ScriptStorageConfiguration IJsonModel<ScriptStorageConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ScriptStorageConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptStorageConfiguration(document.RootElement, options);
        }

        internal static ScriptStorageConfiguration DeserializeScriptStorageConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> storageAccountName = default;
            Optional<string> storageAccountKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountKey"u8))
                {
                    storageAccountKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScriptStorageConfiguration(storageAccountName.Value, storageAccountKey.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScriptStorageConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ScriptStorageConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ScriptStorageConfiguration IPersistableModel<ScriptStorageConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScriptStorageConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ScriptStorageConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScriptStorageConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
