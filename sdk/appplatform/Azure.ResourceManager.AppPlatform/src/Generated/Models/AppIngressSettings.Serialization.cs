// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppIngressSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ReadTimeoutInSeconds))
            {
                writer.WritePropertyName("readTimeoutInSeconds"u8);
                writer.WriteNumberValue(ReadTimeoutInSeconds.Value);
            }
            if (Core.Optional.IsDefined(SendTimeoutInSeconds))
            {
                writer.WritePropertyName("sendTimeoutInSeconds"u8);
                writer.WriteNumberValue(SendTimeoutInSeconds.Value);
            }
            if (Core.Optional.IsDefined(SessionAffinity))
            {
                writer.WritePropertyName("sessionAffinity"u8);
                writer.WriteStringValue(SessionAffinity.Value.ToString());
            }
            if (Core.Optional.IsDefined(SessionCookieMaxAge))
            {
                writer.WritePropertyName("sessionCookieMaxAge"u8);
                writer.WriteNumberValue(SessionCookieMaxAge.Value);
            }
            if (Core.Optional.IsDefined(BackendProtocol))
            {
                writer.WritePropertyName("backendProtocol"u8);
                writer.WriteStringValue(BackendProtocol.Value.ToString());
            }
            if (Core.Optional.IsDefined(ClientAuth))
            {
                writer.WritePropertyName("clientAuth"u8);
                writer.WriteObjectValue(ClientAuth);
            }
            writer.WriteEndObject();
        }

        internal static AppIngressSettings DeserializeAppIngressSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> readTimeoutInSeconds = default;
            Core.Optional<int> sendTimeoutInSeconds = default;
            Core.Optional<AppSessionAffinity> sessionAffinity = default;
            Core.Optional<int> sessionCookieMaxAge = default;
            Core.Optional<AppBackendProtocol> backendProtocol = default;
            Core.Optional<IngressSettingsClientAuth> clientAuth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("readTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sendTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sessionAffinity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionAffinity = new AppSessionAffinity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sessionCookieMaxAge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionCookieMaxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendProtocol = new AppBackendProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientAuth = IngressSettingsClientAuth.DeserializeIngressSettingsClientAuth(property.Value);
                    continue;
                }
            }
            return new AppIngressSettings(Core.Optional.ToNullable(readTimeoutInSeconds), Core.Optional.ToNullable(sendTimeoutInSeconds), Core.Optional.ToNullable(sessionAffinity), Core.Optional.ToNullable(sessionCookieMaxAge), Core.Optional.ToNullable(backendProtocol), clientAuth.Value);
        }
    }
}
