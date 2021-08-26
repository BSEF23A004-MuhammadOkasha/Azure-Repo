// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class TableGetPropertiesResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WriteEndObject();
        }

        internal static TableGetPropertiesResource DeserializeTableGetPropertiesResource(JsonElement element)
        {
            Optional<string> Rid = default;
            Optional<float> Ts = default;
            Optional<string> Etag = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    Rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new TableGetPropertiesResource(id, Rid.Value, Optional.ToNullable(Ts), Etag.Value);
        }
    }
}
