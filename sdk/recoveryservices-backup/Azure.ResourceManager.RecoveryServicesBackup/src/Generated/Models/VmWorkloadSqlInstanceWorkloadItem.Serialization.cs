// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmWorkloadSqlInstanceWorkloadItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DataDirectoryPaths))
            {
                writer.WritePropertyName("dataDirectoryPaths"u8);
                writer.WriteStartArray();
                foreach (var item in DataDirectoryPaths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ParentName))
            {
                writer.WritePropertyName("parentName"u8);
                writer.WriteStringValue(ParentName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(IsAutoProtectable))
            {
                writer.WritePropertyName("isAutoProtectable"u8);
                writer.WriteBooleanValue(IsAutoProtectable.Value);
            }
            if (Optional.IsDefined(SubInquiredItemCount))
            {
                writer.WritePropertyName("subinquireditemcount"u8);
                writer.WriteNumberValue(SubInquiredItemCount.Value);
            }
            if (Optional.IsDefined(SubWorkloadItemCount))
            {
                writer.WritePropertyName("subWorkloadItemCount"u8);
                writer.WriteNumberValue(SubWorkloadItemCount.Value);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("workloadItemType"u8);
            writer.WriteStringValue(WorkloadItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static VmWorkloadSqlInstanceWorkloadItem DeserializeVmWorkloadSqlInstanceWorkloadItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<SqlDataDirectory>> dataDirectoryPaths = default;
            Optional<string> parentName = default;
            Optional<string> serverName = default;
            Optional<bool> isAutoProtectable = default;
            Optional<int> subinquireditemcount = default;
            Optional<int> subWorkloadItemCount = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string workloadItemType = default;
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDirectoryPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlDataDirectory> array = new List<SqlDataDirectory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDataDirectory.DeserializeSqlDataDirectory(item));
                    }
                    dataDirectoryPaths = array;
                    continue;
                }
                if (property.NameEquals("parentName"u8))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subWorkloadItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subWorkloadItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadItemType"u8))
                {
                    workloadItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
            }
            return new VmWorkloadSqlInstanceWorkloadItem(backupManagementType.Value, workloadType.Value, workloadItemType, friendlyName.Value, Optional.ToNullable(protectionState), parentName.Value, serverName.Value, Optional.ToNullable(isAutoProtectable), Optional.ToNullable(subinquireditemcount), Optional.ToNullable(subWorkloadItemCount), Optional.ToList(dataDirectoryPaths));
        }
    }
}
