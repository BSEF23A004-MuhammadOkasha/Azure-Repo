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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleSchedule : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightAutoScaleSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightAutoScaleSchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightAutoScaleSchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightAutoScaleSchedule>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Days))
            {
                writer.WritePropertyName("days"u8);
                writer.WriteStartArray();
                foreach (var item in Days)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimeAndCapacity))
            {
                writer.WritePropertyName("timeAndCapacity"u8);
                if (TimeAndCapacity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HDInsightAutoScaleTimeAndCapacity>)TimeAndCapacity).Serialize(writer, options);
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

        internal static HDInsightAutoScaleSchedule DeserializeHDInsightAutoScaleSchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<HDInsightDayOfWeek>> days = default;
            Optional<HDInsightAutoScaleTimeAndCapacity> timeAndCapacity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("days"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightDayOfWeek> array = new List<HDInsightDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new HDInsightDayOfWeek(item.GetString()));
                    }
                    days = array;
                    continue;
                }
                if (property.NameEquals("timeAndCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeAndCapacity = HDInsightAutoScaleTimeAndCapacity.DeserializeHDInsightAutoScaleTimeAndCapacity(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightAutoScaleSchedule(Optional.ToList(days), timeAndCapacity.Value, rawData);
        }

        HDInsightAutoScaleSchedule IModelJsonSerializable<HDInsightAutoScaleSchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightAutoScaleSchedule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAutoScaleSchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightAutoScaleSchedule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightAutoScaleSchedule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightAutoScaleSchedule IModelSerializable<HDInsightAutoScaleSchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightAutoScaleSchedule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightAutoScaleSchedule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightAutoScaleSchedule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightAutoScaleSchedule"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightAutoScaleSchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightAutoScaleSchedule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightAutoScaleSchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightAutoScaleSchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
