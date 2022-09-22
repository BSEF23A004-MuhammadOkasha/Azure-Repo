// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SqlMigrationTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo");
            writer.WriteObjectValue(TargetConnectionInfo);
            writer.WriteEndObject();
        }

        internal static SqlMigrationTaskInput DeserializeSqlMigrationTaskInput(JsonElement element)
        {
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
            }
            return new SqlMigrationTaskInput(sourceConnectionInfo, targetConnectionInfo);
        }
    }
}
