// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformGatewayRouteConfigProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AppResourceId))
            {
                writer.WritePropertyName("appResourceId"u8);
                writer.WriteStringValue(AppResourceId);
            }
            if (Core.Optional.IsDefined(OpenApi))
            {
                writer.WritePropertyName("openApi"u8);
                writer.WriteObjectValue(OpenApi);
            }
            if (Core.Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformGatewayRouteConfigProperties DeserializeAppPlatformGatewayRouteConfigProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<AppPlatformGatewayProvisioningState> provisioningState = default;
            Core.Optional<ResourceIdentifier> appResourceId = default;
            Core.Optional<GatewayRouteConfigOpenApiProperties> openApi = default;
            Core.Optional<AppPlatformGatewayRouteConfigProtocol> protocol = default;
            Core.Optional<IList<AppPlatformGatewayApiRoute>> routes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformGatewayProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("openApi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openApi = GatewayRouteConfigOpenApiProperties.DeserializeGatewayRouteConfigOpenApiProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new AppPlatformGatewayRouteConfigProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformGatewayApiRoute> array = new List<AppPlatformGatewayApiRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformGatewayApiRoute.DeserializeAppPlatformGatewayApiRoute(item));
                    }
                    routes = array;
                    continue;
                }
            }
            return new AppPlatformGatewayRouteConfigProperties(Core.Optional.ToNullable(provisioningState), appResourceId.Value, openApi.Value, Core.Optional.ToNullable(protocol), Core.Optional.ToList(routes));
        }
    }
}
