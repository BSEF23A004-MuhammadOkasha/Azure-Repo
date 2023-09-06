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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorTimeSeriesBaseline : IUtf8JsonSerializable, IModelJsonSerializable<MonitorTimeSeriesBaseline>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorTimeSeriesBaseline>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorTimeSeriesBaseline>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorTimeSeriesBaseline>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("aggregation"u8);
            writer.WriteStringValue(Aggregation);
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MonitorMetricSingleDimension>)item).Serialize(writer, options);
                    }
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
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MonitorSingleBaseline>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(MetadataValues))
            {
                writer.WritePropertyName("metadataValues"u8);
                writer.WriteStartArray();
                foreach (var item in MetadataValues)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MonitorBaselineMetadata>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static MonitorTimeSeriesBaseline DeserializeMonitorTimeSeriesBaseline(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aggregation = default;
            Optional<IReadOnlyList<MonitorMetricSingleDimension>> dimensions = default;
            IReadOnlyList<DateTimeOffset> timestamps = default;
            IReadOnlyList<MonitorSingleBaseline> data = default;
            Optional<IReadOnlyList<MonitorBaselineMetadata>> metadataValues = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorTimeSeriesBaseline(aggregation, Optional.ToList(dimensions), timestamps, data, Optional.ToList(metadataValues), rawData);
        }

        MonitorTimeSeriesBaseline IModelJsonSerializable<MonitorTimeSeriesBaseline>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorTimeSeriesBaseline>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorTimeSeriesBaseline(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorTimeSeriesBaseline>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorTimeSeriesBaseline>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorTimeSeriesBaseline IModelSerializable<MonitorTimeSeriesBaseline>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorTimeSeriesBaseline>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorTimeSeriesBaseline(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MonitorTimeSeriesBaseline"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MonitorTimeSeriesBaseline"/> to convert. </param>
        public static implicit operator RequestContent(MonitorTimeSeriesBaseline model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MonitorTimeSeriesBaseline"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MonitorTimeSeriesBaseline(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorTimeSeriesBaseline(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
