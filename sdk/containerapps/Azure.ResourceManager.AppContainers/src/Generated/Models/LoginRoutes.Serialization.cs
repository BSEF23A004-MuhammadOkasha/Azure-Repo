// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class LoginRoutes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LogoutEndpoint))
            {
                writer.WritePropertyName("logoutEndpoint"u8);
                writer.WriteStringValue(LogoutEndpoint);
            }
            writer.WriteEndObject();
        }

        internal static LoginRoutes DeserializeLoginRoutes(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> logoutEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logoutEndpoint"u8))
                {
                    logoutEndpoint = property.Value.GetString();
                    continue;
                }
            }
            return new LoginRoutes(logoutEndpoint.Value);
        }
    }
}
