// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseFileInfo
    {
        internal static DatabaseFileInfo DeserializeDatabaseFileInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> databaseName = default;
            Optional<string> id = default;
            Optional<string> logicalName = default;
            Optional<string> physicalFullName = default;
            Optional<string> restoreFullName = default;
            Optional<DatabaseFileType> fileType = default;
            Optional<double> sizeMB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logicalName"u8))
                {
                    logicalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalFullName"u8))
                {
                    physicalFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreFullName"u8))
                {
                    restoreFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileType = new DatabaseFileType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeMB = property.Value.GetDouble();
                    continue;
                }
            }
            return new DatabaseFileInfo(databaseName.Value, id.Value, logicalName.Value, physicalFullName.Value, restoreFullName.Value, Optional.ToNullable(fileType), Optional.ToNullable(sizeMB));
        }
    }
}
