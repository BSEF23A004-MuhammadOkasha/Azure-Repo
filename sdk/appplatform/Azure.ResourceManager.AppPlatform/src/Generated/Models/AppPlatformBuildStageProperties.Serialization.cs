// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildStageProperties
    {
        internal static AppPlatformBuildStageProperties DeserializeAppPlatformBuildStageProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<KPackBuildStageProvisioningState> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new KPackBuildStageProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new AppPlatformBuildStageProperties(name.Value, Core.Optional.ToNullable(status));
        }
    }
}
