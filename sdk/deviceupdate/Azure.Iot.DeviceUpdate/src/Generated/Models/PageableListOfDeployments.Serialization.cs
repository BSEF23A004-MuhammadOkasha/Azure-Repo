// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate.Models
{
    public partial class PageableListOfDeployments
    {
        internal static PageableListOfDeployments DeserializePageableListOfDeployments(JsonElement element)
        {
            Optional<IReadOnlyList<Deployment>> value = default;
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
                    List<Deployment> array = new List<Deployment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Deployment.DeserializeDeployment(item));
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
            return new PageableListOfDeployments(Optional.ToList(value), nextLink.Value);
        }
    }
}
