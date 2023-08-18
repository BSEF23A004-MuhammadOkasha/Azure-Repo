// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceHttpSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(IsHttpsRequired))
            {
                writer.WritePropertyName("requireHttps"u8);
                writer.WriteBooleanValue(IsHttpsRequired.Value);
            }
            if (Core.Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Core.Optional.IsDefined(ForwardProxy))
            {
                writer.WritePropertyName("forwardProxy"u8);
                writer.WriteObjectValue(ForwardProxy);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceHttpSettings DeserializeAppServiceHttpSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> requireHttps = default;
            Core.Optional<AppServiceHttpSettingsRoutes> routes = default;
            Core.Optional<AppServiceForwardProxy> forwardProxy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireHttps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireHttps = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = AppServiceHttpSettingsRoutes.DeserializeAppServiceHttpSettingsRoutes(property.Value);
                    continue;
                }
                if (property.NameEquals("forwardProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forwardProxy = AppServiceForwardProxy.DeserializeAppServiceForwardProxy(property.Value);
                    continue;
                }
            }
            return new AppServiceHttpSettings(Core.Optional.ToNullable(requireHttps), routes.Value, forwardProxy.Value);
        }
    }
}
