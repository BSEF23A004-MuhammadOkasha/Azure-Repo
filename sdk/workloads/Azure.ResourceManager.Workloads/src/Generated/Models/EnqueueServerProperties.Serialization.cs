// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class EnqueueServerProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static EnqueueServerProperties DeserializeEnqueueServerProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> hostname = default;
            Core.Optional<string> ipAddress = default;
            Core.Optional<long?> port = default;
            Core.Optional<SapHealthState> health = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        port = null;
                        continue;
                    }
                    port = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SapHealthState(property.Value.GetString());
                    continue;
                }
            }
            return new EnqueueServerProperties(hostname.Value, ipAddress.Value, Core.Optional.ToNullable(port), Core.Optional.ToNullable(health));
        }
    }
}
