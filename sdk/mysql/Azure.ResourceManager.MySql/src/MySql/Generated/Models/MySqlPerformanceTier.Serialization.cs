// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlPerformanceTier
    {
        internal static MySqlPerformanceTier DeserializeMySqlPerformanceTier(JsonElement element)
        {
            Optional<string> id = default;
            Optional<int> maxBackupRetentionDays = default;
            Optional<int> minBackupRetentionDays = default;
            Optional<int> maxStorageMB = default;
            Optional<int> minLargeStorageMB = default;
            Optional<int> maxLargeStorageMB = default;
            Optional<int> minStorageMB = default;
            Optional<IReadOnlyList<MySqlPerformanceTierServiceLevelObjectives>> serviceLevelObjectives = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxStorageMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLargeStorageMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLargeStorageMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minStorageMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceLevelObjectives"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MySqlPerformanceTierServiceLevelObjectives> array = new List<MySqlPerformanceTierServiceLevelObjectives>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlPerformanceTierServiceLevelObjectives.DeserializeMySqlPerformanceTierServiceLevelObjectives(item));
                    }
                    serviceLevelObjectives = array;
                    continue;
                }
            }
            return new MySqlPerformanceTier(id.Value, Optional.ToNullable(maxBackupRetentionDays), Optional.ToNullable(minBackupRetentionDays), Optional.ToNullable(maxStorageMB), Optional.ToNullable(minLargeStorageMB), Optional.ToNullable(maxLargeStorageMB), Optional.ToNullable(minStorageMB), Optional.ToList(serviceLevelObjectives));
        }
    }
}
