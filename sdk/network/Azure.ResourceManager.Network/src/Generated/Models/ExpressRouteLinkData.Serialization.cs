// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteLinkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AdminState))
            {
                writer.WritePropertyName("adminState");
                writer.WriteStringValue(AdminState.Value.ToString());
            }
            if (Optional.IsDefined(MacSecConfig))
            {
                writer.WritePropertyName("macSecConfig");
                writer.WriteObjectValue(MacSecConfig);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteLinkData DeserializeExpressRouteLinkData(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> routerName = default;
            Optional<string> interfaceName = default;
            Optional<string> patchPanelId = default;
            Optional<string> rackId = default;
            Optional<ExpressRouteLinkConnectorType> connectorType = default;
            Optional<ExpressRouteLinkAdminState> adminState = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ExpressRouteLinkMacSecConfig> macSecConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("routerName"))
                        {
                            routerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interfaceName"))
                        {
                            interfaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("patchPanelId"))
                        {
                            patchPanelId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rackId"))
                        {
                            rackId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectorType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectorType = new ExpressRouteLinkConnectorType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("adminState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            adminState = new ExpressRouteLinkAdminState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("macSecConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            macSecConfig = ExpressRouteLinkMacSecConfig.DeserializeExpressRouteLinkMacSecConfig(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteLinkData(id.Value, name.Value, etag.Value, routerName.Value, interfaceName.Value, patchPanelId.Value, rackId.Value, Optional.ToNullable(connectorType), Optional.ToNullable(adminState), Optional.ToNullable(provisioningState), macSecConfig.Value);
        }
    }
}
