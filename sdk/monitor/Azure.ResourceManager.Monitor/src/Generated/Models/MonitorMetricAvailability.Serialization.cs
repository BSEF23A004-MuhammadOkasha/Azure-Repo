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
    public partial class MonitorMetricAvailability : IUtf8JsonSerializable, IModelJsonSerializable<MonitorMetricAvailability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorMetricAvailability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorMetricAvailability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetricAvailability>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeGrain))
            {
                writer.WritePropertyName("timeGrain"u8);
                writer.WriteStringValue(TimeGrain.Value, "P");
            }
            if (Optional.IsDefined(Retention))
            {
                writer.WritePropertyName("retention"u8);
                writer.WriteStringValue(Retention.Value, "P");
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

        internal static MonitorMetricAvailability DeserializeMonitorMetricAvailability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> timeGrain = default;
            Optional<TimeSpan> retention = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeGrain = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("retention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retention = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorMetricAvailability(Optional.ToNullable(timeGrain), Optional.ToNullable(retention), rawData);
        }

        MonitorMetricAvailability IModelJsonSerializable<MonitorMetricAvailability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetricAvailability>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorMetricAvailability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorMetricAvailability>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetricAvailability>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorMetricAvailability IModelSerializable<MonitorMetricAvailability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetricAvailability>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorMetricAvailability(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MonitorMetricAvailability"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MonitorMetricAvailability"/> to convert. </param>
        public static implicit operator RequestContent(MonitorMetricAvailability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MonitorMetricAvailability"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MonitorMetricAvailability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorMetricAvailability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
