// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceDataDisk
    {
        internal static MachineLearningComputeInstanceDataDisk DeserializeMachineLearningComputeInstanceDataDisk(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningCachingType> caching = default;
            Optional<int> diskSizeGB = default;
            Optional<int> lun = default;
            Optional<MachineLearningStorageAccountType> storageAccountType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("caching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caching = new MachineLearningCachingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new MachineLearningStorageAccountType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningComputeInstanceDataDisk(Optional.ToNullable(caching), Optional.ToNullable(diskSizeGB), Optional.ToNullable(lun), Optional.ToNullable(storageAccountType));
        }
    }
}
