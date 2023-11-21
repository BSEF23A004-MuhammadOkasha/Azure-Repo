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

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceMonitorVmInfo : IUtf8JsonSerializable, IJsonModel<DynatraceMonitorVmInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceMonitorVmInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DynatraceMonitorVmInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DynatraceMonitorVmInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(MonitoringType))
            {
                writer.WritePropertyName("monitoringType"u8);
                writer.WriteStringValue(MonitoringType.Value.ToString());
            }
            if (Optional.IsDefined(AutoUpdateSetting))
            {
                writer.WritePropertyName("autoUpdateSetting"u8);
                writer.WriteStringValue(AutoUpdateSetting.Value.ToString());
            }
            if (Optional.IsDefined(UpdateStatus))
            {
                writer.WritePropertyName("updateStatus"u8);
                writer.WriteStringValue(UpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(AvailabilityState))
            {
                writer.WritePropertyName("availabilityState"u8);
                writer.WriteStringValue(AvailabilityState.Value.ToString());
            }
            if (Optional.IsDefined(LogModule))
            {
                writer.WritePropertyName("logModule"u8);
                writer.WriteStringValue(LogModule.Value.ToString());
            }
            if (Optional.IsDefined(HostGroup))
            {
                writer.WritePropertyName("hostGroup"u8);
                writer.WriteStringValue(HostGroup);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
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

        DynatraceMonitorVmInfo IJsonModel<DynatraceMonitorVmInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DynatraceMonitorVmInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceMonitorVmInfo(document.RootElement, options);
        }

        internal static DynatraceMonitorVmInfo DeserializeDynatraceMonitorVmInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> version = default;
            Optional<DynatraceOneAgentMonitoringType> monitoringType = default;
            Optional<DynatraceOneAgentAutoUpdateSetting> autoUpdateSetting = default;
            Optional<DynatraceOneAgentUpdateStatus> updateStatus = default;
            Optional<DynatraceOneAgentAvailabilityState> availabilityState = default;
            Optional<DynatraceLogModuleState> logModule = default;
            Optional<string> hostGroup = default;
            Optional<string> hostName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitoringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringType = new DynatraceOneAgentMonitoringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autoUpdateSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUpdateSetting = new DynatraceOneAgentAutoUpdateSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateStatus = new DynatraceOneAgentUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availabilityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availabilityState = new DynatraceOneAgentAvailabilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logModule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logModule = new DynatraceLogModuleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostGroup"u8))
                {
                    hostGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DynatraceMonitorVmInfo(resourceId.Value, version.Value, Optional.ToNullable(monitoringType), Optional.ToNullable(autoUpdateSetting), Optional.ToNullable(updateStatus), Optional.ToNullable(availabilityState), Optional.ToNullable(logModule), hostGroup.Value, hostName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceMonitorVmInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DynatraceMonitorVmInfo)} does not support '{options.Format}' format.");
            }
        }

        DynatraceMonitorVmInfo IPersistableModel<DynatraceMonitorVmInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceMonitorVmInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DynatraceMonitorVmInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceMonitorVmInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
