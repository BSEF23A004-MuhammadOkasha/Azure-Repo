// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    internal partial class CloudErrorAutoGenerated2
    {
        internal static CloudErrorAutoGenerated2 DeserializeCloudErrorAutoGenerated2(JsonElement element)
        {
            Optional<CloudErrorBodyAutoGenerated2> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = CloudErrorBodyAutoGenerated2.DeserializeCloudErrorBodyAutoGenerated2(property.Value);
                    continue;
                }
            }
            return new CloudErrorAutoGenerated2(error.Value);
        }
    }
}
