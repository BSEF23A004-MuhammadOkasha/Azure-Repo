// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class TelephonyChannelResourceApiConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(ProviderName))
            {
                if (ProviderName != null)
                {
                    writer.WritePropertyName("providerName"u8);
                    writer.WriteStringValue(ProviderName);
                }
                else
                {
                    writer.WriteNull("providerName");
                }
            }
            if (Core.Optional.IsDefined(CognitiveServiceSubscriptionKey))
            {
                if (CognitiveServiceSubscriptionKey != null)
                {
                    writer.WritePropertyName("cognitiveServiceSubscriptionKey"u8);
                    writer.WriteStringValue(CognitiveServiceSubscriptionKey);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceSubscriptionKey");
                }
            }
            if (Core.Optional.IsDefined(CognitiveServiceRegion))
            {
                if (CognitiveServiceRegion != null)
                {
                    writer.WritePropertyName("cognitiveServiceRegion"u8);
                    writer.WriteStringValue(CognitiveServiceRegion);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceRegion");
                }
            }
            if (Core.Optional.IsDefined(CognitiveServiceResourceId))
            {
                if (CognitiveServiceResourceId != null)
                {
                    writer.WritePropertyName("cognitiveServiceResourceId"u8);
                    writer.WriteStringValue(CognitiveServiceResourceId);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceResourceId");
                }
            }
            if (Core.Optional.IsDefined(DefaultLocale))
            {
                if (DefaultLocale != null)
                {
                    writer.WritePropertyName("defaultLocale"u8);
                    writer.WriteStringValue(DefaultLocale);
                }
                else
                {
                    writer.WriteNull("defaultLocale");
                }
            }
            writer.WriteEndObject();
        }

        internal static TelephonyChannelResourceApiConfiguration DeserializeTelephonyChannelResourceApiConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<string> providerName = default;
            Core.Optional<string> cognitiveServiceSubscriptionKey = default;
            Core.Optional<string> cognitiveServiceRegion = default;
            Core.Optional<ResourceIdentifier> cognitiveServiceResourceId = default;
            Core.Optional<string> defaultLocale = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        providerName = null;
                        continue;
                    }
                    providerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceSubscriptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceSubscriptionKey = null;
                        continue;
                    }
                    cognitiveServiceSubscriptionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceRegion = null;
                        continue;
                    }
                    cognitiveServiceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceResourceId = null;
                        continue;
                    }
                    cognitiveServiceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultLocale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLocale = null;
                        continue;
                    }
                    defaultLocale = property.Value.GetString();
                    continue;
                }
            }
            return new TelephonyChannelResourceApiConfiguration(id.Value, providerName.Value, cognitiveServiceSubscriptionKey.Value, cognitiveServiceRegion.Value, cognitiveServiceResourceId.Value, defaultLocale.Value);
        }
    }
}
