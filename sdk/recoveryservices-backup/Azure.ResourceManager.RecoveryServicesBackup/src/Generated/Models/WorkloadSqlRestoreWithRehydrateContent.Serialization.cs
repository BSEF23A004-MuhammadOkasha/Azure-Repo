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
    public partial class WorkloadSqlRestoreWithRehydrateContent : IUtf8JsonSerializable, IJsonModel<WorkloadSqlRestoreWithRehydrateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadSqlRestoreWithRehydrateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadSqlRestoreWithRehydrateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreWithRehydrateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlRestoreWithRehydrateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RecoveryPointRehydrationInfo != null)
            {
                writer.WritePropertyName("recoveryPointRehydrationInfo"u8);
                writer.WriteObjectValue(RecoveryPointRehydrationInfo);
            }
            if (ShouldUseAlternateTargetLocation.HasValue)
            {
                writer.WritePropertyName("shouldUseAlternateTargetLocation"u8);
                writer.WriteBooleanValue(ShouldUseAlternateTargetLocation.Value);
            }
            if (IsNonRecoverable.HasValue)
            {
                writer.WritePropertyName("isNonRecoverable"u8);
                writer.WriteBooleanValue(IsNonRecoverable.Value);
            }
            if (!(AlternateDirectoryPaths is ChangeTrackingList<SqlDataDirectoryMapping> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("alternateDirectoryPaths"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateDirectoryPaths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RecoveryType.HasValue)
            {
                writer.WritePropertyName("recoveryType"u8);
                writer.WriteStringValue(RecoveryType.Value.ToString());
            }
            if (SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (!(PropertyBag is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (TargetInfo != null)
            {
                writer.WritePropertyName("targetInfo"u8);
                writer.WriteObjectValue(TargetInfo);
            }
            if (RecoveryMode.HasValue)
            {
                writer.WritePropertyName("recoveryMode"u8);
                writer.WriteStringValue(RecoveryMode.Value.ToString());
            }
            if (TargetResourceGroupName != null)
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
            }
            if (UserAssignedManagedIdentityDetails != null)
            {
                writer.WritePropertyName("userAssignedManagedIdentityDetails"u8);
                writer.WriteObjectValue(UserAssignedManagedIdentityDetails);
            }
            if (SnapshotRestoreParameters != null)
            {
                writer.WritePropertyName("snapshotRestoreParameters"u8);
                writer.WriteObjectValue(SnapshotRestoreParameters);
            }
            if (TargetVirtualMachineId != null)
            {
                writer.WritePropertyName("targetVirtualMachineId"u8);
                writer.WriteStringValue(TargetVirtualMachineId);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        WorkloadSqlRestoreWithRehydrateContent IJsonModel<WorkloadSqlRestoreWithRehydrateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreWithRehydrateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlRestoreWithRehydrateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSqlRestoreWithRehydrateContent(document.RootElement, options);
        }

        internal static WorkloadSqlRestoreWithRehydrateContent DeserializeWorkloadSqlRestoreWithRehydrateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RecoveryPointRehydrationInfo> recoveryPointRehydrationInfo = default;
            Optional<bool> shouldUseAlternateTargetLocation = default;
            Optional<bool> isNonRecoverable = default;
            IList<SqlDataDirectoryMapping> alternateDirectoryPaths = default;
            Optional<FileShareRecoveryType> recoveryType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<IDictionary<string, string>> propertyBag = default;
            Optional<TargetRestoreInfo> targetInfo = default;
            Optional<RecoveryMode> recoveryMode = default;
            Optional<string> targetResourceGroupName = default;
            Optional<UserAssignedManagedIdentityDetails> userAssignedManagedIdentityDetails = default;
            Optional<SnapshotRestoreContent> snapshotRestoreParameters = default;
            Optional<ResourceIdentifier> targetVirtualMachineId = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointRehydrationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointRehydrationInfo = RecoveryPointRehydrationInfo.DeserializeRecoveryPointRehydrationInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("shouldUseAlternateTargetLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shouldUseAlternateTargetLocation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNonRecoverable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNonRecoverable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("alternateDirectoryPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlDataDirectoryMapping> array = new List<SqlDataDirectoryMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDataDirectoryMapping.DeserializeSqlDataDirectoryMapping(item, options));
                    }
                    alternateDirectoryPaths = array;
                    continue;
                }
                if (property.NameEquals("recoveryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryType = new FileShareRecoveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("targetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetInfo = TargetRestoreInfo.DeserializeTargetRestoreInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryMode = new RecoveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssignedManagedIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedManagedIdentityDetails = UserAssignedManagedIdentityDetails.DeserializeUserAssignedManagedIdentityDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("snapshotRestoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotRestoreParameters = SnapshotRestoreContent.DeserializeSnapshotRestoreContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkloadSqlRestoreWithRehydrateContent(objectType, serializedAdditionalRawData, Optional.ToNullable(recoveryType), sourceResourceId.Value, Optional.ToDictionary(propertyBag), targetInfo.Value, Optional.ToNullable(recoveryMode), targetResourceGroupName.Value, userAssignedManagedIdentityDetails.Value, snapshotRestoreParameters.Value, targetVirtualMachineId.Value, Optional.ToNullable(shouldUseAlternateTargetLocation), Optional.ToNullable(isNonRecoverable), alternateDirectoryPaths ?? new ChangeTrackingList<SqlDataDirectoryMapping>(), recoveryPointRehydrationInfo.Value);
        }

        BinaryData IPersistableModel<WorkloadSqlRestoreWithRehydrateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreWithRehydrateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlRestoreWithRehydrateContent)} does not support '{options.Format}' format.");
            }
        }

        WorkloadSqlRestoreWithRehydrateContent IPersistableModel<WorkloadSqlRestoreWithRehydrateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreWithRehydrateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadSqlRestoreWithRehydrateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlRestoreWithRehydrateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadSqlRestoreWithRehydrateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
