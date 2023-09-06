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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureDataExplorerDataFeedPatch : IUtf8JsonSerializable, IModelJsonSerializable<AzureDataExplorerDataFeedPatch>
    {
        void IModelJsonSerializable<AzureDataExplorerDataFeedPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataExplorerDataFeedPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DataSourceParameter))
            {
                writer.WritePropertyName("dataSourceParameter"u8);
                if (DataSourceParameter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SQLSourceParameterPatch>)DataSourceParameter).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType.ToString());
            if (Optional.IsDefined(DataFeedName))
            {
                writer.WritePropertyName("dataFeedName"u8);
                writer.WriteStringValue(DataFeedName);
            }
            if (Optional.IsDefined(DataFeedDescription))
            {
                writer.WritePropertyName("dataFeedDescription"u8);
                writer.WriteStringValue(DataFeedDescription);
            }
            if (Optional.IsDefined(TimestampColumn))
            {
                writer.WritePropertyName("timestampColumn"u8);
                writer.WriteStringValue(TimestampColumn);
            }
            if (Optional.IsDefined(DataStartFrom))
            {
                writer.WritePropertyName("dataStartFrom"u8);
                writer.WriteStringValue(DataStartFrom.Value, "O");
            }
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
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        internal static AzureDataExplorerDataFeedPatch DeserializeAzureDataExplorerDataFeedPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SQLSourceParameterPatch> dataSourceParameter = default;
            DataFeedSourceKind dataSourceType = default;
            Optional<string> dataFeedName = default;
            Optional<string> dataFeedDescription = default;
            Optional<string> timestampColumn = default;
            Optional<DateTimeOffset> dataStartFrom = default;
            Optional<long> startOffsetInSeconds = default;
            Optional<int> maxConcurrency = default;
            Optional<long> minRetryIntervalInSeconds = default;
            Optional<long> stopRetryAfterInSeconds = default;
            Optional<DataFeedRollupType> needRollup = default;
            Optional<DataFeedAutoRollupMethod> rollUpMethod = default;
            Optional<IList<string>> rollUpColumns = default;
            Optional<string> allUpIdentification = default;
            Optional<DataFeedMissingDataPointFillType> fillMissingPointType = default;
            Optional<double> fillMissingPointValue = default;
            Optional<DataFeedAccessMode> viewMode = default;
            Optional<IList<string>> admins = default;
            Optional<IList<string>> viewers = default;
            Optional<DataFeedStatus> status = default;
            Optional<string> actionLinkTemplate = default;
            Optional<AuthenticationTypeEnum> authenticationType = default;
            Optional<string> credentialId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSourceParameter = SQLSourceParameterPatch.DeserializeSQLSourceParameterPatch(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceType"u8))
                {
                    dataSourceType = new DataFeedSourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFeedName"u8))
                {
                    dataFeedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedDescription"u8))
                {
                    dataFeedDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestampColumn"u8))
                {
                    timestampColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStartFrom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataStartFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startOffsetInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startOffsetInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxConcurrency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minRetryIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minRetryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("stopRetryAfterInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopRetryAfterInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("needRollup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    needRollup = new DataFeedRollupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollUpMethod = new DataFeedAutoRollupMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpColumns"u8))
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
                    rollUpColumns = array;
                    continue;
                }
                if (property.NameEquals("allUpIdentification"u8))
                {
                    allUpIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillMissingPointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointType = new DataFeedMissingDataPointFillType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fillMissingPointValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("viewMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    viewMode = new DataFeedAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("admins"u8))
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
                    admins = array;
                    continue;
                }
                if (property.NameEquals("viewers"u8))
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
                    viewers = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataFeedStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("actionLinkTemplate"u8))
                {
                    actionLinkTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new AuthenticationTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentialId"u8))
                {
                    credentialId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureDataExplorerDataFeedPatch(dataSourceType, dataFeedName.Value, dataFeedDescription.Value, timestampColumn.Value, Optional.ToNullable(dataStartFrom), Optional.ToNullable(startOffsetInSeconds), Optional.ToNullable(maxConcurrency), Optional.ToNullable(minRetryIntervalInSeconds), Optional.ToNullable(stopRetryAfterInSeconds), Optional.ToNullable(needRollup), Optional.ToNullable(rollUpMethod), Optional.ToList(rollUpColumns), allUpIdentification.Value, Optional.ToNullable(fillMissingPointType), Optional.ToNullable(fillMissingPointValue), Optional.ToNullable(viewMode), Optional.ToList(admins), Optional.ToList(viewers), Optional.ToNullable(status), actionLinkTemplate.Value, Optional.ToNullable(authenticationType), credentialId.Value, dataSourceParameter.Value, rawData);
        }

        AzureDataExplorerDataFeedPatch IModelJsonSerializable<AzureDataExplorerDataFeedPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataExplorerDataFeedPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDataExplorerDataFeedPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureDataExplorerDataFeedPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataExplorerDataFeedPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureDataExplorerDataFeedPatch IModelSerializable<AzureDataExplorerDataFeedPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataExplorerDataFeedPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureDataExplorerDataFeedPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureDataExplorerDataFeedPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureDataExplorerDataFeedPatch"/> to convert. </param>
        public static implicit operator RequestContent(AzureDataExplorerDataFeedPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureDataExplorerDataFeedPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureDataExplorerDataFeedPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureDataExplorerDataFeedPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
