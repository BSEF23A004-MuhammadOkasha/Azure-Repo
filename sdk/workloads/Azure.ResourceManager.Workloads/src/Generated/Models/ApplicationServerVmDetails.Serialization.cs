// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ApplicationServerVmDetails
    {
        internal static ApplicationServerVmDetails DeserializeApplicationServerVmDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ApplicationServerVirtualMachineType> type = default;
            Core.Optional<ResourceIdentifier> virtualMachineId = default;
            Core.Optional<IReadOnlyList<SubResource>> storageDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ApplicationServerVirtualMachineType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    storageDetails = array;
                    continue;
                }
            }
            return new ApplicationServerVmDetails(Core.Optional.ToNullable(type), virtualMachineId.Value, Core.Optional.ToList(storageDetails));
        }
    }
}
