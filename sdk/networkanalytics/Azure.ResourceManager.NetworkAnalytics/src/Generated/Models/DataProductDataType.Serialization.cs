// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    public partial class DataProductDataType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(StorageOutputRetention))
            {
                writer.WritePropertyName("storageOutputRetention"u8);
                writer.WriteNumberValue(StorageOutputRetention.Value);
            }
            if (Optional.IsDefined(DatabaseCacheRetention))
            {
                writer.WritePropertyName("databaseCacheRetention"u8);
                writer.WriteNumberValue(DatabaseCacheRetention.Value);
            }
            if (Optional.IsDefined(DatabaseRetention))
            {
                writer.WritePropertyName("databaseRetention"u8);
                writer.WriteNumberValue(DatabaseRetention.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataProductDataType DeserializeDataProductDataType(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NetworkAnalyticsProvisioningState> provisioningState = default;
            Optional<DataProductDataTypeState> state = default;
            Optional<string> stateReason = default;
            Optional<int> storageOutputRetention = default;
            Optional<int> databaseCacheRetention = default;
            Optional<int> databaseRetention = default;
            Optional<Uri> visualizationUrl = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkAnalyticsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new DataProductDataTypeState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stateReason"u8))
                        {
                            stateReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageOutputRetention"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageOutputRetention = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("databaseCacheRetention"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseCacheRetention = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("databaseRetention"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseRetention = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("visualizationUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            visualizationUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataProductDataType(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(state), stateReason.Value, Optional.ToNullable(storageOutputRetention), Optional.ToNullable(databaseCacheRetention), Optional.ToNullable(databaseRetention), visualizationUrl.Value);
        }
    }
}
