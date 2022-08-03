// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MoveResourceDependencyOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(TargetId))
            {
                writer.WritePropertyName("targetId");
                writer.WriteStringValue(TargetId);
            }
            writer.WriteEndObject();
        }

        internal static MoveResourceDependencyOverride DeserializeMoveResourceDependencyOverride(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            Optional<ResourceIdentifier> targetId = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("targetId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new MoveResourceDependencyOverride(id.Value, targetId.Value);
        }
    }
}
