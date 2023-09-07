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

namespace Azure.Maps.Search.Models
{
    public partial class OperatingHoursTimeRange : IUtf8JsonSerializable, IModelJsonSerializable<OperatingHoursTimeRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OperatingHoursTimeRange>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OperatingHoursTimeRange>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperatingHoursTimeRange>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RawStartTime))
            {
                writer.WritePropertyName("startTime"u8);
                if (RawStartTime is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OperatingHoursTime>)RawStartTime).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RawEndTime))
            {
                writer.WritePropertyName("endTime"u8);
                if (RawEndTime is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OperatingHoursTime>)RawEndTime).Serialize(writer, options);
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static OperatingHoursTimeRange DeserializeOperatingHoursTimeRange(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OperatingHoursTime> startTime = default;
            Optional<OperatingHoursTime> endTime = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = OperatingHoursTime.DeserializeOperatingHoursTime(property.Value);
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = OperatingHoursTime.DeserializeOperatingHoursTime(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OperatingHoursTimeRange(startTime.Value, endTime.Value, serializedAdditionalRawData);
        }

        OperatingHoursTimeRange IModelJsonSerializable<OperatingHoursTimeRange>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperatingHoursTimeRange>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOperatingHoursTimeRange(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OperatingHoursTimeRange>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperatingHoursTimeRange>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OperatingHoursTimeRange IModelSerializable<OperatingHoursTimeRange>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperatingHoursTimeRange>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOperatingHoursTimeRange(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OperatingHoursTimeRange"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OperatingHoursTimeRange"/> to convert. </param>
        public static implicit operator RequestContent(OperatingHoursTimeRange model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OperatingHoursTimeRange"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OperatingHoursTimeRange(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOperatingHoursTimeRange(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
