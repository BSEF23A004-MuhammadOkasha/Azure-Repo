// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class WorkloadNetworkPublicIPData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(NumberOfPublicIPs))
            {
                writer.WritePropertyName("numberOfPublicIPs"u8);
                writer.WriteNumberValue(NumberOfPublicIPs.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkloadNetworkPublicIPData DeserializeWorkloadNetworkPublicIPData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> displayName = default;
            Core.Optional<long> numberOfPublicIPs = default;
            Core.Optional<string> publicIPBlock = default;
            Core.Optional<WorkloadNetworkPublicIPProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("numberOfPublicIPs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfPublicIPs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("publicIPBlock"u8))
                        {
                            publicIPBlock = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new WorkloadNetworkPublicIPProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkloadNetworkPublicIPData(id, name, type, systemData.Value, displayName.Value, Core.Optional.ToNullable(numberOfPublicIPs), publicIPBlock.Value, Core.Optional.ToNullable(provisioningState));
        }
    }
}
