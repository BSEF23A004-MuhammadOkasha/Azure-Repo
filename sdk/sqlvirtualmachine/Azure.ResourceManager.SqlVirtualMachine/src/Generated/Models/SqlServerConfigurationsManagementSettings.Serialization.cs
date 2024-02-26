// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlServerConfigurationsManagementSettings : IUtf8JsonSerializable, IJsonModel<SqlServerConfigurationsManagementSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerConfigurationsManagementSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerConfigurationsManagementSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerConfigurationsManagementSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerConfigurationsManagementSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SqlConnectivityUpdateSettings != null)
            {
                writer.WritePropertyName("sqlConnectivityUpdateSettings"u8);
                writer.WriteObjectValue(SqlConnectivityUpdateSettings);
            }
            if (SqlWorkloadTypeUpdateSettings != null)
            {
                writer.WritePropertyName("sqlWorkloadTypeUpdateSettings"u8);
                writer.WriteObjectValue(SqlWorkloadTypeUpdateSettings);
            }
            if (SqlStorageUpdateSettings != null)
            {
                writer.WritePropertyName("sqlStorageUpdateSettings"u8);
                writer.WriteObjectValue(SqlStorageUpdateSettings);
            }
            if (AdditionalFeaturesServerConfigurations != null)
            {
                writer.WritePropertyName("additionalFeaturesServerConfigurations"u8);
                writer.WriteObjectValue(AdditionalFeaturesServerConfigurations);
            }
            if (SqlInstanceSettings != null)
            {
                writer.WritePropertyName("sqlInstanceSettings"u8);
                writer.WriteObjectValue(SqlInstanceSettings);
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
            writer.WriteEndObject();
        }

        SqlServerConfigurationsManagementSettings IJsonModel<SqlServerConfigurationsManagementSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerConfigurationsManagementSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerConfigurationsManagementSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerConfigurationsManagementSettings(document.RootElement, options);
        }

        internal static SqlServerConfigurationsManagementSettings DeserializeSqlServerConfigurationsManagementSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlConnectivityUpdateSettings> sqlConnectivityUpdateSettings = default;
            Optional<SqlWorkloadTypeUpdateSettings> sqlWorkloadTypeUpdateSettings = default;
            Optional<SqlStorageUpdateSettings> sqlStorageUpdateSettings = default;
            Optional<AdditionalFeaturesServerConfigurations> additionalFeaturesServerConfigurations = default;
            Optional<SqlInstanceSettings> sqlInstanceSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlConnectivityUpdateSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlConnectivityUpdateSettings = SqlConnectivityUpdateSettings.DeserializeSqlConnectivityUpdateSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sqlWorkloadTypeUpdateSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWorkloadTypeUpdateSettings = SqlWorkloadTypeUpdateSettings.DeserializeSqlWorkloadTypeUpdateSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sqlStorageUpdateSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlStorageUpdateSettings = SqlStorageUpdateSettings.DeserializeSqlStorageUpdateSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalFeaturesServerConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalFeaturesServerConfigurations = AdditionalFeaturesServerConfigurations.DeserializeAdditionalFeaturesServerConfigurations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sqlInstanceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlInstanceSettings = SqlInstanceSettings.DeserializeSqlInstanceSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlServerConfigurationsManagementSettings(sqlConnectivityUpdateSettings.Value, sqlWorkloadTypeUpdateSettings.Value, sqlStorageUpdateSettings.Value, additionalFeaturesServerConfigurations.Value, sqlInstanceSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerConfigurationsManagementSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerConfigurationsManagementSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerConfigurationsManagementSettings)} does not support '{options.Format}' format.");
            }
        }

        SqlServerConfigurationsManagementSettings IPersistableModel<SqlServerConfigurationsManagementSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerConfigurationsManagementSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerConfigurationsManagementSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerConfigurationsManagementSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerConfigurationsManagementSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
