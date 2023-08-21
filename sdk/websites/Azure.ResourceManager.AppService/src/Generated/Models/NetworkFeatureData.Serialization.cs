// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class NetworkFeatureData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkFeatureData DeserializeNetworkFeatureData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> virtualNetworkName = default;
            Optional<AppServiceVirtualNetworkProperties> virtualNetworkConnection = default;
            Optional<IReadOnlyList<RelayServiceConnectionEntityData>> hybridConnections = default;
            Optional<IReadOnlyList<HybridConnectionData>> hybridConnectionsV2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("virtualNetworkName"u8))
                        {
                            virtualNetworkName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConnection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkConnection = AppServiceVirtualNetworkProperties.DeserializeAppServiceVirtualNetworkProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hybridConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RelayServiceConnectionEntityData> array = new List<RelayServiceConnectionEntityData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RelayServiceConnectionEntityData.DeserializeRelayServiceConnectionEntityData(item));
                            }
                            hybridConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("hybridConnectionsV2"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HybridConnectionData> array = new List<HybridConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HybridConnectionData.DeserializeHybridConnectionData(item));
                            }
                            hybridConnectionsV2 = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkFeatureData(id, name, type, systemData.Value, virtualNetworkName.Value, virtualNetworkConnection.Value, Optional.ToList(hybridConnections), Optional.ToList(hybridConnectionsV2), kind.Value);
        }
    }
}
