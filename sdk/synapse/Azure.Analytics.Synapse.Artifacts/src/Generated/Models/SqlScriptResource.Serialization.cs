// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SqlScriptResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteObjectValue(Properties);
            writer.WriteEndObject();
        }

        internal static SqlScriptResource DeserializeSqlScriptResource(JsonElement element)
        {
            SqlScript properties = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    properties = SqlScript.DeserializeSqlScript(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new SqlScriptResource(id.Value, name.Value, type.Value, etag.Value, properties);
        }
    }
}
