// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupStatusResult : IUtf8JsonSerializable, IJsonModel<BackupStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupStatusResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupStatusResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupStatusResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ProtectionStatus.HasValue)
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus.Value.ToString());
            }
            if (VaultId != null)
            {
                writer.WritePropertyName("vaultId"u8);
                writer.WriteStringValue(VaultId);
            }
            if (FabricName.HasValue)
            {
                writer.WritePropertyName("fabricName"u8);
                writer.WriteStringValue(FabricName.Value.ToString());
            }
            if (ContainerName != null)
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (ProtectedItemName != null)
            {
                writer.WritePropertyName("protectedItemName"u8);
                writer.WriteStringValue(ProtectedItemName);
            }
            if (ErrorCode != null)
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (PolicyName != null)
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (RegistrationStatus != null)
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (ProtectedItemsCount.HasValue)
            {
                writer.WritePropertyName("protectedItemsCount"u8);
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            if (AcquireStorageAccountLock.HasValue)
            {
                writer.WritePropertyName("acquireStorageAccountLock"u8);
                writer.WriteStringValue(AcquireStorageAccountLock.Value.ToString());
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

        BackupStatusResult IJsonModel<BackupStatusResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupStatusResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupStatusResult(document.RootElement, options);
        }

        internal static BackupStatusResult DeserializeBackupStatusResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupProtectionStatus> protectionStatus = default;
            Optional<ResourceIdentifier> vaultId = default;
            Optional<BackupFabricName> fabricName = default;
            Optional<string> containerName = default;
            Optional<string> protectedItemName = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<string> policyName = default;
            Optional<string> registrationStatus = default;
            Optional<int> protectedItemsCount = default;
            Optional<AcquireStorageAccountLock> acquireStorageAccountLock = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionStatus = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricName = new BackupFabricName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("acquireStorageAccountLock"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acquireStorageAccountLock = new AcquireStorageAccountLock(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupStatusResult(Optional.ToNullable(protectionStatus), vaultId.Value, Optional.ToNullable(fabricName), containerName.Value, protectedItemName.Value, errorCode.Value, errorMessage.Value, policyName.Value, registrationStatus.Value, Optional.ToNullable(protectedItemsCount), Optional.ToNullable(acquireStorageAccountLock), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupStatusResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupStatusResult)} does not support '{options.Format}' format.");
            }
        }

        BackupStatusResult IPersistableModel<BackupStatusResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupStatusResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupStatusResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupStatusResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
