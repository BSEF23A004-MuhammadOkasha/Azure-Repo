// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class ServerEndpointCloudTieringStatus : IUtf8JsonSerializable, IJsonModel<ServerEndpointCloudTieringStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerEndpointCloudTieringStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerEndpointCloudTieringStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointCloudTieringStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointCloudTieringStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Health.HasValue)
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && HealthLastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("healthLastUpdatedTimestamp"u8);
                writer.WriteStringValue(HealthLastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && LastCloudTieringResult.HasValue)
            {
                writer.WritePropertyName("lastCloudTieringResult"u8);
                writer.WriteNumberValue(LastCloudTieringResult.Value);
            }
            if (options.Format != "W" && LastSuccessTimestamp.HasValue)
            {
                writer.WritePropertyName("lastSuccessTimestamp"u8);
                writer.WriteStringValue(LastSuccessTimestamp.Value, "O");
            }
            if (options.Format != "W" && SpaceSavings != null)
            {
                writer.WritePropertyName("spaceSavings"u8);
                writer.WriteObjectValue(SpaceSavings);
            }
            if (options.Format != "W" && CachePerformance != null)
            {
                writer.WritePropertyName("cachePerformance"u8);
                writer.WriteObjectValue(CachePerformance);
            }
            if (options.Format != "W" && FilesNotTiering != null)
            {
                writer.WritePropertyName("filesNotTiering"u8);
                writer.WriteObjectValue(FilesNotTiering);
            }
            if (options.Format != "W" && VolumeFreeSpacePolicyStatus != null)
            {
                writer.WritePropertyName("volumeFreeSpacePolicyStatus"u8);
                writer.WriteObjectValue(VolumeFreeSpacePolicyStatus);
            }
            if (options.Format != "W" && DatePolicyStatus != null)
            {
                writer.WritePropertyName("datePolicyStatus"u8);
                writer.WriteObjectValue(DatePolicyStatus);
            }
            if (options.Format != "W" && LowDiskMode != null)
            {
                writer.WritePropertyName("lowDiskMode"u8);
                writer.WriteObjectValue(LowDiskMode);
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

        ServerEndpointCloudTieringStatus IJsonModel<ServerEndpointCloudTieringStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointCloudTieringStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointCloudTieringStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEndpointCloudTieringStatus(document.RootElement, options);
        }

        internal static ServerEndpointCloudTieringStatus DeserializeServerEndpointCloudTieringStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<ServerEndpointHealthState> health = default;
            Optional<DateTimeOffset> healthLastUpdatedTimestamp = default;
            Optional<int> lastCloudTieringResult = default;
            Optional<DateTimeOffset> lastSuccessTimestamp = default;
            Optional<CloudTieringSpaceSavings> spaceSavings = default;
            Optional<CloudTieringCachePerformance> cachePerformance = default;
            Optional<CloudTieringFilesNotTiering> filesNotTiering = default;
            Optional<CloudTieringVolumeFreeSpacePolicyStatus> volumeFreeSpacePolicyStatus = default;
            Optional<CloudTieringDatePolicyStatus> datePolicyStatus = default;
            Optional<CloudTieringLowDiskMode> lowDiskMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new ServerEndpointHealthState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthLastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthLastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastCloudTieringResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastCloudTieringResult = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastSuccessTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("spaceSavings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spaceSavings = CloudTieringSpaceSavings.DeserializeCloudTieringSpaceSavings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cachePerformance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cachePerformance = CloudTieringCachePerformance.DeserializeCloudTieringCachePerformance(property.Value, options);
                    continue;
                }
                if (property.NameEquals("filesNotTiering"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesNotTiering = CloudTieringFilesNotTiering.DeserializeCloudTieringFilesNotTiering(property.Value, options);
                    continue;
                }
                if (property.NameEquals("volumeFreeSpacePolicyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumeFreeSpacePolicyStatus = CloudTieringVolumeFreeSpacePolicyStatus.DeserializeCloudTieringVolumeFreeSpacePolicyStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datePolicyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datePolicyStatus = CloudTieringDatePolicyStatus.DeserializeCloudTieringDatePolicyStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lowDiskMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowDiskMode = CloudTieringLowDiskMode.DeserializeCloudTieringLowDiskMode(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerEndpointCloudTieringStatus(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(health), Optional.ToNullable(healthLastUpdatedTimestamp), Optional.ToNullable(lastCloudTieringResult), Optional.ToNullable(lastSuccessTimestamp), spaceSavings.Value, cachePerformance.Value, filesNotTiering.Value, volumeFreeSpacePolicyStatus.Value, datePolicyStatus.Value, lowDiskMode.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerEndpointCloudTieringStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointCloudTieringStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointCloudTieringStatus)} does not support '{options.Format}' format.");
            }
        }

        ServerEndpointCloudTieringStatus IPersistableModel<ServerEndpointCloudTieringStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointCloudTieringStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerEndpointCloudTieringStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointCloudTieringStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerEndpointCloudTieringStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
