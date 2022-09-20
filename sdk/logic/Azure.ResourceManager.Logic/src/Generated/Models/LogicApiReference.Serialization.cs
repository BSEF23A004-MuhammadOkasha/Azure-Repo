// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("iconUri");
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Swagger))
            {
                writer.WritePropertyName("swagger");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Swagger);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Swagger.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(BrandColor))
            {
                writer.WritePropertyName("brandColor");
                writer.WriteStringValue(BrandColor);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category");
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(IntegrationServiceEnvironment))
            {
                writer.WritePropertyName("integrationServiceEnvironment");
                writer.WriteObjectValue(IntegrationServiceEnvironment);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static LogicApiReference DeserializeLogicApiReference(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<Uri> iconUri = default;
            Optional<BinaryData> swagger = default;
            Optional<string> brandColor = default;
            Optional<LogicApiTier> category = default;
            Optional<LogicResourceReference> integrationServiceEnvironment = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        iconUri = null;
                        continue;
                    }
                    iconUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swagger"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    swagger = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("brandColor"))
                {
                    brandColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    category = new LogicApiTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("integrationServiceEnvironment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    integrationServiceEnvironment = DeserializeLogicResourceReference(property.Value);
                    continue;
                }
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
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new LogicApiReference(id.Value, name.Value, Optional.ToNullable(type), displayName.Value, description.Value, iconUri.Value, swagger.Value, brandColor.Value, Optional.ToNullable(category), integrationServiceEnvironment.Value);
        }
    }
}
