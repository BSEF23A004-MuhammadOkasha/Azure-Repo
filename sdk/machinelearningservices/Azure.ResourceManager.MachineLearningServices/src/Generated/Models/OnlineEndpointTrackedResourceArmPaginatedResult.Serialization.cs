// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class OnlineEndpointTrackedResourceArmPaginatedResult
    {
        internal static OnlineEndpointTrackedResourceArmPaginatedResult DeserializeOnlineEndpointTrackedResourceArmPaginatedResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<OnlineEndpointTrackedResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OnlineEndpointTrackedResourceData> array = new List<OnlineEndpointTrackedResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OnlineEndpointTrackedResourceData.DeserializeOnlineEndpointTrackedResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new OnlineEndpointTrackedResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
