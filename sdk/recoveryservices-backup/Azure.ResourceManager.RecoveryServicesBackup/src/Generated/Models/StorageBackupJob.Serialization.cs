// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class StorageBackupJob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            if (Optional.IsCollectionDefined(ActionsInfo))
            {
                writer.WritePropertyName("actionsInfo"u8);
                writer.WriteStartArray();
                foreach (var item in ActionsInfo)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ErrorDetails))
            {
                writer.WritePropertyName("errorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ErrorDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageAccountName))
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            if (Optional.IsDefined(StorageAccountVersion))
            {
                writer.WritePropertyName("storageAccountVersion"u8);
                writer.WriteStringValue(StorageAccountVersion);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (Optional.IsDefined(IsUserTriggered))
            {
                writer.WritePropertyName("isUserTriggered"u8);
                writer.WriteBooleanValue(IsUserTriggered.Value);
            }
            if (Optional.IsDefined(EntityFriendlyName))
            {
                writer.WritePropertyName("entityFriendlyName"u8);
                writer.WriteStringValue(EntityFriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType);
            writer.WriteEndObject();
        }

        internal static StorageBackupJob DeserializeStorageBackupJob(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> duration = default;
            Optional<IList<JobSupportedAction>> actionsInfo = default;
            Optional<IList<StorageErrorInfo>> errorDetails = default;
            Optional<string> storageAccountName = default;
            Optional<string> storageAccountVersion = default;
            Optional<StorageBackupJobExtendedInfo> extendedInfo = default;
            Optional<bool> isUserTriggered = default;
            Optional<string> entityFriendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> operation = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> activityId = default;
            string jobType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("actionsInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobSupportedAction> array = new List<JobSupportedAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToJobSupportedAction());
                    }
                    actionsInfo = array;
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageErrorInfo> array = new List<StorageErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageErrorInfo.DeserializeStorageErrorInfo(item));
                    }
                    errorDetails = array;
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountVersion"u8))
                {
                    storageAccountVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = StorageBackupJobExtendedInfo.DeserializeStorageBackupJobExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("isUserTriggered"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isUserTriggered = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("entityFriendlyName"u8))
                {
                    entityFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = property.Value.GetString();
                    continue;
                }
            }
            return new StorageBackupJob(entityFriendlyName.Value, Optional.ToNullable(backupManagementType), operation.Value, status.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), activityId.Value, jobType, Optional.ToNullable(duration), Optional.ToList(actionsInfo), Optional.ToList(errorDetails), storageAccountName.Value, storageAccountVersion.Value, extendedInfo.Value, Optional.ToNullable(isUserTriggered));
        }
    }
}
