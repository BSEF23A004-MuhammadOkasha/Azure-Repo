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
    public partial class ValidateMigrationInputSqlServerSqlMISyncTaskInput : IUtf8JsonSerializable, IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ValidateMigrationInputSqlServerSqlMISyncTaskInput IJsonModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateMigrationInputSqlServerSqlMISyncTaskInput(document.RootElement, options);
        }

        internal static ValidateMigrationInputSqlServerSqlMISyncTaskInput DeserializeValidateMigrationInputSqlServerSqlMISyncTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases = default;
            FileShare backupFileShare = default;
            string storageResourceId = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            MISqlConnectionInfo targetConnectionInfo = default;
            AzureActiveDirectoryApp azureApp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlMIDatabaseInput> array = new List<MigrateSqlServerSqlMIDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlMIDatabaseInput.DeserializeMigrateSqlServerSqlMIDatabaseInput(item, options));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFileShare = FileShare.DeserializeFileShare(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageResourceId"u8))
                {
                    storageResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = MISqlConnectionInfo.DeserializeMISqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureApp"u8))
                {
                    azureApp = AzureActiveDirectoryApp.DeserializeAzureActiveDirectoryApp(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ValidateMigrationInputSqlServerSqlMISyncTaskInput(
                selectedDatabases,
                backupFileShare,
                storageResourceId,
                sourceConnectionInfo,
                targetConnectionInfo,
                azureApp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support writing '{options.Format}' format.");
            }
        }

        ValidateMigrationInputSqlServerSqlMISyncTaskInput IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeValidateMigrationInputSqlServerSqlMISyncTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ValidateMigrationInputSqlServerSqlMISyncTaskInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ValidateMigrationInputSqlServerSqlMISyncTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
