// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlTriggerResourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(TriggerName);
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body");
                writer.WriteStringValue(Body);
            }
            if (Optional.IsDefined(TriggerType))
            {
                writer.WritePropertyName("triggerType");
                writer.WriteStringValue(TriggerType.Value.ToString());
            }
            if (Optional.IsDefined(TriggerOperation))
            {
                writer.WritePropertyName("triggerOperation");
                writer.WriteStringValue(TriggerOperation.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBSqlTriggerResourceInfo DeserializeCosmosDBSqlTriggerResourceInfo(JsonElement element)
        {
            string id = default;
            Optional<string> body = default;
            Optional<CosmosDBSqlTriggerType> triggerType = default;
            Optional<CosmosDBSqlTriggerOperation> triggerOperation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("body"))
                {
                    body = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    triggerType = new CosmosDBSqlTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggerOperation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    triggerOperation = new CosmosDBSqlTriggerOperation(property.Value.GetString());
                    continue;
                }
            }
            return new CosmosDBSqlTriggerResourceInfo(id, body.Value, Optional.ToNullable(triggerType), Optional.ToNullable(triggerOperation));
        }
    }
}
