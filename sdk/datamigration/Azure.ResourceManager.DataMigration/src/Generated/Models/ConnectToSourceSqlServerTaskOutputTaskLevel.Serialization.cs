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
    public partial class ConnectToSourceSqlServerTaskOutputTaskLevel : IUtf8JsonSerializable, IJsonModel<ConnectToSourceSqlServerTaskOutputTaskLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToSourceSqlServerTaskOutputTaskLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToSourceSqlServerTaskOutputTaskLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputTaskLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputTaskLevel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStringValue(Databases);
            }
            if (options.Format != "W" && Optional.IsDefined(Logins))
            {
                writer.WritePropertyName("logins"u8);
                writer.WriteStringValue(Logins);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentJobs))
            {
                writer.WritePropertyName("agentJobs"u8);
                writer.WriteStringValue(AgentJobs);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseTdeCertificateMapping))
            {
                writer.WritePropertyName("databaseTdeCertificateMapping"u8);
                writer.WriteStringValue(DatabaseTdeCertificateMapping);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerVersion))
            {
                writer.WritePropertyName("sourceServerVersion"u8);
                writer.WriteStringValue(SourceServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerBrandVersion))
            {
                writer.WritePropertyName("sourceServerBrandVersion"u8);
                writer.WriteStringValue(SourceServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue<ReportableException>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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
            writer.WriteEndObject();
        }

        ConnectToSourceSqlServerTaskOutputTaskLevel IJsonModel<ConnectToSourceSqlServerTaskOutputTaskLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputTaskLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputTaskLevel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceSqlServerTaskOutputTaskLevel(document.RootElement, options);
        }

        internal static ConnectToSourceSqlServerTaskOutputTaskLevel DeserializeConnectToSourceSqlServerTaskOutputTaskLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databases = default;
            string logins = default;
            string agentJobs = default;
            string databaseTdeCertificateMapping = default;
            string sourceServerVersion = default;
            string sourceServerBrandVersion = default;
            IReadOnlyList<ReportableException> validationErrors = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databases"u8))
                {
                    databases = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logins"u8))
                {
                    logins = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentJobs"u8))
                {
                    agentJobs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseTdeCertificateMapping"u8))
                {
                    databaseTdeCertificateMapping = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"u8))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
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
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToSourceSqlServerTaskOutputTaskLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                databases,
                logins,
                agentJobs,
                databaseTdeCertificateMapping,
                sourceServerVersion,
                sourceServerBrandVersion,
                validationErrors ?? new ChangeTrackingList<ReportableException>());
        }

        BinaryData IPersistableModel<ConnectToSourceSqlServerTaskOutputTaskLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputTaskLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputTaskLevel)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectToSourceSqlServerTaskOutputTaskLevel IPersistableModel<ConnectToSourceSqlServerTaskOutputTaskLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputTaskLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToSourceSqlServerTaskOutputTaskLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputTaskLevel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToSourceSqlServerTaskOutputTaskLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
