// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementServiceGetSsoTokenResult
    {
        internal static ApiManagementServiceGetSsoTokenResult DeserializeApiManagementServiceGetSsoTokenResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> redirectUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redirectUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ApiManagementServiceGetSsoTokenResult(redirectUri.Value);
        }
    }
}
