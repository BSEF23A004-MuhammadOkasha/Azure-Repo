// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SqlBackupSetInfo : IUtf8JsonSerializable, IModelJsonSerializable<SqlBackupSetInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlBackupSetInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlBackupSetInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SqlBackupSetInfo DeserializeSqlBackupSetInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> backupSetId = default;
            Optional<string> firstLSN = default;
            Optional<string> lastLSN = default;
            Optional<string> backupType = default;
            Optional<IReadOnlyList<SqlBackupFileInfo>> listOfBackupFiles = default;
            Optional<DateTimeOffset> backupStartDate = default;
            Optional<DateTimeOffset> backupFinishDate = default;
            Optional<bool> isBackupRestored = default;
            Optional<bool> hasBackupChecksums = default;
            Optional<int> familyCount = default;
            Optional<IReadOnlyList<string>> ignoreReasons = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupSetId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("firstLSN"u8))
                {
                    firstLSN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastLSN"u8))
                {
                    lastLSN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupType"u8))
                {
                    backupType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("listOfBackupFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlBackupFileInfo> array = new List<SqlBackupFileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlBackupFileInfo.DeserializeSqlBackupFileInfo(item));
                    }
                    listOfBackupFiles = array;
                    continue;
                }
                if (property.NameEquals("backupStartDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStartDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupFinishDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFinishDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isBackupRestored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hasBackupChecksums"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasBackupChecksums = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("familyCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ignoreReasons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ignoreReasons = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SqlBackupSetInfo(Optional.ToNullable(backupSetId), firstLSN.Value, lastLSN.Value, backupType.Value, Optional.ToList(listOfBackupFiles), Optional.ToNullable(backupStartDate), Optional.ToNullable(backupFinishDate), Optional.ToNullable(isBackupRestored), Optional.ToNullable(hasBackupChecksums), Optional.ToNullable(familyCount), Optional.ToList(ignoreReasons), rawData);
        }

        SqlBackupSetInfo IModelJsonSerializable<SqlBackupSetInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlBackupSetInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlBackupSetInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlBackupSetInfo IModelSerializable<SqlBackupSetInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlBackupSetInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SqlBackupSetInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SqlBackupSetInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlBackupSetInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
