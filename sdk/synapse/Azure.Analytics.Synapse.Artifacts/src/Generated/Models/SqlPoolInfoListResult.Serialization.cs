// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SqlPoolInfoListResultConverter))]
    public partial class SqlPoolInfoListResult
    {
        internal static SqlPoolInfoListResult DeserializeSqlPoolInfoListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<SqlPool>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlPool> array = new List<SqlPool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlPool.DeserializeSqlPool(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SqlPoolInfoListResult(nextLink.Value, Core.Optional.ToList(value));
        }

        internal partial class SqlPoolInfoListResultConverter : JsonConverter<SqlPoolInfoListResult>
        {
            public override void Write(Utf8JsonWriter writer, SqlPoolInfoListResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override SqlPoolInfoListResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlPoolInfoListResult(document.RootElement);
            }
        }
    }
}
