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
    public partial class MigrateSchemaSqlServerSqlDBTaskInput : IUtf8JsonSerializable, IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
            }
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn);
            }
        }

        MigrateSchemaSqlServerSqlDBTaskInput IJsonModel<MigrateSchemaSqlServerSqlDBTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSchemaSqlServerSqlDBTaskInput(document.RootElement, options);
        }

        internal static MigrateSchemaSqlServerSqlDBTaskInput DeserializeMigrateSchemaSqlServerSqlDBTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSchemaSqlServerSqlDBDatabaseInput> selectedDatabases = default;
            string encryptedKeyForSecureFields = default;
            string startedOn = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSchemaSqlServerSqlDBDatabaseInput> array = new List<MigrateSchemaSqlServerSqlDBDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSchemaSqlServerSqlDBDatabaseInput.DeserializeMigrateSchemaSqlServerSqlDBDatabaseInput(item, options));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    startedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrateSchemaSqlServerSqlDBTaskInput(
                sourceConnectionInfo,
                targetConnectionInfo,
                serializedAdditionalRawData,
                selectedDatabases,
                encryptedKeyForSecureFields,
                startedOn);
        }

        BinaryData IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateSchemaSqlServerSqlDBTaskInput IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSchemaSqlServerSqlDBTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBTaskInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSchemaSqlServerSqlDBTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
