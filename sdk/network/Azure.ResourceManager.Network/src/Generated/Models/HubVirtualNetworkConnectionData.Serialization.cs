// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class HubVirtualNetworkConnectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RemoteVirtualNetwork))
            {
                writer.WritePropertyName("remoteVirtualNetwork");
                JsonSerializer.Serialize(writer, RemoteVirtualNetwork);
            }
            if (Optional.IsDefined(AllowHubToRemoteVnetTransit))
            {
                writer.WritePropertyName("allowHubToRemoteVnetTransit");
                writer.WriteBooleanValue(AllowHubToRemoteVnetTransit.Value);
            }
            if (Optional.IsDefined(AllowRemoteVnetToUseHubVnetGateways))
            {
                writer.WritePropertyName("allowRemoteVnetToUseHubVnetGateways");
                writer.WriteBooleanValue(AllowRemoteVnetToUseHubVnetGateways.Value);
            }
            if (Optional.IsDefined(EnableInternetSecurity))
            {
                writer.WritePropertyName("enableInternetSecurity");
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (Optional.IsDefined(RoutingConfiguration))
            {
                writer.WritePropertyName("routingConfiguration");
                writer.WriteObjectValue(RoutingConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HubVirtualNetworkConnectionData DeserializeHubVirtualNetworkConnectionData(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<WritableSubResource> remoteVirtualNetwork = default;
            Optional<bool> allowHubToRemoteVnetTransit = default;
            Optional<bool> allowRemoteVnetToUseHubVnetGateways = default;
            Optional<bool> enableInternetSecurity = default;
            Optional<RoutingConfiguration> routingConfiguration = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("remoteVirtualNetwork"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remoteVirtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("allowHubToRemoteVnetTransit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowHubToRemoteVnetTransit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowRemoteVnetToUseHubVnetGateways"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowRemoteVnetToUseHubVnetGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routingConfiguration = RoutingConfiguration.DeserializeRoutingConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HubVirtualNetworkConnectionData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), remoteVirtualNetwork, Optional.ToNullable(allowHubToRemoteVnetTransit), Optional.ToNullable(allowRemoteVnetToUseHubVnetGateways), Optional.ToNullable(enableInternetSecurity), routingConfiguration.Value, Optional.ToNullable(provisioningState));
        }
    }
}
