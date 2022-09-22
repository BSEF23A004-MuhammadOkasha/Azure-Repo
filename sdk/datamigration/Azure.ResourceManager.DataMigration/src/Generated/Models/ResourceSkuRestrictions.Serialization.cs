// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ResourceSkuRestrictions
    {
        internal static ResourceSkuRestrictions DeserializeResourceSkuRestrictions(JsonElement element)
        {
            Optional<ResourceSkuRestrictionsType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<ResourceSkuRestrictionsReasonCode> reasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceSkuRestrictionsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("reasonCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reasonCode = new ResourceSkuRestrictionsReasonCode(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceSkuRestrictions(Optional.ToNullable(type), Optional.ToList(values), Optional.ToNullable(reasonCode));
        }
    }
}
