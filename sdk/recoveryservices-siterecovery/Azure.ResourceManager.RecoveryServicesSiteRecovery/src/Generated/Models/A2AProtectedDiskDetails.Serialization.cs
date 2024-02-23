// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AProtectedDiskDetails : IUtf8JsonSerializable, IJsonModel<A2AProtectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AProtectedDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AProtectedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AProtectedDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DiskUri != null)
            {
                writer.WritePropertyName("diskUri"u8);
                writer.WriteStringValue(DiskUri.AbsoluteUri);
            }
            if (RecoveryAzureStorageAccountId != null)
            {
                writer.WritePropertyName("recoveryAzureStorageAccountId"u8);
                writer.WriteStringValue(RecoveryAzureStorageAccountId);
            }
            if (PrimaryDiskAzureStorageAccountId != null)
            {
                writer.WritePropertyName("primaryDiskAzureStorageAccountId"u8);
                writer.WriteStringValue(PrimaryDiskAzureStorageAccountId);
            }
            if (RecoveryDiskUri != null)
            {
                writer.WritePropertyName("recoveryDiskUri"u8);
                writer.WriteStringValue(RecoveryDiskUri.AbsoluteUri);
            }
            if (DiskName != null)
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (DiskCapacityInBytes.HasValue)
            {
                writer.WritePropertyName("diskCapacityInBytes"u8);
                writer.WriteNumberValue(DiskCapacityInBytes.Value);
            }
            if (PrimaryStagingAzureStorageAccountId != null)
            {
                writer.WritePropertyName("primaryStagingAzureStorageAccountId"u8);
                writer.WriteStringValue(PrimaryStagingAzureStorageAccountId);
            }
            if (DiskType != null)
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType);
            }
            if (IsResyncRequired.HasValue)
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteBooleanValue(IsResyncRequired.Value);
            }
            if (MonitoringPercentageCompletion.HasValue)
            {
                writer.WritePropertyName("monitoringPercentageCompletion"u8);
                writer.WriteNumberValue(MonitoringPercentageCompletion.Value);
            }
            if (MonitoringJobType != null)
            {
                writer.WritePropertyName("monitoringJobType"u8);
                writer.WriteStringValue(MonitoringJobType);
            }
            if (DataPendingInStagingStorageAccountInMB.HasValue)
            {
                writer.WritePropertyName("dataPendingInStagingStorageAccountInMB"u8);
                writer.WriteNumberValue(DataPendingInStagingStorageAccountInMB.Value);
            }
            if (DataPendingAtSourceAgentInMB.HasValue)
            {
                writer.WritePropertyName("dataPendingAtSourceAgentInMB"u8);
                writer.WriteNumberValue(DataPendingAtSourceAgentInMB.Value);
            }
            if (DiskState != null)
            {
                writer.WritePropertyName("diskState"u8);
                writer.WriteStringValue(DiskState);
            }
            if (!(AllowedDiskLevelOperation is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedDiskLevelOperation"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedDiskLevelOperation)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsDiskEncrypted.HasValue)
            {
                writer.WritePropertyName("isDiskEncrypted"u8);
                writer.WriteBooleanValue(IsDiskEncrypted.Value);
            }
            if (SecretIdentifier != null)
            {
                writer.WritePropertyName("secretIdentifier"u8);
                writer.WriteStringValue(SecretIdentifier);
            }
            if (DekKeyVaultArmId != null)
            {
                writer.WritePropertyName("dekKeyVaultArmId"u8);
                writer.WriteStringValue(DekKeyVaultArmId);
            }
            if (IsDiskKeyEncrypted.HasValue)
            {
                writer.WritePropertyName("isDiskKeyEncrypted"u8);
                writer.WriteBooleanValue(IsDiskKeyEncrypted.Value);
            }
            if (KeyIdentifier != null)
            {
                writer.WritePropertyName("keyIdentifier"u8);
                writer.WriteStringValue(KeyIdentifier);
            }
            if (KekKeyVaultArmId != null)
            {
                writer.WritePropertyName("kekKeyVaultArmId"u8);
                writer.WriteStringValue(KekKeyVaultArmId);
            }
            if (FailoverDiskName != null)
            {
                writer.WritePropertyName("failoverDiskName"u8);
                writer.WriteStringValue(FailoverDiskName);
            }
            if (TfoDiskName != null)
            {
                writer.WritePropertyName("tfoDiskName"u8);
                writer.WriteStringValue(TfoDiskName);
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

        A2AProtectedDiskDetails IJsonModel<A2AProtectedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AProtectedDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AProtectedDiskDetails(document.RootElement, options);
        }

        internal static A2AProtectedDiskDetails DeserializeA2AProtectedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> diskUri = default;
            Optional<ResourceIdentifier> recoveryAzureStorageAccountId = default;
            Optional<ResourceIdentifier> primaryDiskAzureStorageAccountId = default;
            Optional<Uri> recoveryDiskUri = default;
            Optional<string> diskName = default;
            Optional<long> diskCapacityInBytes = default;
            Optional<ResourceIdentifier> primaryStagingAzureStorageAccountId = default;
            Optional<string> diskType = default;
            Optional<bool> resyncRequired = default;
            Optional<int> monitoringPercentageCompletion = default;
            Optional<string> monitoringJobType = default;
            Optional<double> dataPendingInStagingStorageAccountInMB = default;
            Optional<double> dataPendingAtSourceAgentInMB = default;
            Optional<string> diskState = default;
            IReadOnlyList<string> allowedDiskLevelOperation = default;
            Optional<bool> isDiskEncrypted = default;
            Optional<string> secretIdentifier = default;
            Optional<ResourceIdentifier> dekKeyVaultArmId = default;
            Optional<bool> isDiskKeyEncrypted = default;
            Optional<string> keyIdentifier = default;
            Optional<ResourceIdentifier> kekKeyVaultArmId = default;
            Optional<string> failoverDiskName = default;
            Optional<string> tfoDiskName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryDiskAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryDiskAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryDiskUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryDiskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskCapacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCapacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("primaryStagingAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryStagingAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    diskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("monitoringPercentageCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringPercentageCompletion = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monitoringJobType"u8))
                {
                    monitoringJobType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPendingInStagingStorageAccountInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingInStagingStorageAccountInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dataPendingAtSourceAgentInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingAtSourceAgentInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("diskState"u8))
                {
                    diskState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedDiskLevelOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedDiskLevelOperation = array;
                    continue;
                }
                if (property.NameEquals("isDiskEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDiskEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("secretIdentifier"u8))
                {
                    secretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dekKeyVaultArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dekKeyVaultArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDiskKeyEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDiskKeyEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kekKeyVaultArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekKeyVaultArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failoverDiskName"u8))
                {
                    failoverDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoDiskName"u8))
                {
                    tfoDiskName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AProtectedDiskDetails(diskUri.Value, recoveryAzureStorageAccountId.Value, primaryDiskAzureStorageAccountId.Value, recoveryDiskUri.Value, diskName.Value, Optional.ToNullable(diskCapacityInBytes), primaryStagingAzureStorageAccountId.Value, diskType.Value, Optional.ToNullable(resyncRequired), Optional.ToNullable(monitoringPercentageCompletion), monitoringJobType.Value, Optional.ToNullable(dataPendingInStagingStorageAccountInMB), Optional.ToNullable(dataPendingAtSourceAgentInMB), diskState.Value, allowedDiskLevelOperation ?? new ChangeTrackingList<string>(), Optional.ToNullable(isDiskEncrypted), secretIdentifier.Value, dekKeyVaultArmId.Value, Optional.ToNullable(isDiskKeyEncrypted), keyIdentifier.Value, kekKeyVaultArmId.Value, failoverDiskName.Value, tfoDiskName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<A2AProtectedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        A2AProtectedDiskDetails IPersistableModel<A2AProtectedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AProtectedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AProtectedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
