// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionMonitorOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(WorkspaceSettings))
            {
                writer.WritePropertyName("workspaceSettings");
                writer.WriteObjectValue(WorkspaceSettings);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorOutput DeserializeConnectionMonitorOutput(JsonElement element)
        {
            Optional<OutputType> type = default;
            Optional<ConnectionMonitorWorkspaceSettings> workspaceSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new OutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workspaceSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workspaceSettings = ConnectionMonitorWorkspaceSettings.DeserializeConnectionMonitorWorkspaceSettings(property.Value);
                    continue;
                }
            }
            return new ConnectionMonitorOutput(Optional.ToNullable(type), workspaceSettings.Value);
        }
    }
}
