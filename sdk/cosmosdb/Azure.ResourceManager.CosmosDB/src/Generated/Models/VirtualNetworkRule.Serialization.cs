// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class VirtualNetworkRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(IgnoreMissingVNetServiceEndpoint))
            {
                writer.WritePropertyName("ignoreMissingVNetServiceEndpoint");
                writer.WriteBooleanValue(IgnoreMissingVNetServiceEndpoint.Value);
            }
            writer.WriteEndObject();
        }

        internal static VirtualNetworkRule DeserializeVirtualNetworkRule(JsonElement element)
        {
            Optional<string> id = default;
            Optional<bool> ignoreMissingVNetServiceEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ignoreMissingVNetServiceEndpoint"))
                {
                    ignoreMissingVNetServiceEndpoint = property.Value.GetBoolean();
                    continue;
                }
            }
            return new VirtualNetworkRule(id.Value, Optional.ToNullable(ignoreMissingVNetServiceEndpoint));
        }
    }
}
