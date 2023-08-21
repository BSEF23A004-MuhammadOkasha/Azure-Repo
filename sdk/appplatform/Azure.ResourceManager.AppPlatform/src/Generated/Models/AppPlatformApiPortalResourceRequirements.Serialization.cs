// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformApiPortalResourceRequirements
    {
        internal static AppPlatformApiPortalResourceRequirements DeserializeAppPlatformApiPortalResourceRequirements(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> cpu = default;
            Core.Optional<string> memory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    memory = property.Value.GetString();
                    continue;
                }
            }
            return new AppPlatformApiPortalResourceRequirements(cpu.Value, memory.Value);
        }
    }
}
