// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PushSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IsPushEnabled))
            {
                writer.WritePropertyName("isPushEnabled");
                writer.WriteBooleanValue(IsPushEnabled.Value);
            }
            if (Optional.IsDefined(TagWhitelistJson))
            {
                writer.WritePropertyName("tagWhitelistJson");
                writer.WriteStringValue(TagWhitelistJson);
            }
            if (Optional.IsDefined(TagsRequiringAuth))
            {
                writer.WritePropertyName("tagsRequiringAuth");
                writer.WriteStringValue(TagsRequiringAuth);
            }
            if (Optional.IsDefined(DynamicTagsJson))
            {
                writer.WritePropertyName("dynamicTagsJson");
                writer.WriteStringValue(DynamicTagsJson);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PushSettings DeserializePushSettings(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<bool> isPushEnabled = default;
            Optional<string> tagWhitelistJson = default;
            Optional<string> tagsRequiringAuth = default;
            Optional<string> dynamicTagsJson = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isPushEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isPushEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("tagWhitelistJson"))
                        {
                            tagWhitelistJson = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tagsRequiringAuth"))
                        {
                            tagsRequiringAuth = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dynamicTagsJson"))
                        {
                            dynamicTagsJson = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PushSettings(id, name, type, kind.Value, Optional.ToNullable(isPushEnabled), tagWhitelistJson.Value, tagsRequiringAuth.Value, dynamicTagsJson.Value);
        }
    }
}
