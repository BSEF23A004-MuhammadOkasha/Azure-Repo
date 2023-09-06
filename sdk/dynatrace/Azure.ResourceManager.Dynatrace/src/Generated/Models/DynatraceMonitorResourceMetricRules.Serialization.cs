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

namespace Azure.ResourceManager.Dynatrace.Models
{
    internal partial class DynatraceMonitorResourceMetricRules : IUtf8JsonSerializable, IModelJsonSerializable<DynatraceMonitorResourceMetricRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DynatraceMonitorResourceMetricRules>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DynatraceMonitorResourceMetricRules>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorResourceMetricRules>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DynatraceMonitorResourceFilteringTag>)item).Serialize(writer, options);
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

        internal static DynatraceMonitorResourceMetricRules DeserializeDynatraceMonitorResourceMetricRules(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DynatraceMonitorResourceFilteringTag>> filteringTags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DynatraceMonitorResourceFilteringTag> array = new List<DynatraceMonitorResourceFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DynatraceMonitorResourceFilteringTag.DeserializeDynatraceMonitorResourceFilteringTag(item));
                    }
                    filteringTags = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DynatraceMonitorResourceMetricRules(Optional.ToList(filteringTags), rawData);
        }

        DynatraceMonitorResourceMetricRules IModelJsonSerializable<DynatraceMonitorResourceMetricRules>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorResourceMetricRules>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceMonitorResourceMetricRules(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DynatraceMonitorResourceMetricRules>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorResourceMetricRules>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DynatraceMonitorResourceMetricRules IModelSerializable<DynatraceMonitorResourceMetricRules>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorResourceMetricRules>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDynatraceMonitorResourceMetricRules(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DynatraceMonitorResourceMetricRules"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DynatraceMonitorResourceMetricRules"/> to convert. </param>
        public static implicit operator RequestContent(DynatraceMonitorResourceMetricRules model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DynatraceMonitorResourceMetricRules"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DynatraceMonitorResourceMetricRules(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDynatraceMonitorResourceMetricRules(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
