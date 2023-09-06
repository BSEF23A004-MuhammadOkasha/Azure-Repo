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
    internal partial class AnomalyDimensionQuery : IUtf8JsonSerializable, IModelJsonSerializable<AnomalyDimensionQuery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnomalyDimensionQuery>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnomalyDimensionQuery>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnomalyDimensionQuery>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndTime, "O");
            writer.WritePropertyName("dimensionName"u8);
            writer.WriteStringValue(DimensionName);
            if (Optional.IsDefined(DimensionFilter))
            {
                writer.WritePropertyName("dimensionFilter"u8);
                if (DimensionFilter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DimensionKey>)DimensionFilter).Serialize(writer, options);
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

        internal static AnomalyDimensionQuery DeserializeAnomalyDimensionQuery(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            string dimensionName = default;
            Optional<DimensionKey> dimensionFilter = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dimensionFilter = DimensionKey.DeserializeDimensionKey(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AnomalyDimensionQuery(startTime, endTime, dimensionName, dimensionFilter.Value, rawData);
        }

        AnomalyDimensionQuery IModelJsonSerializable<AnomalyDimensionQuery>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnomalyDimensionQuery>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnomalyDimensionQuery(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnomalyDimensionQuery>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnomalyDimensionQuery>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnomalyDimensionQuery IModelSerializable<AnomalyDimensionQuery>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnomalyDimensionQuery>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnomalyDimensionQuery(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AnomalyDimensionQuery"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AnomalyDimensionQuery"/> to convert. </param>
        public static implicit operator RequestContent(AnomalyDimensionQuery model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AnomalyDimensionQuery"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AnomalyDimensionQuery(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnomalyDimensionQuery(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
