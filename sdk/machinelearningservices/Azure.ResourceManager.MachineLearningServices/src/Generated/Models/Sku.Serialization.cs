// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class Sku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity");
                writer.WriteNumberValue(Capacity.Value);
            }
            if (Optional.IsDefined(Family))
            {
                writer.WritePropertyName("family");
                writer.WriteStringValue(Family);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size");
                writer.WriteStringValue(Size);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static Sku DeserializeSku(JsonElement element)
        {
            Optional<int> capacity = default;
            Optional<string> family = default;
            string name = default;
            Optional<string> size = default;
            Optional<SkuTier> tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("family"))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tier = property.Value.GetString().ToSkuTier();
                    continue;
                }
            }
            return new Sku(Optional.ToNullable(capacity), family.Value, name, size.Value, Optional.ToNullable(tier));
        }
    }
}
