// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SharedGalleryOSDiskImage
    {
        internal static SharedGalleryOSDiskImage DeserializeSharedGalleryOSDiskImage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> diskSizeGB = default;
            Optional<SharedGalleryHostCaching> hostCaching = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostCaching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostCaching = new SharedGalleryHostCaching(property.Value.GetString());
                    continue;
                }
            }
            return new SharedGalleryOSDiskImage(Optional.ToNullable(diskSizeGB), Optional.ToNullable(hostCaching));
        }
    }
}
