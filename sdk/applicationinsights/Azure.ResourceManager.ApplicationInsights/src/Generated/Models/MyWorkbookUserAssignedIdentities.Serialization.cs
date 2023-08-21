// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class MyWorkbookUserAssignedIdentities : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static MyWorkbookUserAssignedIdentities DeserializeMyWorkbookUserAssignedIdentities(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> principalId = default;
            Core.Optional<Guid> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
            }
            return new MyWorkbookUserAssignedIdentities(principalId.Value, Core.Optional.ToNullable(tenantId));
        }
    }
}
