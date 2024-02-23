// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryProcessServerDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryProcessServerDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryProcessServerDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryProcessServerDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServerDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProcessServerDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && BiosId != null)
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            if (options.Format != "W" && FabricObjectId != null)
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (options.Format != "W" && Fqdn != null)
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (options.Format != "W" && !(IPAddresses is ChangeTrackingList<IPAddress> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ipAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && LastHeartbeatReceivedOn.HasValue)
            {
                writer.WritePropertyName("lastHeartbeatUtc"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (options.Format != "W" && TotalMemoryInBytes.HasValue)
            {
                writer.WritePropertyName("totalMemoryInBytes"u8);
                writer.WriteNumberValue(TotalMemoryInBytes.Value);
            }
            if (options.Format != "W" && AvailableMemoryInBytes.HasValue)
            {
                writer.WritePropertyName("availableMemoryInBytes"u8);
                writer.WriteNumberValue(AvailableMemoryInBytes.Value);
            }
            if (options.Format != "W" && UsedMemoryInBytes.HasValue)
            {
                writer.WritePropertyName("usedMemoryInBytes"u8);
                writer.WriteNumberValue(UsedMemoryInBytes.Value);
            }
            if (options.Format != "W" && MemoryUsagePercentage.HasValue)
            {
                writer.WritePropertyName("memoryUsagePercentage"u8);
                writer.WriteNumberValue(MemoryUsagePercentage.Value);
            }
            if (options.Format != "W" && TotalSpaceInBytes.HasValue)
            {
                writer.WritePropertyName("totalSpaceInBytes"u8);
                writer.WriteNumberValue(TotalSpaceInBytes.Value);
            }
            if (options.Format != "W" && AvailableSpaceInBytes.HasValue)
            {
                writer.WritePropertyName("availableSpaceInBytes"u8);
                writer.WriteNumberValue(AvailableSpaceInBytes.Value);
            }
            if (options.Format != "W" && UsedSpaceInBytes.HasValue)
            {
                writer.WritePropertyName("usedSpaceInBytes"u8);
                writer.WriteNumberValue(UsedSpaceInBytes.Value);
            }
            if (options.Format != "W" && FreeSpacePercentage.HasValue)
            {
                writer.WritePropertyName("freeSpacePercentage"u8);
                writer.WriteNumberValue(FreeSpacePercentage.Value);
            }
            if (options.Format != "W" && ThroughputUploadPendingDataInBytes.HasValue)
            {
                writer.WritePropertyName("throughputUploadPendingDataInBytes"u8);
                writer.WriteNumberValue(ThroughputUploadPendingDataInBytes.Value);
            }
            if (options.Format != "W" && ThroughputInBytes.HasValue)
            {
                writer.WritePropertyName("throughputInBytes"u8);
                writer.WriteNumberValue(ThroughputInBytes.Value);
            }
            if (options.Format != "W" && ProcessorUsagePercentage.HasValue)
            {
                writer.WritePropertyName("processorUsagePercentage"u8);
                writer.WriteNumberValue(ProcessorUsagePercentage.Value);
            }
            if (options.Format != "W" && ThroughputStatus.HasValue)
            {
                writer.WritePropertyName("throughputStatus"u8);
                writer.WriteStringValue(ThroughputStatus.Value.ToString());
            }
            if (options.Format != "W" && SystemLoad.HasValue)
            {
                writer.WritePropertyName("systemLoad"u8);
                writer.WriteNumberValue(SystemLoad.Value);
            }
            if (options.Format != "W" && SystemLoadStatus.HasValue)
            {
                writer.WritePropertyName("systemLoadStatus"u8);
                writer.WriteStringValue(SystemLoadStatus.Value.ToString());
            }
            if (options.Format != "W" && DiskUsageStatus.HasValue)
            {
                writer.WritePropertyName("diskUsageStatus"u8);
                writer.WriteStringValue(DiskUsageStatus.Value.ToString());
            }
            if (options.Format != "W" && MemoryUsageStatus.HasValue)
            {
                writer.WritePropertyName("memoryUsageStatus"u8);
                writer.WriteStringValue(MemoryUsageStatus.Value.ToString());
            }
            if (options.Format != "W" && ProcessorUsageStatus.HasValue)
            {
                writer.WritePropertyName("processorUsageStatus"u8);
                writer.WriteStringValue(ProcessorUsageStatus.Value.ToString());
            }
            if (options.Format != "W" && Health.HasValue)
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && !(HealthErrors is ChangeTrackingList<SiteRecoveryHealthError> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProtectedItemCount.HasValue)
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (options.Format != "W" && HistoricHealth.HasValue)
            {
                writer.WritePropertyName("historicHealth"u8);
                writer.WriteStringValue(HistoricHealth.Value.ToString());
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

        SiteRecoveryProcessServerDetails IJsonModel<SiteRecoveryProcessServerDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServerDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProcessServerDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProcessServerDetails(document.RootElement, options);
        }

        internal static SiteRecoveryProcessServerDetails DeserializeSiteRecoveryProcessServerDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> biosId = default;
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<string> fqdn = default;
            IReadOnlyList<IPAddress> ipAddresses = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> lastHeartbeatUtc = default;
            Optional<long> totalMemoryInBytes = default;
            Optional<long> availableMemoryInBytes = default;
            Optional<long> usedMemoryInBytes = default;
            Optional<double> memoryUsagePercentage = default;
            Optional<long> totalSpaceInBytes = default;
            Optional<long> availableSpaceInBytes = default;
            Optional<long> usedSpaceInBytes = default;
            Optional<double> freeSpacePercentage = default;
            Optional<long> throughputUploadPendingDataInBytes = default;
            Optional<long> throughputInBytes = default;
            Optional<double> processorUsagePercentage = default;
            Optional<RcmComponentStatus> throughputStatus = default;
            Optional<long> systemLoad = default;
            Optional<RcmComponentStatus> systemLoadStatus = default;
            Optional<RcmComponentStatus> diskUsageStatus = default;
            Optional<RcmComponentStatus> memoryUsageStatus = default;
            Optional<RcmComponentStatus> processorUsageStatus = default;
            Optional<SiteRecoveryProtectionHealth> health = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            Optional<int> protectedItemCount = default;
            Optional<SiteRecoveryProtectionHealth> historicHealth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("usedMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryUsagePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryUsagePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("usedSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("freeSpacePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    freeSpacePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("throughputUploadPendingDataInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputUploadPendingDataInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("processorUsagePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorUsagePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("throughputStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemLoad = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("systemLoadStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemLoadStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskUsageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskUsageStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("memoryUsageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryUsageStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("processorUsageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorUsageStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("historicHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    historicHealth = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryProcessServerDetails(id.Value, name.Value, biosId.Value, fabricObjectId.Value, fqdn.Value, ipAddresses ?? new ChangeTrackingList<IPAddress>(), version.Value, Optional.ToNullable(lastHeartbeatUtc), Optional.ToNullable(totalMemoryInBytes), Optional.ToNullable(availableMemoryInBytes), Optional.ToNullable(usedMemoryInBytes), Optional.ToNullable(memoryUsagePercentage), Optional.ToNullable(totalSpaceInBytes), Optional.ToNullable(availableSpaceInBytes), Optional.ToNullable(usedSpaceInBytes), Optional.ToNullable(freeSpacePercentage), Optional.ToNullable(throughputUploadPendingDataInBytes), Optional.ToNullable(throughputInBytes), Optional.ToNullable(processorUsagePercentage), Optional.ToNullable(throughputStatus), Optional.ToNullable(systemLoad), Optional.ToNullable(systemLoadStatus), Optional.ToNullable(diskUsageStatus), Optional.ToNullable(memoryUsageStatus), Optional.ToNullable(processorUsageStatus), Optional.ToNullable(health), healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(), Optional.ToNullable(protectedItemCount), Optional.ToNullable(historicHealth), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryProcessServerDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServerDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProcessServerDetails)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryProcessServerDetails IPersistableModel<SiteRecoveryProcessServerDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProcessServerDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryProcessServerDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProcessServerDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryProcessServerDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
