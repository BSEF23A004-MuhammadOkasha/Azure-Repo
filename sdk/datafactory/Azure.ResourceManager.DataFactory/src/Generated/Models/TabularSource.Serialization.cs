// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TabularSource : IUtf8JsonSerializable, IJsonModel<TabularSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TabularSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TabularSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TabularSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TabularSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (QueryTimeout != null)
            {
                writer.WritePropertyName("queryTimeout"u8);
                JsonSerializer.Serialize(writer, QueryTimeout);
            }
            if (AdditionalColumns != null)
            {
                writer.WritePropertyName("additionalColumns"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalColumns);
#else
                using (JsonDocument document = JsonDocument.Parse(AdditionalColumns))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (SourceRetryCount != null)
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                JsonSerializer.Serialize(writer, SourceRetryCount);
            }
            if (SourceRetryWait != null)
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                JsonSerializer.Serialize(writer, SourceRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        TabularSource IJsonModel<TabularSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TabularSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TabularSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTabularSource(document.RootElement, options);
        }

        internal static TabularSource DeserializeTabularSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWSSource": return AmazonMwsSource.DeserializeAmazonMwsSource(element, options);
                    case "AmazonRdsForSqlServerSource": return AmazonRdsForSqlServerSource.DeserializeAmazonRdsForSqlServerSource(element, options);
                    case "AmazonRedshiftSource": return AmazonRedshiftSource.DeserializeAmazonRedshiftSource(element, options);
                    case "AzureMariaDBSource": return AzureMariaDBSource.DeserializeAzureMariaDBSource(element, options);
                    case "AzureMySqlSource": return AzureMySqlSource.DeserializeAzureMySqlSource(element, options);
                    case "AzurePostgreSqlSource": return AzurePostgreSqlSource.DeserializeAzurePostgreSqlSource(element, options);
                    case "AzureSqlSource": return AzureSqlSource.DeserializeAzureSqlSource(element, options);
                    case "AzureTableSource": return AzureTableSource.DeserializeAzureTableSource(element, options);
                    case "CassandraSource": return CassandraSource.DeserializeCassandraSource(element, options);
                    case "ConcurSource": return ConcurSource.DeserializeConcurSource(element, options);
                    case "CouchbaseSource": return CouchbaseSource.DeserializeCouchbaseSource(element, options);
                    case "Db2Source": return Db2Source.DeserializeDb2Source(element, options);
                    case "DrillSource": return DrillSource.DeserializeDrillSource(element, options);
                    case "DynamicsAXSource": return DynamicsAXSource.DeserializeDynamicsAXSource(element, options);
                    case "EloquaSource": return EloquaSource.DeserializeEloquaSource(element, options);
                    case "GoogleAdWordsSource": return GoogleAdWordsSource.DeserializeGoogleAdWordsSource(element, options);
                    case "GoogleBigQuerySource": return GoogleBigQuerySource.DeserializeGoogleBigQuerySource(element, options);
                    case "GreenplumSource": return GreenplumSource.DeserializeGreenplumSource(element, options);
                    case "HBaseSource": return HBaseSource.DeserializeHBaseSource(element, options);
                    case "HiveSource": return HiveSource.DeserializeHiveSource(element, options);
                    case "HubspotSource": return HubspotSource.DeserializeHubspotSource(element, options);
                    case "ImpalaSource": return ImpalaSource.DeserializeImpalaSource(element, options);
                    case "InformixSource": return InformixSource.DeserializeInformixSource(element, options);
                    case "JiraSource": return JiraSource.DeserializeJiraSource(element, options);
                    case "MagentoSource": return MagentoSource.DeserializeMagentoSource(element, options);
                    case "MariaDBSource": return MariaDBSource.DeserializeMariaDBSource(element, options);
                    case "MarketoSource": return MarketoSource.DeserializeMarketoSource(element, options);
                    case "MySqlSource": return MySqlSource.DeserializeMySqlSource(element, options);
                    case "NetezzaSource": return NetezzaSource.DeserializeNetezzaSource(element, options);
                    case "OdbcSource": return OdbcSource.DeserializeOdbcSource(element, options);
                    case "OracleServiceCloudSource": return OracleServiceCloudSource.DeserializeOracleServiceCloudSource(element, options);
                    case "PaypalSource": return PaypalSource.DeserializePaypalSource(element, options);
                    case "PhoenixSource": return PhoenixSource.DeserializePhoenixSource(element, options);
                    case "PostgreSqlSource": return PostgreSqlSource.DeserializePostgreSqlSource(element, options);
                    case "PrestoSource": return PrestoSource.DeserializePrestoSource(element, options);
                    case "QuickBooksSource": return QuickBooksSource.DeserializeQuickBooksSource(element, options);
                    case "ResponsysSource": return ResponsysSource.DeserializeResponsysSource(element, options);
                    case "SalesforceMarketingCloudSource": return SalesforceMarketingCloudSource.DeserializeSalesforceMarketingCloudSource(element, options);
                    case "SalesforceSource": return SalesforceSource.DeserializeSalesforceSource(element, options);
                    case "SalesforceV2Source": return SalesforceV2Source.DeserializeSalesforceV2Source(element, options);
                    case "SapBwSource": return SapBWSource.DeserializeSapBWSource(element, options);
                    case "SapCloudForCustomerSource": return SapCloudForCustomerSource.DeserializeSapCloudForCustomerSource(element, options);
                    case "SapEccSource": return SapEccSource.DeserializeSapEccSource(element, options);
                    case "SapHanaSource": return SapHanaSource.DeserializeSapHanaSource(element, options);
                    case "SapOdpSource": return SapOdpSource.DeserializeSapOdpSource(element, options);
                    case "SapOpenHubSource": return SapOpenHubSource.DeserializeSapOpenHubSource(element, options);
                    case "SapTableSource": return SapTableSource.DeserializeSapTableSource(element, options);
                    case "ServiceNowSource": return ServiceNowSource.DeserializeServiceNowSource(element, options);
                    case "ShopifySource": return ShopifySource.DeserializeShopifySource(element, options);
                    case "SparkSource": return SparkSource.DeserializeSparkSource(element, options);
                    case "SqlDWSource": return SqlDWSource.DeserializeSqlDWSource(element, options);
                    case "SqlMISource": return SqlMISource.DeserializeSqlMISource(element, options);
                    case "SqlServerSource": return SqlServerSource.DeserializeSqlServerSource(element, options);
                    case "SqlSource": return SqlSource.DeserializeSqlSource(element, options);
                    case "SquareSource": return SquareSource.DeserializeSquareSource(element, options);
                    case "SybaseSource": return SybaseSource.DeserializeSybaseSource(element, options);
                    case "TeradataSource": return TeradataSource.DeserializeTeradataSource(element, options);
                    case "VerticaSource": return VerticaSource.DeserializeVerticaSource(element, options);
                    case "WarehouseSource": return WarehouseSource.DeserializeWarehouseSource(element, options);
                    case "XeroSource": return XeroSource.DeserializeXeroSource(element, options);
                    case "ZohoSource": return ZohoSource.DeserializeZohoSource(element, options);
                }
            }
            Optional<DataFactoryElement<string>> queryTimeout = default;
            Optional<BinaryData> additionalColumns = default;
            string type = "TabularSource";
            Optional<DataFactoryElement<int>> sourceRetryCount = default;
            Optional<DataFactoryElement<string>> sourceRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TabularSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, queryTimeout.Value, additionalColumns.Value);
        }

        BinaryData IPersistableModel<TabularSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TabularSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TabularSource)} does not support '{options.Format}' format.");
            }
        }

        TabularSource IPersistableModel<TabularSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TabularSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTabularSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TabularSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TabularSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
