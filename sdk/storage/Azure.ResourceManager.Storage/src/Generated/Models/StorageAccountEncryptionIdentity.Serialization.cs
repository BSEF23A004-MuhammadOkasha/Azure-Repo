// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountEncryptionIdentity : IUtf8JsonSerializable, IJsonModel<StorageAccountEncryptionIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountEncryptionIdentity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageAccountEncryptionIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountEncryptionIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountEncryptionIdentity)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EncryptionUserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity"u8);
                writer.WriteStringValue(EncryptionUserAssignedIdentity);
            }
            if (Optional.IsDefined(EncryptionFederatedIdentityClientId))
            {
                writer.WritePropertyName("federatedIdentityClientId"u8);
                writer.WriteStringValue(EncryptionFederatedIdentityClientId);
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

        StorageAccountEncryptionIdentity IJsonModel<StorageAccountEncryptionIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountEncryptionIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountEncryptionIdentity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountEncryptionIdentity(document.RootElement, options);
        }

        internal static StorageAccountEncryptionIdentity DeserializeStorageAccountEncryptionIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userAssignedIdentity = default;
            string federatedIdentityClientId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    userAssignedIdentity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("federatedIdentityClientId"u8))
                {
                    federatedIdentityClientId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageAccountEncryptionIdentity(userAssignedIdentity, federatedIdentityClientId, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EncryptionUserAssignedIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userAssignedIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EncryptionUserAssignedIdentity))
                {
                    builder.Append("  userAssignedIdentity: ");
                    if (EncryptionUserAssignedIdentity.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EncryptionUserAssignedIdentity}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EncryptionUserAssignedIdentity}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EncryptionFederatedIdentityClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  federatedIdentityClientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EncryptionFederatedIdentityClientId))
                {
                    builder.Append("  federatedIdentityClientId: ");
                    if (EncryptionFederatedIdentityClientId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EncryptionFederatedIdentityClientId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EncryptionFederatedIdentityClientId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageAccountEncryptionIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountEncryptionIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountEncryptionIdentity)} does not support writing '{options.Format}' format.");
            }
        }

        StorageAccountEncryptionIdentity IPersistableModel<StorageAccountEncryptionIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountEncryptionIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountEncryptionIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountEncryptionIdentity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountEncryptionIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
