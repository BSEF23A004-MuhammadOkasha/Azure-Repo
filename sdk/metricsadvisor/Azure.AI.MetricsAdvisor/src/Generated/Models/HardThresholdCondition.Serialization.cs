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
    public partial class HardThresholdCondition : IUtf8JsonSerializable, IModelJsonSerializable<HardThresholdCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HardThresholdCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HardThresholdCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardThresholdCondition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LowerBound))
            {
                writer.WritePropertyName("lowerBound"u8);
                writer.WriteNumberValue(LowerBound.Value);
            }
            if (Optional.IsDefined(UpperBound))
            {
                writer.WritePropertyName("upperBound"u8);
                writer.WriteNumberValue(UpperBound.Value);
            }
            writer.WritePropertyName("anomalyDetectorDirection"u8);
            writer.WriteStringValue(AnomalyDetectorDirection.ToString());
            writer.WritePropertyName("suppressCondition"u8);
            if (SuppressCondition is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SuppressCondition>)SuppressCondition).Serialize(writer, options);
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

        internal static HardThresholdCondition DeserializeHardThresholdCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> lowerBound = default;
            Optional<double> upperBound = default;
            AnomalyDetectorDirection anomalyDetectorDirection = default;
            SuppressCondition suppressCondition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowerBound = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upperBound = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("anomalyDetectorDirection"u8))
                {
                    anomalyDetectorDirection = new AnomalyDetectorDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suppressCondition"u8))
                {
                    suppressCondition = Models.SuppressCondition.DeserializeSuppressCondition(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HardThresholdCondition(Optional.ToNullable(lowerBound), Optional.ToNullable(upperBound), anomalyDetectorDirection, suppressCondition, rawData);
        }

        HardThresholdCondition IModelJsonSerializable<HardThresholdCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardThresholdCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHardThresholdCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HardThresholdCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardThresholdCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HardThresholdCondition IModelSerializable<HardThresholdCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardThresholdCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHardThresholdCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HardThresholdCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HardThresholdCondition"/> to convert. </param>
        public static implicit operator RequestContent(HardThresholdCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HardThresholdCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HardThresholdCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHardThresholdCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
