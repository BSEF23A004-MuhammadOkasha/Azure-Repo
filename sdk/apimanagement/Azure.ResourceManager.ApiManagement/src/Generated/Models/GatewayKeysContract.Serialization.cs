// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GatewayKeysContract
    {
        internal static GatewayKeysContract DeserializeGatewayKeysContract(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> primary = default;
            Core.Optional<string> secondary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primary"u8))
                {
                    primary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondary"u8))
                {
                    secondary = property.Value.GetString();
                    continue;
                }
            }
            return new GatewayKeysContract(primary.Value, secondary.Value);
        }
    }
}
