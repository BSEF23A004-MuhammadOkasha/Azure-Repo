// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDataCenterAccessCode
    {
        internal static DataBoxEdgeDataCenterAccessCode DeserializeDataBoxEdgeDataCenterAccessCode(JsonElement element)
        {
            Optional<string> authCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authCode"))
                        {
                            authCode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataBoxEdgeDataCenterAccessCode(authCode.Value);
        }
    }
}
