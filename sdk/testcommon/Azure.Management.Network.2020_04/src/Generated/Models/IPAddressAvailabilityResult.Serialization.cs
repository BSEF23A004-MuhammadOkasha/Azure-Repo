// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class IPAddressAvailabilityResult
    {
        internal static IPAddressAvailabilityResult DeserializeIPAddressAvailabilityResult(JsonElement element)
        {
            Optional<bool> available = default;
            Optional<IReadOnlyList<string>> availableIPAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("available"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    available = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("availableIPAddresses"))
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
                    availableIPAddresses = array;
                    continue;
                }
            }
            return new IPAddressAvailabilityResult(Optional.ToNullable(available), Optional.ToList(availableIPAddresses));
        }
    }
}
