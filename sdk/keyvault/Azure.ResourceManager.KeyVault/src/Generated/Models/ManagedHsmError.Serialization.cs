// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KeyVaultManagementClient.Models
{
    internal partial class ManagedHsmError
    {
        internal static ManagedHsmError DeserializeManagedHsmError(JsonElement element)
        {
            Optional<Error> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = Error.DeserializeError(property.Value);
                    continue;
                }
            }
            return new ManagedHsmError(error.Value);
        }
    }
}
