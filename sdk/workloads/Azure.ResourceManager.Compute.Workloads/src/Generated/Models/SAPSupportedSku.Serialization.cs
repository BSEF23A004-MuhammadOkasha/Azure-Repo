// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class SAPSupportedSku
    {
        internal static SAPSupportedSku DeserializeSAPSupportedSku(JsonElement element)
        {
            Optional<string> vmSku = default;
            Optional<bool> isAppServerCertified = default;
            Optional<bool> isDatabaseCertified = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSku"))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAppServerCertified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAppServerCertified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDatabaseCertified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDatabaseCertified = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SAPSupportedSku(vmSku.Value, Optional.ToNullable(isAppServerCertified), Optional.ToNullable(isDatabaseCertified));
        }
    }
}
