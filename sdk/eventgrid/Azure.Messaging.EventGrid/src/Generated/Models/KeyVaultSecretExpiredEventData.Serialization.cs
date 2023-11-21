// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(KeyVaultSecretExpiredEventDataConverter))]
    public partial class KeyVaultSecretExpiredEventData : IUtf8JsonSerializable, IJsonModel<KeyVaultSecretExpiredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultSecretExpiredEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeyVaultSecretExpiredEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultSecretExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KeyVaultSecretExpiredEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("Id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(VaultName))
            {
                writer.WritePropertyName("VaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("ObjectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            if (Optional.IsDefined(ObjectName))
            {
                writer.WritePropertyName("ObjectName"u8);
                writer.WriteStringValue(ObjectName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("Version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(Nbf))
            {
                writer.WritePropertyName("NBF"u8);
                writer.WriteNumberValue(Nbf.Value);
            }
            if (Optional.IsDefined(Exp))
            {
                writer.WritePropertyName("EXP"u8);
                writer.WriteNumberValue(Exp.Value);
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

        KeyVaultSecretExpiredEventData IJsonModel<KeyVaultSecretExpiredEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultSecretExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KeyVaultSecretExpiredEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultSecretExpiredEventData(document.RootElement, options);
        }

        internal static KeyVaultSecretExpiredEventData DeserializeKeyVaultSecretExpiredEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> vaultName = default;
            Optional<string> objectType = default;
            Optional<string> objectName = default;
            Optional<string> version = default;
            Optional<float> nbf = default;
            Optional<float> exp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("VaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NBF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nbf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("EXP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exp = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KeyVaultSecretExpiredEventData(id.Value, vaultName.Value, objectType.Value, objectName.Value, version.Value, Optional.ToNullable(nbf), Optional.ToNullable(exp), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyVaultSecretExpiredEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultSecretExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(KeyVaultSecretExpiredEventData)} does not support '{options.Format}' format.");
            }
        }

        KeyVaultSecretExpiredEventData IPersistableModel<KeyVaultSecretExpiredEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultSecretExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeyVaultSecretExpiredEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(KeyVaultSecretExpiredEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeyVaultSecretExpiredEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class KeyVaultSecretExpiredEventDataConverter : JsonConverter<KeyVaultSecretExpiredEventData>
        {
            public override void Write(Utf8JsonWriter writer, KeyVaultSecretExpiredEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override KeyVaultSecretExpiredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeKeyVaultSecretExpiredEventData(document.RootElement);
            }
        }
    }
}
