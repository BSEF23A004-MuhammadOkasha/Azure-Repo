// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Models
{
    internal partial class PrivateEndpointConnectionList
    {
        internal static PrivateEndpointConnectionList DeserializePrivateEndpointConnectionList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> count = default;
            Optional<string> nextLink = default;
            IReadOnlyList<PurviewPrivateEndpointConnectionData> value = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("value"u8))
                {
                    List<PurviewPrivateEndpointConnectionData> array = new List<PurviewPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PurviewPrivateEndpointConnectionData.DeserializePurviewPrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateEndpointConnectionList(Optional.ToNullable(count), nextLink.Value, value);
        }
    }
}
