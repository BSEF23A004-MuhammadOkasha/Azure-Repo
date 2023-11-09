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
    public partial class MonitorTimeSeriesBaseline : IUtf8JsonSerializable, IJsonModel<MonitorTimeSeriesBaseline>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorTimeSeriesBaseline>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MonitorTimeSeriesBaseline>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("aggregation"u8);
            writer.WriteStringValue(Aggregation);
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("timestamps"u8);
            writer.WriteStartArray();
            foreach (var item in Timestamps)
            {
                writer.WriteStringValue(item, "O");
            }
            writer.WriteEndArray();
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(MetadataValues))
            {
                writer.WritePropertyName("metadataValues"u8);
                writer.WriteStartArray();
                foreach (var item in MetadataValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        MonitorTimeSeriesBaseline IJsonModel<MonitorTimeSeriesBaseline>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorTimeSeriesBaseline)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorTimeSeriesBaseline(document.RootElement, options);
        }

        internal static MonitorTimeSeriesBaseline DeserializeMonitorTimeSeriesBaseline(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aggregation = default;
            Optional<IReadOnlyList<MonitorMetricSingleDimension>> dimensions = default;
            IReadOnlyList<DateTimeOffset> timestamps = default;
            IReadOnlyList<MonitorSingleBaseline> data = default;
            Optional<IReadOnlyList<MonitorBaselineMetadata>> metadataValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"u8))
                {
                    aggregation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorMetricSingleDimension> array = new List<MonitorMetricSingleDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetricSingleDimension.DeserializeMonitorMetricSingleDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("timestamps"u8))
                {
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    timestamps = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<MonitorSingleBaseline> array = new List<MonitorSingleBaseline>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorSingleBaseline.DeserializeMonitorSingleBaseline(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("metadataValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorBaselineMetadata> array = new List<MonitorBaselineMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorBaselineMetadata.DeserializeMonitorBaselineMetadata(item));
                    }
                    metadataValues = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorTimeSeriesBaseline(aggregation, Optional.ToList(dimensions), timestamps, data, Optional.ToList(metadataValues), serializedAdditionalRawData);
        }

        BinaryData IModel<MonitorTimeSeriesBaseline>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorTimeSeriesBaseline)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MonitorTimeSeriesBaseline IModel<MonitorTimeSeriesBaseline>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorTimeSeriesBaseline)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMonitorTimeSeriesBaseline(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MonitorTimeSeriesBaseline>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
