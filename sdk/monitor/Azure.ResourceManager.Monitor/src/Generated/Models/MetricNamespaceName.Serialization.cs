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
    internal partial class MetricNamespaceName : IUtf8JsonSerializable, IModelJsonSerializable<MetricNamespaceName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetricNamespaceName>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetricNamespaceName>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricNamespaceName>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MetricNamespaceNameValue))
            {
                writer.WritePropertyName("metricNamespaceName"u8);
                writer.WriteStringValue(MetricNamespaceNameValue);
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

        internal static MetricNamespaceName DeserializeMetricNamespaceName(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metricNamespaceName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricNamespaceName"u8))
                {
                    metricNamespaceName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MetricNamespaceName(metricNamespaceName.Value, rawData);
        }

        MetricNamespaceName IModelJsonSerializable<MetricNamespaceName>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricNamespaceName>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricNamespaceName(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetricNamespaceName>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricNamespaceName>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetricNamespaceName IModelSerializable<MetricNamespaceName>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricNamespaceName>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetricNamespaceName(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MetricNamespaceName"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MetricNamespaceName"/> to convert. </param>
        public static implicit operator RequestContent(MetricNamespaceName model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MetricNamespaceName"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MetricNamespaceName(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetricNamespaceName(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
