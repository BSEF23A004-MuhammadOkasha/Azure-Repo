// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class MsixPackageApplications : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId");
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AppUserModelId))
            {
                writer.WritePropertyName("appUserModelID");
                writer.WriteStringValue(AppUserModelId);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(IconImageName))
            {
                writer.WritePropertyName("iconImageName");
                writer.WriteStringValue(IconImageName);
            }
            if (Optional.IsDefined(RawIcon))
            {
                writer.WritePropertyName("rawIcon");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RawIcon);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(RawIcon.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(RawPng))
            {
                writer.WritePropertyName("rawPng");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RawPng);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(RawPng.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static MsixPackageApplications DeserializeMsixPackageApplications(JsonElement element)
        {
            Optional<string> appId = default;
            Optional<string> description = default;
            Optional<string> appUserModelId = default;
            Optional<string> friendlyName = default;
            Optional<string> iconImageName = default;
            Optional<BinaryData> rawIcon = default;
            Optional<BinaryData> rawPng = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appUserModelID"))
                {
                    appUserModelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconImageName"))
                {
                    iconImageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rawIcon"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rawIcon = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("rawPng"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rawPng = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new MsixPackageApplications(appId.Value, description.Value, appUserModelId.Value, friendlyName.Value, iconImageName.Value, rawIcon.Value, rawPng.Value);
        }
    }
}
