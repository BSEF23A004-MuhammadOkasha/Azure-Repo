// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class ModuleIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ModuleId))
            {
                writer.WritePropertyName("moduleId");
                writer.WriteStringValue(ModuleId);
            }
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy");
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId");
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(GenerationId))
            {
                writer.WritePropertyName("generationId");
                writer.WriteStringValue(GenerationId);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState");
                writer.WriteStringValue(ConnectionState.Value.ToString());
            }
            if (Optional.IsDefined(ConnectionStateUpdatedTime))
            {
                writer.WritePropertyName("connectionStateUpdatedTime");
                writer.WriteStringValue(ConnectionStateUpdatedTime.Value, "O");
            }
            if (Optional.IsDefined(LastActivityTime))
            {
                writer.WritePropertyName("lastActivityTime");
                writer.WriteStringValue(LastActivityTime.Value, "O");
            }
            if (Optional.IsDefined(CloudToDeviceMessageCount))
            {
                writer.WritePropertyName("cloudToDeviceMessageCount");
                writer.WriteNumberValue(CloudToDeviceMessageCount.Value);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication");
                writer.WriteObjectValue(Authentication);
            }
            writer.WriteEndObject();
        }

        internal static ModuleIdentity DeserializeModuleIdentity(JsonElement element)
        {
            Optional<string> moduleId = default;
            Optional<string> managedBy = default;
            Optional<string> deviceId = default;
            Optional<string> generationId = default;
            Optional<string> etag = default;
            Optional<ModuleConnectionState> connectionState = default;
            Optional<DateTimeOffset> connectionStateUpdatedTime = default;
            Optional<DateTimeOffset> lastActivityTime = default;
            Optional<int> cloudToDeviceMessageCount = default;
            Optional<AuthenticationMechanism> authentication = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("moduleId"))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generationId"))
                {
                    generationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectionState = new ModuleConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectionStateUpdatedTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectionStateUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActivityTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastActivityTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cloudToDeviceMessageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authentication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authentication = AuthenticationMechanism.DeserializeAuthenticationMechanism(property.Value);
                    continue;
                }
            }
            return new ModuleIdentity(moduleId.Value, managedBy.Value, deviceId.Value, generationId.Value, etag.Value, Optional.ToNullable(connectionState), Optional.ToNullable(connectionStateUpdatedTime), Optional.ToNullable(lastActivityTime), Optional.ToNullable(cloudToDeviceMessageCount), authentication.Value);
        }
    }
}
