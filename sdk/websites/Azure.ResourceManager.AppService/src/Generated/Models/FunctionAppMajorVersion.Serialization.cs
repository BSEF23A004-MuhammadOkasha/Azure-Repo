// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppMajorVersion
    {
        internal static FunctionAppMajorVersion DeserializeFunctionAppMajorVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> displayText = default;
            Core.Optional<string> value = default;
            Core.Optional<IReadOnlyList<FunctionAppMinorVersion>> minorVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minorVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FunctionAppMinorVersion> array = new List<FunctionAppMinorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FunctionAppMinorVersion.DeserializeFunctionAppMinorVersion(item));
                    }
                    minorVersions = array;
                    continue;
                }
            }
            return new FunctionAppMajorVersion(displayText.Value, value.Value, Core.Optional.ToList(minorVersions));
        }
    }
}
