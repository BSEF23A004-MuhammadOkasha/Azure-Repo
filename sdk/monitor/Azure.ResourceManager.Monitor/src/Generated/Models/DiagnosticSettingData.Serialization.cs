// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class DiagnosticSettingData : IUtf8JsonSerializable, IJsonModel<DiagnosticSettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticSettingData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DiagnosticSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(ServiceBusRuleId))
            {
                writer.WritePropertyName("serviceBusRuleId"u8);
                writer.WriteStringValue(ServiceBusRuleId);
            }
            if (Optional.IsDefined(EventHubAuthorizationRuleId))
            {
                writer.WritePropertyName("eventHubAuthorizationRuleId"u8);
                writer.WriteStringValue(EventHubAuthorizationRuleId);
            }
            if (Optional.IsDefined(EventHubName))
            {
                writer.WritePropertyName("eventHubName"u8);
                writer.WriteStringValue(EventHubName);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Logs))
            {
                writer.WritePropertyName("logs"u8);
                writer.WriteStartArray();
                foreach (var item in Logs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(MarketplacePartnerId))
            {
                writer.WritePropertyName("marketplacePartnerId"u8);
                writer.WriteStringValue(MarketplacePartnerId);
            }
            if (Optional.IsDefined(LogAnalyticsDestinationType))
            {
                writer.WritePropertyName("logAnalyticsDestinationType"u8);
                writer.WriteStringValue(LogAnalyticsDestinationType);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        DiagnosticSettingData IJsonModel<DiagnosticSettingData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticSettingData(document.RootElement, options);
        }

        internal static DiagnosticSettingData DeserializeDiagnosticSettingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<ResourceIdentifier> serviceBusRuleId = default;
            Optional<ResourceIdentifier> eventHubAuthorizationRuleId = default;
            Optional<string> eventHubName = default;
            Optional<IList<MetricSettings>> metrics = default;
            Optional<IList<LogSettings>> logs = default;
            Optional<ResourceIdentifier> workspaceId = default;
            Optional<ResourceIdentifier> marketplacePartnerId = default;
            Optional<string> logAnalyticsDestinationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceBusRuleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceBusRuleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubAuthorizationRuleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventHubAuthorizationRuleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubName"u8))
                        {
                            eventHubName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MetricSettings> array = new List<MetricSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MetricSettings.DeserializeMetricSettings(item));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("logs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LogSettings> array = new List<LogSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogSettings.DeserializeLogSettings(item));
                            }
                            logs = array;
                            continue;
                        }
                        if (property0.NameEquals("workspaceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplacePartnerId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplacePartnerId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsDestinationType"u8))
                        {
                            logAnalyticsDestinationType = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiagnosticSettingData(id, name, type, systemData.Value, storageAccountId.Value, serviceBusRuleId.Value, eventHubAuthorizationRuleId.Value, eventHubName.Value, Optional.ToList(metrics), Optional.ToList(logs), workspaceId.Value, marketplacePartnerId.Value, logAnalyticsDestinationType.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<DiagnosticSettingData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DiagnosticSettingData IModel<DiagnosticSettingData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DiagnosticSettingData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDiagnosticSettingData(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DiagnosticSettingData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
