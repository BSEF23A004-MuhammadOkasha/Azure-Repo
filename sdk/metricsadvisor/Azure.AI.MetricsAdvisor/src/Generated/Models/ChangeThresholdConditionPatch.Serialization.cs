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
    internal partial class ChangeThresholdConditionPatch : IUtf8JsonSerializable, IModelJsonSerializable<ChangeThresholdConditionPatch>
    {
        void IModelJsonSerializable<ChangeThresholdConditionPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ChangeThresholdConditionPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ChangePercentage))
            {
                writer.WritePropertyName("changePercentage"u8);
                writer.WriteNumberValue(ChangePercentage.Value);
            }
            if (Optional.IsDefined(ShiftPoint))
            {
                writer.WritePropertyName("shiftPoint"u8);
                writer.WriteNumberValue(ShiftPoint.Value);
            }
            if (Optional.IsDefined(WithinRange))
            {
                writer.WritePropertyName("withinRange"u8);
                writer.WriteBooleanValue(WithinRange.Value);
            }
            if (Optional.IsDefined(AnomalyDetectorDirection))
            {
                writer.WritePropertyName("anomalyDetectorDirection"u8);
                writer.WriteStringValue(AnomalyDetectorDirection.Value.ToString());
            }
            if (Optional.IsDefined(SuppressCondition))
            {
                writer.WritePropertyName("suppressCondition"u8);
                if (SuppressCondition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SuppressConditionPatch>)SuppressCondition).Serialize(writer, options);
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

        internal static ChangeThresholdConditionPatch DeserializeChangeThresholdConditionPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> changePercentage = default;
            Optional<int> shiftPoint = default;
            Optional<bool> withinRange = default;
            Optional<AnomalyDetectorDirection> anomalyDetectorDirection = default;
            Optional<SuppressConditionPatch> suppressCondition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("shiftPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shiftPoint = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("withinRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    withinRange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("anomalyDetectorDirection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    anomalyDetectorDirection = new AnomalyDetectorDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suppressCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suppressCondition = SuppressConditionPatch.DeserializeSuppressConditionPatch(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ChangeThresholdConditionPatch(Optional.ToNullable(changePercentage), Optional.ToNullable(shiftPoint), Optional.ToNullable(withinRange), Optional.ToNullable(anomalyDetectorDirection), suppressCondition.Value, rawData);
        }

        ChangeThresholdConditionPatch IModelJsonSerializable<ChangeThresholdConditionPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ChangeThresholdConditionPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeChangeThresholdConditionPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ChangeThresholdConditionPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ChangeThresholdConditionPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ChangeThresholdConditionPatch IModelSerializable<ChangeThresholdConditionPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ChangeThresholdConditionPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeChangeThresholdConditionPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ChangeThresholdConditionPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ChangeThresholdConditionPatch"/> to convert. </param>
        public static implicit operator RequestContent(ChangeThresholdConditionPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ChangeThresholdConditionPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ChangeThresholdConditionPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeChangeThresholdConditionPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
