// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Nginx;

namespace Azure.ResourceManager.Nginx.Models
{
    internal partial class NginxDeploymentListResponse
    {
        internal static NginxDeploymentListResponse DeserializeNginxDeploymentListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<NginxDeploymentData>> value = default;
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
                    List<NginxDeploymentData> array = new List<NginxDeploymentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxDeploymentData.DeserializeNginxDeploymentData(item));
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
            return new NginxDeploymentListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
