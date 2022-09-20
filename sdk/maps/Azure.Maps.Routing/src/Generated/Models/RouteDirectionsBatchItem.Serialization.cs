// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    internal partial class RouteDirectionsBatchItem
    {
        internal static RouteDirectionsBatchItem DeserializeRouteDirectionsBatchItem(JsonElement element)
        {
            Optional<RouteDirectionsBatchItemResponse> response = default;
            Optional<int> statusCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("response"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    response = RouteDirectionsBatchItemResponse.DeserializeRouteDirectionsBatchItemResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
            }
            return new RouteDirectionsBatchItem(Optional.ToNullable(statusCode), response.Value);
        }
    }
}
