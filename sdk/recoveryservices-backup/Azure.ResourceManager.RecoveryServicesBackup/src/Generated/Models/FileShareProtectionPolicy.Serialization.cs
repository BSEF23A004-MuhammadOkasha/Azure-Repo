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
    public partial class FileShareProtectionPolicy : IUtf8JsonSerializable, IJsonModel<FileShareProtectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileShareProtectionPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FileShareProtectionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileShareProtectionPolicy)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(WorkLoadType))
            {
                writer.WritePropertyName("workLoadType"u8);
                writer.WriteStringValue(WorkLoadType.Value.ToString());
            }
            if (Optional.IsDefined(SchedulePolicy))
            {
                writer.WritePropertyName("schedulePolicy"u8);
                writer.WriteObjectValue(SchedulePolicy, options);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy, options);
            }
            if (Optional.IsDefined(VaultRetentionPolicy))
            {
                writer.WritePropertyName("vaultRetentionPolicy"u8);
                writer.WriteObjectValue(VaultRetentionPolicy, options);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
        }

        FileShareProtectionPolicy IJsonModel<FileShareProtectionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileShareProtectionPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileShareProtectionPolicy(document.RootElement, options);
        }

        internal static FileShareProtectionPolicy DeserializeFileShareProtectionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupWorkloadType? workLoadType = default;
            BackupSchedulePolicy schedulePolicy = default;
            BackupRetentionPolicy retentionPolicy = default;
            VaultRetentionPolicy vaultRetentionPolicy = default;
            string timeZone = default;
            int? protectedItemsCount = default;
            string backupManagementType = default;
            IList<string> resourceGuardOperationRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workLoadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workLoadType = new BackupWorkloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedulePolicy = BackupSchedulePolicy.DeserializeBackupSchedulePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPolicy = BackupRetentionPolicy.DeserializeBackupRetentionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vaultRetentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaultRetentionPolicy = VaultRetentionPolicy.DeserializeVaultRetentionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
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
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
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
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FileShareProtectionPolicy(
                protectedItemsCount,
                backupManagementType,
                resourceGuardOperationRequests ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData,
                workLoadType,
                schedulePolicy,
                retentionPolicy,
                vaultRetentionPolicy,
                timeZone);
        }

        BinaryData IPersistableModel<FileShareProtectionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileShareProtectionPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        FileShareProtectionPolicy IPersistableModel<FileShareProtectionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileShareProtectionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileShareProtectionPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileShareProtectionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
