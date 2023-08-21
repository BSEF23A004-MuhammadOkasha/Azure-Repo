// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class OutboundEnvironmentEndpoint
    {
        internal static OutboundEnvironmentEndpoint DeserializeOutboundEnvironmentEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> category = default;
            Optional<IReadOnlyList<EndpointDependency>> endpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EndpointDependency> array = new List<EndpointDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EndpointDependency.DeserializeEndpointDependency(item));
                    }
                    endpoints = array;
                    continue;
                }
            }
            return new OutboundEnvironmentEndpoint(category.Value, Optional.ToList(endpoints));
        }
    }
}
