// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedRestorableGremlinGraphResourceInfo
    {
        internal static ExtendedRestorableGremlinGraphResourceInfo DeserializeExtendedRestorableGremlinGraphResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<CosmosDBOperationType> operationType = default;
            Optional<string> eventTimestamp = default;
            Optional<string> ownerId = default;
            Optional<string> ownerResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new ExtendedRestorableGremlinGraphResourceInfo(rid.Value, Optional.ToNullable(operationType), eventTimestamp.Value, ownerId.Value, ownerResourceId.Value);
        }
    }
}
