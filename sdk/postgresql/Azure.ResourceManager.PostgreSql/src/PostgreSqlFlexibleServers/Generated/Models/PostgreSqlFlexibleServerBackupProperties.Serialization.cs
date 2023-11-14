// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerBackupProperties : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerBackupProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerBackupProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PostgreSqlFlexibleServerBackupProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PostgreSqlFlexibleServerBackupProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PostgreSqlFlexibleServerBackupProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupRetentionDays))
            {
                writer.WritePropertyName("backupRetentionDays"u8);
                writer.WriteNumberValue(BackupRetentionDays.Value);
            }
            if (Optional.IsDefined(GeoRedundantBackup))
            {
                writer.WritePropertyName("geoRedundantBackup"u8);
                writer.WriteStringValue(GeoRedundantBackup.Value.ToString());
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(EarliestRestoreOn))
                {
                    writer.WritePropertyName("earliestRestoreDate"u8);
                    writer.WriteStringValue(EarliestRestoreOn.Value, "O");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PostgreSqlFlexibleServerBackupProperties IJsonModel<PostgreSqlFlexibleServerBackupProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerBackupProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerBackupProperties(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerBackupProperties DeserializePostgreSqlFlexibleServerBackupProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> backupRetentionDays = default;
            Optional<PostgreSqlFlexibleServerGeoRedundantBackupEnum> geoRedundantBackup = default;
            Optional<DateTimeOffset> earliestRestoreDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("geoRedundantBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoRedundantBackup = new PostgreSqlFlexibleServerGeoRedundantBackupEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("earliestRestoreDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    earliestRestoreDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerBackupProperties(Optional.ToNullable(backupRetentionDays), Optional.ToNullable(geoRedundantBackup), Optional.ToNullable(earliestRestoreDate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerBackupProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerBackupProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PostgreSqlFlexibleServerBackupProperties IPersistableModel<PostgreSqlFlexibleServerBackupProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerBackupProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerBackupProperties(document.RootElement, options);
        }

        string IPersistableModel<PostgreSqlFlexibleServerBackupProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
