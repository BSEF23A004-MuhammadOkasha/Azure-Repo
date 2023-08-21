// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildResultLog
    {
        internal static AppPlatformBuildResultLog DeserializeAppPlatformBuildResultLog(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> blobUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new AppPlatformBuildResultLog(blobUri.Value);
        }
    }
}
