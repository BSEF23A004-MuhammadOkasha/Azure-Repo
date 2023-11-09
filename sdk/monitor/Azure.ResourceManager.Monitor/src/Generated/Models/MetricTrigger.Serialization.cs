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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricTrigger : IUtf8JsonSerializable, IJsonModel<MetricTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricTrigger>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MetricTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WritePropertyName("metricResourceUri"u8);
            writer.WriteStringValue(MetricResourceId);
            if (Optional.IsDefined(MetricResourceLocation))
            {
                writer.WritePropertyName("metricResourceLocation"u8);
                writer.WriteStringValue(MetricResourceLocation.Value);
            }
            writer.WritePropertyName("timeGrain"u8);
            writer.WriteStringValue(TimeGrain, "P");
            writer.WritePropertyName("statistic"u8);
            writer.WriteStringValue(Statistic.ToSerialString());
            writer.WritePropertyName("timeWindow"u8);
            writer.WriteStringValue(TimeWindow, "P");
            writer.WritePropertyName("timeAggregation"u8);
            writer.WriteStringValue(TimeAggregation.ToSerialString());
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToSerialString());
            writer.WritePropertyName("threshold"u8);
            writer.WriteNumberValue(Threshold);
            if (Optional.IsCollectionDefined(Dimensions))
            {
                if (Dimensions != null)
                {
                    writer.WritePropertyName("dimensions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Dimensions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("dimensions");
                }
            }
            if (Optional.IsDefined(IsDividedPerInstance))
            {
                writer.WritePropertyName("dividePerInstance"u8);
                writer.WriteBooleanValue(IsDividedPerInstance.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MetricTrigger IJsonModel<MetricTrigger>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricTrigger(document.RootElement, options);
        }

        internal static MetricTrigger DeserializeMetricTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricName = default;
            Optional<string> metricNamespace = default;
            ResourceIdentifier metricResourceUri = default;
            Optional<AzureLocation> metricResourceLocation = default;
            TimeSpan timeGrain = default;
            MetricStatisticType statistic = default;
            TimeSpan timeWindow = default;
            MetricTriggerTimeAggregationType timeAggregation = default;
            MetricTriggerComparisonOperation @operator = default;
            double threshold = default;
            Optional<IList<AutoscaleRuleMetricDimension>> dimensions = default;
            Optional<bool> dividePerInstance = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricResourceUri"u8))
                {
                    metricResourceUri = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricResourceLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metricResourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeGrain"u8))
                {
                    timeGrain = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("statistic"u8))
                {
                    statistic = property.Value.GetString().ToMetricStatisticType();
                    continue;
                }
                if (property.NameEquals("timeWindow"u8))
                {
                    timeWindow = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("timeAggregation"u8))
                {
                    timeAggregation = property.Value.GetString().ToMetricTriggerTimeAggregationType();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = property.Value.GetString().ToMetricTriggerComparisonOperation();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dimensions = null;
                        continue;
                    }
                    List<AutoscaleRuleMetricDimension> array = new List<AutoscaleRuleMetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutoscaleRuleMetricDimension.DeserializeAutoscaleRuleMetricDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("dividePerInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dividePerInstance = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricTrigger(metricName, metricNamespace.Value, metricResourceUri, Optional.ToNullable(metricResourceLocation), timeGrain, statistic, timeWindow, timeAggregation, @operator, threshold, Optional.ToList(dimensions), Optional.ToNullable(dividePerInstance), serializedAdditionalRawData);
        }

        BinaryData IModel<MetricTrigger>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricTrigger)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MetricTrigger IModel<MetricTrigger>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMetricTrigger(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MetricTrigger>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
