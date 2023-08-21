// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    internal partial class NodePlacementConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteStringValue(Policy.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static NodePlacementConfiguration DeserializeNodePlacementConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<BatchNodePlacementPolicyType> policy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = property.Value.GetString().ToBatchNodePlacementPolicyType();
                    continue;
                }
            }
            return new NodePlacementConfiguration(Core.Optional.ToNullable(policy));
        }
    }
}
