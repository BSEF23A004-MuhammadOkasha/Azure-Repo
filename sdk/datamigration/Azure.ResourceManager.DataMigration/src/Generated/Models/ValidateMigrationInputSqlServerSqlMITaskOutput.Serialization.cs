// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ValidateMigrationInputSqlServerSqlMITaskOutput : IUtf8JsonSerializable, IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RestoreDatabaseNameErrors))
            {
                writer.WritePropertyName("restoreDatabaseNameErrors"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreDatabaseNameErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BackupFolderErrors))
            {
                writer.WritePropertyName("backupFolderErrors"u8);
                writer.WriteStartArray();
                foreach (var item in BackupFolderErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BackupShareCredentialsErrors))
            {
                writer.WritePropertyName("backupShareCredentialsErrors"u8);
                writer.WriteStartArray();
                foreach (var item in BackupShareCredentialsErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BackupStorageAccountErrors))
            {
                writer.WritePropertyName("backupStorageAccountErrors"u8);
                writer.WriteStartArray();
                foreach (var item in BackupStorageAccountErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExistingBackupErrors))
            {
                writer.WritePropertyName("existingBackupErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ExistingBackupErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DatabaseBackupInfo))
            {
                writer.WritePropertyName("databaseBackupInfo"u8);
                writer.WriteObjectValue(DatabaseBackupInfo, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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
        }

        ValidateMigrationInputSqlServerSqlMITaskOutput IJsonModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateMigrationInputSqlServerSqlMITaskOutput(document.RootElement, options);
        }

        internal static ValidateMigrationInputSqlServerSqlMITaskOutput DeserializeValidateMigrationInputSqlServerSqlMITaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            IReadOnlyList<ReportableException> restoreDatabaseNameErrors = default;
            IReadOnlyList<ReportableException> backupFolderErrors = default;
            IReadOnlyList<ReportableException> backupShareCredentialsErrors = default;
            IReadOnlyList<ReportableException> backupStorageAccountErrors = default;
            IReadOnlyList<ReportableException> existingBackupErrors = default;
            DatabaseBackupInfo databaseBackupInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreDatabaseNameErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    restoreDatabaseNameErrors = array;
                    continue;
                }
                if (property.NameEquals("backupFolderErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    backupFolderErrors = array;
                    continue;
                }
                if (property.NameEquals("backupShareCredentialsErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    backupShareCredentialsErrors = array;
                    continue;
                }
                if (property.NameEquals("backupStorageAccountErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    backupStorageAccountErrors = array;
                    continue;
                }
                if (property.NameEquals("existingBackupErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    existingBackupErrors = array;
                    continue;
                }
                if (property.NameEquals("databaseBackupInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseBackupInfo = DatabaseBackupInfo.DeserializeDatabaseBackupInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ValidateMigrationInputSqlServerSqlMITaskOutput(
                id,
                name,
                restoreDatabaseNameErrors ?? new ChangeTrackingList<ReportableException>(),
                backupFolderErrors ?? new ChangeTrackingList<ReportableException>(),
                backupShareCredentialsErrors ?? new ChangeTrackingList<ReportableException>(),
                backupStorageAccountErrors ?? new ChangeTrackingList<ReportableException>(),
                existingBackupErrors ?? new ChangeTrackingList<ReportableException>(),
                databaseBackupInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support writing '{options.Format}' format.");
            }
        }

        ValidateMigrationInputSqlServerSqlMITaskOutput IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeValidateMigrationInputSqlServerSqlMITaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMITaskOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ValidateMigrationInputSqlServerSqlMITaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
