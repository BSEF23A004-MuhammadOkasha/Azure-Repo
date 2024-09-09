// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kubernetes.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kubernetes
{
    public partial class ConnectedClusterData : IUtf8JsonSerializable, IJsonModel<ConnectedClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectedClusterData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectedClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedClusterData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("identity"u8);
            JsonSerializer.Serialize(writer, Identity);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            writer.WritePropertyName("agentPublicKeyCertificate"u8);
            writer.WriteStringValue(AgentPublicKeyCertificate);
            if (options.Format != "W" && Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalNodeCount))
            {
                writer.WritePropertyName("totalNodeCount"u8);
                writer.WriteNumberValue(TotalNodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalCoreCount))
            {
                writer.WritePropertyName("totalCoreCount"u8);
                writer.WriteNumberValue(TotalCoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Distribution))
            {
                writer.WritePropertyName("distribution"u8);
                writer.WriteStringValue(Distribution);
            }
            if (Optional.IsDefined(Infrastructure))
            {
                writer.WritePropertyName("infrastructure"u8);
                writer.WriteStringValue(Infrastructure);
            }
            if (options.Format != "W" && Optional.IsDefined(Offering))
            {
                writer.WritePropertyName("offering"u8);
                writer.WriteStringValue(Offering);
            }
            if (options.Format != "W" && Optional.IsDefined(ManagedIdentityCertificateExpirationOn))
            {
                writer.WritePropertyName("managedIdentityCertificateExpirationTime"u8);
                writer.WriteStringValue(ManagedIdentityCertificateExpirationOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastConnectivityOn))
            {
                writer.WritePropertyName("lastConnectivityTime"u8);
                writer.WriteStringValue(LastConnectivityOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectivityStatus))
            {
                writer.WritePropertyName("connectivityStatus"u8);
                writer.WriteStringValue(ConnectivityStatus.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkState))
            {
                writer.WritePropertyName("privateLinkState"u8);
                writer.WriteStringValue(PrivateLinkState.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkScopeResourceId))
            {
                writer.WritePropertyName("privateLinkScopeResourceId"u8);
                writer.WriteStringValue(PrivateLinkScopeResourceId);
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

        ConnectedClusterData IJsonModel<ConnectedClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedClusterData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectedClusterData(document.RootElement, options);
        }

        internal static ConnectedClusterData DeserializeConnectedClusterData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string agentPublicKeyCertificate = default;
            string kubernetesVersion = default;
            int? totalNodeCount = default;
            int? totalCoreCount = default;
            string agentVersion = default;
            ProvisioningState? provisioningState = default;
            string distribution = default;
            string infrastructure = default;
            string offering = default;
            DateTimeOffset? managedIdentityCertificateExpirationTime = default;
            DateTimeOffset? lastConnectivityTime = default;
            ConnectivityStatus? connectivityStatus = default;
            PrivateLinkState? privateLinkState = default;
            string privateLinkScopeResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("agentPublicKeyCertificate"u8))
                        {
                            agentPublicKeyCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("totalNodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalNodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalCoreCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalCoreCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("distribution"u8))
                        {
                            distribution = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("infrastructure"u8))
                        {
                            infrastructure = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offering"u8))
                        {
                            offering = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedIdentityCertificateExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedIdentityCertificateExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastConnectivityTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastConnectivityTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("connectivityStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivityStatus = new ConnectivityStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkState = new PrivateLinkState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkScopeResourceId"u8))
                        {
                            privateLinkScopeResourceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectedClusterData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                agentPublicKeyCertificate,
                kubernetesVersion,
                totalNodeCount,
                totalCoreCount,
                agentVersion,
                provisioningState,
                distribution,
                infrastructure,
                offering,
                managedIdentityCertificateExpirationTime,
                lastConnectivityTime,
                connectivityStatus,
                privateLinkState,
                privateLinkScopeResourceId,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Identity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  identity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Identity))
                {
                    builder.Append("  identity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Identity, options, 2, false, "  identity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgentPublicKeyCertificate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    agentPublicKeyCertificate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgentPublicKeyCertificate))
                {
                    builder.Append("    agentPublicKeyCertificate: ");
                    if (AgentPublicKeyCertificate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgentPublicKeyCertificate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgentPublicKeyCertificate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KubernetesVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    kubernetesVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KubernetesVersion))
                {
                    builder.Append("    kubernetesVersion: ");
                    if (KubernetesVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KubernetesVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KubernetesVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TotalNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    totalNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TotalNodeCount))
                {
                    builder.Append("    totalNodeCount: ");
                    builder.AppendLine($"{TotalNodeCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TotalCoreCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    totalCoreCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TotalCoreCount))
                {
                    builder.Append("    totalCoreCount: ");
                    builder.AppendLine($"{TotalCoreCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgentVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    agentVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgentVersion))
                {
                    builder.Append("    agentVersion: ");
                    if (AgentVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgentVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgentVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Distribution), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    distribution: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Distribution))
                {
                    builder.Append("    distribution: ");
                    if (Distribution.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Distribution}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Distribution}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Infrastructure), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    infrastructure: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Infrastructure))
                {
                    builder.Append("    infrastructure: ");
                    if (Infrastructure.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Infrastructure}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Infrastructure}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Offering), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    offering: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Offering))
                {
                    builder.Append("    offering: ");
                    if (Offering.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Offering}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Offering}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagedIdentityCertificateExpirationOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    managedIdentityCertificateExpirationTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ManagedIdentityCertificateExpirationOn))
                {
                    builder.Append("    managedIdentityCertificateExpirationTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ManagedIdentityCertificateExpirationOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastConnectivityOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastConnectivityTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastConnectivityOn))
                {
                    builder.Append("    lastConnectivityTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastConnectivityOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectivityStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    connectivityStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConnectivityStatus))
                {
                    builder.Append("    connectivityStatus: ");
                    builder.AppendLine($"'{ConnectivityStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateLinkState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    privateLinkState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateLinkState))
                {
                    builder.Append("    privateLinkState: ");
                    builder.AppendLine($"'{PrivateLinkState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateLinkScopeResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    privateLinkScopeResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateLinkScopeResourceId))
                {
                    builder.Append("    privateLinkScopeResourceId: ");
                    if (PrivateLinkScopeResourceId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrivateLinkScopeResourceId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrivateLinkScopeResourceId}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ConnectedClusterData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConnectedClusterData)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectedClusterData IPersistableModel<ConnectedClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectedClusterData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectedClusterData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectedClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
