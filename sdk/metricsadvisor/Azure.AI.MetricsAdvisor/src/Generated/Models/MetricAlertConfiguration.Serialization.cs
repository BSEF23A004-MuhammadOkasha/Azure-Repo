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
    public partial class MetricAlertConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<MetricAlertConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetricAlertConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetricAlertConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricAlertConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("anomalyDetectionConfigurationId"u8);
            writer.WriteStringValue(DetectionConfigurationId);
            writer.WritePropertyName("anomalyScopeType"u8);
            writer.WriteStringValue(AnomalyScopeType.ToString());
            if (Optional.IsDefined(UseDetectionResultToFilterAnomalies))
            {
                writer.WritePropertyName("negationOperation"u8);
                writer.WriteBooleanValue(UseDetectionResultToFilterAnomalies.Value);
            }
            if (Optional.IsDefined(DimensionAnomalyScope))
            {
                writer.WritePropertyName("dimensionAnomalyScope"u8);
                if (DimensionAnomalyScope is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DimensionKey>)DimensionAnomalyScope).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TopNAnomalyScope))
            {
                writer.WritePropertyName("topNAnomalyScope"u8);
                if (TopNAnomalyScope is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TopNGroupScope>)TopNAnomalyScope).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SeverityFilter))
            {
                writer.WritePropertyName("severityFilter"u8);
                if (SeverityFilter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SeverityCondition>)SeverityFilter).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AlertSnoozeCondition))
            {
                writer.WritePropertyName("snoozeFilter"u8);
                if (AlertSnoozeCondition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MetricAnomalyAlertSnoozeCondition>)AlertSnoozeCondition).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ValueFilter))
            {
                writer.WritePropertyName("valueFilter"u8);
                if (ValueFilter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MetricBoundaryCondition>)ValueFilter).Serialize(writer, options);
                }
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

        internal static MetricAlertConfiguration DeserializeMetricAlertConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string anomalyDetectionConfigurationId = default;
            MetricAnomalyAlertScopeType anomalyScopeType = default;
            Optional<bool> negationOperation = default;
            Optional<DimensionKey> dimensionAnomalyScope = default;
            Optional<TopNGroupScope> topNAnomalyScope = default;
            Optional<SeverityCondition> severityFilter = default;
            Optional<MetricAnomalyAlertSnoozeCondition> snoozeFilter = default;
            Optional<MetricBoundaryCondition> valueFilter = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anomalyDetectionConfigurationId"u8))
                {
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anomalyScopeType"u8))
                {
                    anomalyScopeType = new MetricAnomalyAlertScopeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negationOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negationOperation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dimensionAnomalyScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dimensionAnomalyScope = DimensionKey.DeserializeDimensionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("topNAnomalyScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topNAnomalyScope = TopNGroupScope.DeserializeTopNGroupScope(property.Value);
                    continue;
                }
                if (property.NameEquals("severityFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severityFilter = SeverityCondition.DeserializeSeverityCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("snoozeFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snoozeFilter = MetricAnomalyAlertSnoozeCondition.DeserializeMetricAnomalyAlertSnoozeCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("valueFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFilter = MetricBoundaryCondition.DeserializeMetricBoundaryCondition(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MetricAlertConfiguration(anomalyDetectionConfigurationId, anomalyScopeType, Optional.ToNullable(negationOperation), dimensionAnomalyScope.Value, topNAnomalyScope.Value, severityFilter.Value, snoozeFilter.Value, valueFilter.Value, rawData);
        }

        MetricAlertConfiguration IModelJsonSerializable<MetricAlertConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricAlertConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricAlertConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetricAlertConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricAlertConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetricAlertConfiguration IModelSerializable<MetricAlertConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricAlertConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetricAlertConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MetricAlertConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MetricAlertConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(MetricAlertConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MetricAlertConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MetricAlertConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetricAlertConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
