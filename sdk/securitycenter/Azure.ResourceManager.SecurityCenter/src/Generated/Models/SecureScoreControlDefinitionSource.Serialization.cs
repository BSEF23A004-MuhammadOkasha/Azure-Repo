// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SecureScoreControlDefinitionSource
    {
        internal static SecureScoreControlDefinitionSource DeserializeSecureScoreControlDefinitionSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityControlType> sourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceType = new SecurityControlType(property.Value.GetString());
                    continue;
                }
            }
            return new SecureScoreControlDefinitionSource(Optional.ToNullable(sourceType));
        }
    }
}
