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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadBackupContent : IUtf8JsonSerializable, IJsonModel<WorkloadBackupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadBackupContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadBackupContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WorkloadBackupContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupType))
            {
                writer.WritePropertyName("backupType"u8);
                writer.WriteStringValue(BackupType.Value.ToString());
            }
            if (Optional.IsDefined(EnableCompression))
            {
                writer.WritePropertyName("enableCompression"u8);
                writer.WriteBooleanValue(EnableCompression.Value);
            }
            if (Optional.IsDefined(RecoveryPointExpireOn))
            {
                writer.WritePropertyName("recoveryPointExpiryTimeInUTC"u8);
                writer.WriteStringValue(RecoveryPointExpireOn.Value, "O");
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

        WorkloadBackupContent IJsonModel<WorkloadBackupContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WorkloadBackupContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadBackupContent(document.RootElement, options);
        }

        internal static WorkloadBackupContent DeserializeWorkloadBackupContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupType> backupType = default;
            Optional<bool> enableCompression = default;
            Optional<DateTimeOffset> recoveryPointExpiryTimeInUTC = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupType = new BackupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableCompression"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCompression = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recoveryPointExpiryTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointExpiryTimeInUTC = property.Value.GetDateTimeOffset("O");
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
            return new WorkloadBackupContent(objectType, serializedAdditionalRawData, Optional.ToNullable(backupType), Optional.ToNullable(enableCompression), Optional.ToNullable(recoveryPointExpiryTimeInUTC));
        }

        BinaryData IPersistableModel<WorkloadBackupContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(WorkloadBackupContent)} does not support '{options.Format}' format.");
            }
        }

        WorkloadBackupContent IPersistableModel<WorkloadBackupContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadBackupContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(WorkloadBackupContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadBackupContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
