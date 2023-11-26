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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageProtectedDiskDetails : IUtf8JsonSerializable, IJsonModel<InMageProtectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageProtectedDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageProtectedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InMageProtectedDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(DiskName))
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (Optional.IsDefined(ProtectionStage))
            {
                writer.WritePropertyName("protectionStage"u8);
                writer.WriteStringValue(ProtectionStage);
            }
            if (Optional.IsDefined(HealthErrorCode))
            {
                writer.WritePropertyName("healthErrorCode"u8);
                writer.WriteStringValue(HealthErrorCode);
            }
            if (Optional.IsDefined(RpoInSeconds))
            {
                writer.WritePropertyName("rpoInSeconds"u8);
                writer.WriteNumberValue(RpoInSeconds.Value);
            }
            if (Optional.IsDefined(ResyncRequired))
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteStringValue(ResyncRequired);
            }
            if (Optional.IsDefined(ResyncProgressPercentage))
            {
                writer.WritePropertyName("resyncProgressPercentage"u8);
                writer.WriteNumberValue(ResyncProgressPercentage.Value);
            }
            if (Optional.IsDefined(ResyncDurationInSeconds))
            {
                writer.WritePropertyName("resyncDurationInSeconds"u8);
                writer.WriteNumberValue(ResyncDurationInSeconds.Value);
            }
            if (Optional.IsDefined(DiskCapacityInBytes))
            {
                writer.WritePropertyName("diskCapacityInBytes"u8);
                writer.WriteNumberValue(DiskCapacityInBytes.Value);
            }
            if (Optional.IsDefined(FileSystemCapacityInBytes))
            {
                writer.WritePropertyName("fileSystemCapacityInBytes"u8);
                writer.WriteNumberValue(FileSystemCapacityInBytes.Value);
            }
            if (Optional.IsDefined(SourceDataInMB))
            {
                writer.WritePropertyName("sourceDataInMB"u8);
                writer.WriteNumberValue(SourceDataInMB.Value);
            }
            if (Optional.IsDefined(PSDataInMB))
            {
                writer.WritePropertyName("psDataInMB"u8);
                writer.WriteNumberValue(PSDataInMB.Value);
            }
            if (Optional.IsDefined(TargetDataInMB))
            {
                writer.WritePropertyName("targetDataInMB"u8);
                writer.WriteNumberValue(TargetDataInMB.Value);
            }
            if (Optional.IsDefined(DiskResized))
            {
                writer.WritePropertyName("diskResized"u8);
                writer.WriteStringValue(DiskResized);
            }
            if (Optional.IsDefined(LastRpoCalculatedOn))
            {
                writer.WritePropertyName("lastRpoCalculatedTime"u8);
                writer.WriteStringValue(LastRpoCalculatedOn.Value, "O");
            }
            if (Optional.IsDefined(ResyncProcessedBytes))
            {
                writer.WritePropertyName("resyncProcessedBytes"u8);
                writer.WriteNumberValue(ResyncProcessedBytes.Value);
            }
            if (Optional.IsDefined(ResyncTotalTransferredBytes))
            {
                writer.WritePropertyName("resyncTotalTransferredBytes"u8);
                writer.WriteNumberValue(ResyncTotalTransferredBytes.Value);
            }
            if (Optional.IsDefined(ResyncLast15MinutesTransferredBytes))
            {
                writer.WritePropertyName("resyncLast15MinutesTransferredBytes"u8);
                writer.WriteNumberValue(ResyncLast15MinutesTransferredBytes.Value);
            }
            if (Optional.IsDefined(ResyncLastDataTransferTimeUTC))
            {
                writer.WritePropertyName("resyncLastDataTransferTimeUTC"u8);
                writer.WriteStringValue(ResyncLastDataTransferTimeUTC.Value, "O");
            }
            if (Optional.IsDefined(ResyncStartOn))
            {
                writer.WritePropertyName("resyncStartTime"u8);
                writer.WriteStringValue(ResyncStartOn.Value, "O");
            }
            if (Optional.IsDefined(ProgressHealth))
            {
                writer.WritePropertyName("progressHealth"u8);
                writer.WriteStringValue(ProgressHealth);
            }
            if (Optional.IsDefined(ProgressStatus))
            {
                writer.WritePropertyName("progressStatus"u8);
                writer.WriteStringValue(ProgressStatus);
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

        InMageProtectedDiskDetails IJsonModel<InMageProtectedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InMageProtectedDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageProtectedDiskDetails(document.RootElement, options);
        }

        internal static InMageProtectedDiskDetails DeserializeInMageProtectedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> diskName = default;
            Optional<string> protectionStage = default;
            Optional<string> healthErrorCode = default;
            Optional<long> rpoInSeconds = default;
            Optional<string> resyncRequired = default;
            Optional<int> resyncProgressPercentage = default;
            Optional<long> resyncDurationInSeconds = default;
            Optional<long> diskCapacityInBytes = default;
            Optional<long> fileSystemCapacityInBytes = default;
            Optional<double> sourceDataInMB = default;
            Optional<double> psDataInMB = default;
            Optional<double> targetDataInMB = default;
            Optional<string> diskResized = default;
            Optional<DateTimeOffset> lastRpoCalculatedTime = default;
            Optional<long> resyncProcessedBytes = default;
            Optional<long> resyncTotalTransferredBytes = default;
            Optional<long> resyncLast15MinutesTransferredBytes = default;
            Optional<DateTimeOffset> resyncLastDataTransferTimeUTC = default;
            Optional<DateTimeOffset> resyncStartTime = default;
            Optional<string> progressHealth = default;
            Optional<string> progressStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStage"u8))
                {
                    protectionStage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrorCode"u8))
                {
                    healthErrorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpoInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rpoInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    resyncRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncDurationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncDurationInSeconds = property.Value.GetInt64();
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
                if (property.NameEquals("fileSystemCapacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileSystemCapacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sourceDataInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceDataInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("psDataInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    psDataInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("targetDataInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDataInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("diskResized"u8))
                {
                    diskResized = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRpoCalculatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoCalculatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resyncProcessedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncTotalTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncTotalTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncLast15MinutesTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncLast15MinutesTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncLastDataTransferTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncLastDataTransferTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resyncStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("progressHealth"u8))
                {
                    progressHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progressStatus"u8))
                {
                    progressStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageProtectedDiskDetails(diskId.Value, diskName.Value, protectionStage.Value, healthErrorCode.Value, Optional.ToNullable(rpoInSeconds), resyncRequired.Value, Optional.ToNullable(resyncProgressPercentage), Optional.ToNullable(resyncDurationInSeconds), Optional.ToNullable(diskCapacityInBytes), Optional.ToNullable(fileSystemCapacityInBytes), Optional.ToNullable(sourceDataInMB), Optional.ToNullable(psDataInMB), Optional.ToNullable(targetDataInMB), diskResized.Value, Optional.ToNullable(lastRpoCalculatedTime), Optional.ToNullable(resyncProcessedBytes), Optional.ToNullable(resyncTotalTransferredBytes), Optional.ToNullable(resyncLast15MinutesTransferredBytes), Optional.ToNullable(resyncLastDataTransferTimeUTC), Optional.ToNullable(resyncStartTime), progressHealth.Value, progressStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageProtectedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(InMageProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageProtectedDiskDetails IPersistableModel<InMageProtectedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageProtectedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(InMageProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageProtectedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
