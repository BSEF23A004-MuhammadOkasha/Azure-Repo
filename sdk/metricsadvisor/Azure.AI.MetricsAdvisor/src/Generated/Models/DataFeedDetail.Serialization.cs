// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DataFeedDetail : IUtf8JsonSerializable, IJsonModel<DataFeedDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFeedDetail>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DataFeedDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DataFeedDetail>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DataFeedDetail>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType.ToString());
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DataFeedId))
                {
                    writer.WritePropertyName("dataFeedId"u8);
                    writer.WriteStringValue(DataFeedId);
                }
            }
            writer.WritePropertyName("dataFeedName"u8);
            writer.WriteStringValue(DataFeedName);
            if (Optional.IsDefined(DataFeedDescription))
            {
                writer.WritePropertyName("dataFeedDescription"u8);
                writer.WriteStringValue(DataFeedDescription);
            }
            writer.WritePropertyName("granularityName"u8);
            writer.WriteStringValue(GranularityName.ToString());
            if (Optional.IsDefined(GranularityAmount))
            {
                if (GranularityAmount != null)
                {
                    writer.WritePropertyName("granularityAmount"u8);
                    writer.WriteNumberValue(GranularityAmount.Value);
                }
                else
                {
                    writer.WriteNull("granularityAmount");
                }
            }
            writer.WritePropertyName("metrics"u8);
            writer.WriteStartArray();
            foreach (var item in Metrics)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Dimension))
            {
                writer.WritePropertyName("dimension"u8);
                writer.WriteStartArray();
                foreach (var item in Dimension)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimestampColumn))
            {
                writer.WritePropertyName("timestampColumn"u8);
                writer.WriteStringValue(TimestampColumn);
            }
            writer.WritePropertyName("dataStartFrom"u8);
            writer.WriteStringValue(DataStartFrom, "O");
            if (Optional.IsDefined(StartOffsetInSeconds))
            {
                writer.WritePropertyName("startOffsetInSeconds"u8);
                writer.WriteNumberValue(StartOffsetInSeconds.Value);
            }
            if (Optional.IsDefined(MaxConcurrency))
            {
                writer.WritePropertyName("maxConcurrency"u8);
                writer.WriteNumberValue(MaxConcurrency.Value);
            }
            if (Optional.IsDefined(MinRetryIntervalInSeconds))
            {
                writer.WritePropertyName("minRetryIntervalInSeconds"u8);
                writer.WriteNumberValue(MinRetryIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(StopRetryAfterInSeconds))
            {
                writer.WritePropertyName("stopRetryAfterInSeconds"u8);
                writer.WriteNumberValue(StopRetryAfterInSeconds.Value);
            }
            if (Optional.IsDefined(NeedRollup))
            {
                writer.WritePropertyName("needRollup"u8);
                writer.WriteStringValue(NeedRollup.Value.ToString());
            }
            if (Optional.IsDefined(RollUpMethod))
            {
                writer.WritePropertyName("rollUpMethod"u8);
                writer.WriteStringValue(RollUpMethod.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RollUpColumns))
            {
                writer.WritePropertyName("rollUpColumns"u8);
                writer.WriteStartArray();
                foreach (var item in RollUpColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllUpIdentification))
            {
                writer.WritePropertyName("allUpIdentification"u8);
                writer.WriteStringValue(AllUpIdentification);
            }
            if (Optional.IsDefined(FillMissingPointType))
            {
                writer.WritePropertyName("fillMissingPointType"u8);
                writer.WriteStringValue(FillMissingPointType.Value.ToString());
            }
            if (Optional.IsDefined(FillMissingPointValue))
            {
                writer.WritePropertyName("fillMissingPointValue"u8);
                writer.WriteNumberValue(FillMissingPointValue.Value);
            }
            if (Optional.IsDefined(ViewMode))
            {
                writer.WritePropertyName("viewMode"u8);
                writer.WriteStringValue(ViewMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Admins))
            {
                writer.WritePropertyName("admins"u8);
                writer.WriteStartArray();
                foreach (var item in Admins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Viewers))
            {
                writer.WritePropertyName("viewers"u8);
                writer.WriteStartArray();
                foreach (var item in Viewers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsAdmin))
                {
                    writer.WritePropertyName("isAdmin"u8);
                    writer.WriteBooleanValue(IsAdmin.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Creator))
                {
                    writer.WritePropertyName("creator"u8);
                    writer.WriteStringValue(Creator);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreatedTime))
                {
                    writer.WritePropertyName("createdTime"u8);
                    writer.WriteStringValue(CreatedTime.Value, "O");
                }
            }
            if (Optional.IsDefined(ActionLinkTemplate))
            {
                writer.WritePropertyName("actionLinkTemplate"u8);
                writer.WriteStringValue(ActionLinkTemplate);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(CredentialId))
            {
                writer.WritePropertyName("credentialId"u8);
                writer.WriteStringValue(CredentialId);
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

        DataFeedDetail IJsonModel<DataFeedDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFeedDetail)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFeedDetail(document.RootElement, options);
        }

        internal static DataFeedDetail DeserializeDataFeedDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("dataSourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureApplicationInsights": return AzureApplicationInsightsDataFeed.DeserializeAzureApplicationInsightsDataFeed(element);
                    case "AzureBlob": return AzureBlobDataFeed.DeserializeAzureBlobDataFeed(element);
                    case "AzureCosmosDB": return AzureCosmosDBDataFeed.DeserializeAzureCosmosDBDataFeed(element);
                    case "AzureDataExplorer": return AzureDataExplorerDataFeed.DeserializeAzureDataExplorerDataFeed(element);
                    case "AzureDataLakeStorageGen2": return AzureDataLakeStorageGen2DataFeed.DeserializeAzureDataLakeStorageGen2DataFeed(element);
                    case "AzureEventHubs": return AzureEventHubsDataFeed.DeserializeAzureEventHubsDataFeed(element);
                    case "AzureLogAnalytics": return AzureLogAnalyticsDataFeed.DeserializeAzureLogAnalyticsDataFeed(element);
                    case "AzureTable": return AzureTableDataFeed.DeserializeAzureTableDataFeed(element);
                    case "InfluxDB": return InfluxDBDataFeed.DeserializeInfluxDBDataFeed(element);
                    case "MongoDB": return MongoDBDataFeed.DeserializeMongoDBDataFeed(element);
                    case "MySql": return MySqlDataFeed.DeserializeMySqlDataFeed(element);
                    case "PostgreSql": return PostgreSqlDataFeed.DeserializePostgreSqlDataFeed(element);
                    case "SqlServer": return SQLServerDataFeed.DeserializeSQLServerDataFeed(element);
                }
            }
            return UnknownDataFeedDetail.DeserializeUnknownDataFeedDetail(element);
        }

        BinaryData IPersistableModel<DataFeedDetail>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFeedDetail)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataFeedDetail IPersistableModel<DataFeedDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFeedDetail)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataFeedDetail(document.RootElement, options);
        }

        string IPersistableModel<DataFeedDetail>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
