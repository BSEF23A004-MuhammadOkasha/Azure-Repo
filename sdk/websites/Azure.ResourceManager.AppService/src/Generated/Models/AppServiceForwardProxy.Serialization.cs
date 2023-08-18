// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceForwardProxy : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Convention))
            {
                writer.WritePropertyName("convention"u8);
                writer.WriteStringValue(Convention.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(CustomHostHeaderName))
            {
                writer.WritePropertyName("customHostHeaderName"u8);
                writer.WriteStringValue(CustomHostHeaderName);
            }
            if (Core.Optional.IsDefined(CustomProtoHeaderName))
            {
                writer.WritePropertyName("customProtoHeaderName"u8);
                writer.WriteStringValue(CustomProtoHeaderName);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceForwardProxy DeserializeAppServiceForwardProxy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ForwardProxyConvention> convention = default;
            Core.Optional<string> customHostHeaderName = default;
            Core.Optional<string> customProtoHeaderName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("convention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    convention = property.Value.GetString().ToForwardProxyConvention();
                    continue;
                }
                if (property.NameEquals("customHostHeaderName"u8))
                {
                    customHostHeaderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customProtoHeaderName"u8))
                {
                    customProtoHeaderName = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceForwardProxy(Core.Optional.ToNullable(convention), customHostHeaderName.Value, customProtoHeaderName.Value);
        }
    }
}
