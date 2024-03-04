// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    public partial class StorageSyncRegisteredServerData : IUtf8JsonSerializable, IJsonModel<StorageSyncRegisteredServerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSyncRegisteredServerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageSyncRegisteredServerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncRegisteredServerData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerCertificate))
            {
                writer.WritePropertyName("serverCertificate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServerCertificate);
#else
                using (JsonDocument document = JsonDocument.Parse(ServerCertificate))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentVersionStatus))
            {
                writer.WritePropertyName("agentVersionStatus"u8);
                writer.WriteStringValue(AgentVersionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AgentVersionExpireOn))
            {
                writer.WritePropertyName("agentVersionExpirationDate"u8);
                writer.WriteStringValue(AgentVersionExpireOn.Value, "O");
            }
            if (Optional.IsDefined(ServerOSVersion))
            {
                writer.WritePropertyName("serverOSVersion"u8);
                writer.WriteStringValue(ServerOSVersion);
            }
            if (Optional.IsDefined(ServerManagementErrorCode))
            {
                writer.WritePropertyName("serverManagementErrorCode"u8);
                writer.WriteNumberValue(ServerManagementErrorCode.Value);
            }
            if (Optional.IsDefined(LastHeartbeat))
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartbeat);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(ServerRole))
            {
                writer.WritePropertyName("serverRole"u8);
                writer.WriteStringValue(ServerRole);
            }
            if (Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId.Value);
            }
            if (Optional.IsDefined(ClusterName))
            {
                writer.WritePropertyName("clusterName"u8);
                writer.WriteStringValue(ClusterName);
            }
            if (Optional.IsDefined(ServerId))
            {
                writer.WritePropertyName("serverId"u8);
                writer.WriteStringValue(ServerId.Value);
            }
            if (Optional.IsDefined(StorageSyncServiceUid))
            {
                writer.WritePropertyName("storageSyncServiceUid"u8);
                writer.WriteStringValue(StorageSyncServiceUid.Value);
            }
            if (Optional.IsDefined(LastWorkflowId))
            {
                writer.WritePropertyName("lastWorkflowId"u8);
                writer.WriteStringValue(LastWorkflowId);
            }
            if (Optional.IsDefined(LastOperationName))
            {
                writer.WritePropertyName("lastOperationName"u8);
                writer.WriteStringValue(LastOperationName);
            }
            if (Optional.IsDefined(DiscoveryEndpointUri))
            {
                writer.WritePropertyName("discoveryEndpointUri"u8);
                writer.WriteStringValue(DiscoveryEndpointUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation.Value);
            }
            if (Optional.IsDefined(ServiceLocation))
            {
                writer.WritePropertyName("serviceLocation"u8);
                writer.WriteStringValue(ServiceLocation.Value);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ManagementEndpointUri))
            {
                writer.WritePropertyName("managementEndpointUri"u8);
                writer.WriteStringValue(ManagementEndpointUri.AbsoluteUri);
            }
            if (Optional.IsDefined(MonitoringEndpointUri))
            {
                writer.WritePropertyName("monitoringEndpointUri"u8);
                writer.WriteStringValue(MonitoringEndpointUri.AbsoluteUri);
            }
            if (Optional.IsDefined(MonitoringConfiguration))
            {
                writer.WritePropertyName("monitoringConfiguration"u8);
                writer.WriteStringValue(MonitoringConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            writer.WriteEndObject();
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

        StorageSyncRegisteredServerData IJsonModel<StorageSyncRegisteredServerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncRegisteredServerData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSyncRegisteredServerData(document.RootElement, options);
        }

        internal static StorageSyncRegisteredServerData DeserializeStorageSyncRegisteredServerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            BinaryData serverCertificate = default;
            string agentVersion = default;
            RegisteredServerAgentVersionStatus? agentVersionStatus = default;
            DateTimeOffset? agentVersionExpirationDate = default;
            string serverOSVersion = default;
            int? serverManagementErrorCode = default;
            string lastHeartbeat = default;
            string provisioningState = default;
            string serverRole = default;
            Guid? clusterId = default;
            string clusterName = default;
            Guid? serverId = default;
            Guid? storageSyncServiceUid = default;
            string lastWorkflowId = default;
            string lastOperationName = default;
            Uri discoveryEndpointUri = default;
            AzureLocation? resourceLocation = default;
            AzureLocation? serviceLocation = default;
            string friendlyName = default;
            Uri managementEndpointUri = default;
            Uri monitoringEndpointUri = default;
            string monitoringConfiguration = default;
            string serverName = default;
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
                        if (property0.NameEquals("serverCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverCertificate = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentVersionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentVersionStatus = new RegisteredServerAgentVersionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentVersionExpirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentVersionExpirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serverOSVersion"u8))
                        {
                            serverOSVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverManagementErrorCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverManagementErrorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"u8))
                        {
                            lastHeartbeat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverRole"u8))
                        {
                            serverRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("clusterName"u8))
                        {
                            clusterName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageSyncServiceUid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageSyncServiceUid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("lastWorkflowId"u8))
                        {
                            lastWorkflowId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastOperationName"u8))
                        {
                            lastOperationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("discoveryEndpointUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            discoveryEndpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managementEndpointUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementEndpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("monitoringEndpointUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monitoringEndpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("monitoringConfiguration"u8))
                        {
                            monitoringConfiguration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageSyncRegisteredServerData(
                id,
                name,
                type,
                systemData,
                serverCertificate,
                agentVersion,
                agentVersionStatus,
                agentVersionExpirationDate,
                serverOSVersion,
                serverManagementErrorCode,
                lastHeartbeat,
                provisioningState,
                serverRole,
                clusterId,
                clusterName,
                serverId,
                storageSyncServiceUid,
                lastWorkflowId,
                lastOperationName,
                discoveryEndpointUri,
                resourceLocation,
                serviceLocation,
                friendlyName,
                managementEndpointUri,
                monitoringEndpointUri,
                monitoringConfiguration,
                serverName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSyncRegisteredServerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageSyncRegisteredServerData)} does not support '{options.Format}' format.");
            }
        }

        StorageSyncRegisteredServerData IPersistableModel<StorageSyncRegisteredServerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageSyncRegisteredServerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageSyncRegisteredServerData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageSyncRegisteredServerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
