// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class RecommendationRuleData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(RecommendationName))
            {
                writer.WritePropertyName("recommendationName");
                writer.WriteStringValue(RecommendationName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(RecommendationId))
            {
                writer.WritePropertyName("recommendationId");
                writer.WriteStringValue(RecommendationId.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ActionName))
            {
                writer.WritePropertyName("actionName");
                writer.WriteStringValue(ActionName);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level");
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            if (Optional.IsDefined(Channels))
            {
                writer.WritePropertyName("channels");
                writer.WriteStringValue(Channels.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsDynamic))
            {
                writer.WritePropertyName("isDynamic");
                writer.WriteBooleanValue(IsDynamic.Value);
            }
            if (Optional.IsDefined(ExtensionName))
            {
                writer.WritePropertyName("extensionName");
                writer.WriteStringValue(ExtensionName);
            }
            if (Optional.IsDefined(BladeName))
            {
                writer.WritePropertyName("bladeName");
                writer.WriteStringValue(BladeName);
            }
            if (Optional.IsDefined(ForwardLink))
            {
                writer.WritePropertyName("forwardLink");
                writer.WriteStringValue(ForwardLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RecommendationRuleData DeserializeRecommendationRuleData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> recommendationName = default;
            Optional<string> displayName = default;
            Optional<string> message = default;
            Optional<Guid> recommendationId = default;
            Optional<string> description = default;
            Optional<string> actionName = default;
            Optional<NotificationLevel> level = default;
            Optional<Channels> channels = default;
            Optional<IReadOnlyList<string>> categoryTags = default;
            Optional<bool> isDynamic = default;
            Optional<string> extensionName = default;
            Optional<string> bladeName = default;
            Optional<string> forwardLink = default;
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
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("recommendationName"))
                        {
                            recommendationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendationId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            recommendationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("actionName"))
                        {
                            actionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("level"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            level = property0.Value.GetString().ToNotificationLevel();
                            continue;
                        }
                        if (property0.NameEquals("channels"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            channels = property0.Value.GetString().ToChannels();
                            continue;
                        }
                        if (property0.NameEquals("categoryTags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            categoryTags = array;
                            continue;
                        }
                        if (property0.NameEquals("isDynamic"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDynamic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("extensionName"))
                        {
                            extensionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bladeName"))
                        {
                            bladeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("forwardLink"))
                        {
                            forwardLink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RecommendationRuleData(id, name, type, systemData, kind.Value, recommendationName.Value, displayName.Value, message.Value, Optional.ToNullable(recommendationId), description.Value, actionName.Value, Optional.ToNullable(level), Optional.ToNullable(channels), Optional.ToList(categoryTags), Optional.ToNullable(isDynamic), extensionName.Value, bladeName.Value, forwardLink.Value);
        }
    }
}
