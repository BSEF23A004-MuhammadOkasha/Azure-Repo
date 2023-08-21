// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class DirectLineSpeechChannelProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(CognitiveServiceResourceId))
            {
                writer.WritePropertyName("cognitiveServiceResourceId"u8);
                writer.WriteStringValue(CognitiveServiceResourceId);
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
            if (Core.Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Core.Optional.IsDefined(CustomVoiceDeploymentId))
            {
                writer.WritePropertyName("customVoiceDeploymentId"u8);
                writer.WriteStringValue(CustomVoiceDeploymentId);
            }
            if (Core.Optional.IsDefined(CustomSpeechModelId))
            {
                writer.WritePropertyName("customSpeechModelId"u8);
                writer.WriteStringValue(CustomSpeechModelId);
            }
            if (Core.Optional.IsDefined(IsDefaultBotForCogSvcAccount))
            {
                writer.WritePropertyName("isDefaultBotForCogSvcAccount"u8);
                writer.WriteBooleanValue(IsDefaultBotForCogSvcAccount.Value);
            }
            writer.WriteEndObject();
        }

        internal static DirectLineSpeechChannelProperties DeserializeDirectLineSpeechChannelProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> cognitiveServiceResourceId = default;
            Core.Optional<string> cognitiveServiceRegion = default;
            Core.Optional<string> cognitiveServiceSubscriptionKey = default;
            Core.Optional<bool> isEnabled = default;
            Core.Optional<string> customVoiceDeploymentId = default;
            Core.Optional<string> customSpeechModelId = default;
            Core.Optional<bool> isDefaultBotForCogSvcAccount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cognitiveServiceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cognitiveServiceResourceId = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customVoiceDeploymentId"u8))
                {
                    customVoiceDeploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customSpeechModelId"u8))
                {
                    customSpeechModelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefaultBotForCogSvcAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefaultBotForCogSvcAccount = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DirectLineSpeechChannelProperties(cognitiveServiceResourceId.Value, cognitiveServiceRegion.Value, cognitiveServiceSubscriptionKey.Value, Core.Optional.ToNullable(isEnabled), customVoiceDeploymentId.Value, customSpeechModelId.Value, Core.Optional.ToNullable(isDefaultBotForCogSvcAccount));
        }
    }
}
