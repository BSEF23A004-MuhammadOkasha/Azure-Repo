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

namespace Azure.Monitor.Query.Models
{
    public partial class MetricsQueryResult : IUtf8JsonSerializable, IJsonModel<MetricsQueryResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricsQueryResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MetricsQueryResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MetricsQueryResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MetricsQueryResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cost))
            {
                writer.WritePropertyName("cost"u8);
                writer.WriteNumberValue(Cost.Value);
            }
            writer.WritePropertyName("timespan"u8);
            writer.WriteStringValue(_timespan);
            if (Optional.IsDefined(Granularity))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteStringValue(Granularity.Value, "P");
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ResourceRegion))
            {
                writer.WritePropertyName("resourceregion"u8);
                writer.WriteStringValue(ResourceRegion);
            }
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Metrics)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        MetricsQueryResult IJsonModel<MetricsQueryResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricsQueryResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricsQueryResult(document.RootElement, options);
        }

        internal static MetricsQueryResult DeserializeMetricsQueryResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> cost = default;
            string timespan = default;
            Optional<TimeSpan> interval = default;
            Optional<string> @namespace = default;
            Optional<string> resourceregion = default;
            IReadOnlyList<MetricResult> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timespan"u8))
                {
                    timespan = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceregion"u8))
                {
                    resourceregion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<MetricResult> array = new List<MetricResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricResult.DeserializeMetricResult(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricsQueryResult(Optional.ToNullable(cost), timespan, Optional.ToNullable(interval), @namespace.Value, resourceregion.Value, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricsQueryResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricsQueryResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MetricsQueryResult IPersistableModel<MetricsQueryResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricsQueryResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMetricsQueryResult(document.RootElement, options);
        }

        string IPersistableModel<MetricsQueryResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
