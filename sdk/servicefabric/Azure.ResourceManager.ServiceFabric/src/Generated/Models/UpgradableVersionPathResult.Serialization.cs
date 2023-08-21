// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class UpgradableVersionPathResult
    {
        internal static UpgradableVersionPathResult DeserializeUpgradableVersionPathResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> supportedPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedPath = array;
                    continue;
                }
            }
            return new UpgradableVersionPathResult(Optional.ToList(supportedPath));
        }
    }
}
