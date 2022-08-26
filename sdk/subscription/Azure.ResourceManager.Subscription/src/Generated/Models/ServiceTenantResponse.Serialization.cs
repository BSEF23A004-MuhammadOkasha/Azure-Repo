// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class ServiceTenantResponse
    {
        internal static ServiceTenantResponse DeserializeServiceTenantResponse(JsonElement element)
        {
            Optional<Guid> tenantId = default;
            Optional<string> tenantName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantName"))
                {
                    tenantName = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceTenantResponse(Optional.ToNullable(tenantId), tenantName.Value);
        }
    }
}
