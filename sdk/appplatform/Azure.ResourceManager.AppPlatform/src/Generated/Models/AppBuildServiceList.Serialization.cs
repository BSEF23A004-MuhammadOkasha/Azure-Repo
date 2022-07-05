// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class AppBuildServiceList
    {
        internal static AppBuildServiceList DeserializeAppBuildServiceList(JsonElement element)
        {
            Optional<IReadOnlyList<AppBuildServiceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AppBuildServiceData> array = new List<AppBuildServiceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppBuildServiceData.DeserializeAppBuildServiceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AppBuildServiceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
