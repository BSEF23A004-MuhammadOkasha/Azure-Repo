// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class SchemaListResult
    {
        internal static SchemaListResult DeserializeSchemaListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ApiSchemaData>> value = default;
            Core.Optional<long> count = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiSchemaData> array = new List<ApiSchemaData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiSchemaData.DeserializeApiSchemaData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SchemaListResult(Core.Optional.ToList(value), Core.Optional.ToNullable(count), nextLink.Value);
        }
    }
}
