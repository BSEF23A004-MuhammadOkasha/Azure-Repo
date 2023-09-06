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
    public partial class ConditionFailingPeriods : IUtf8JsonSerializable, IModelJsonSerializable<ConditionFailingPeriods>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConditionFailingPeriods>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConditionFailingPeriods>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConditionFailingPeriods>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NumberOfEvaluationPeriods))
            {
                writer.WritePropertyName("numberOfEvaluationPeriods"u8);
                writer.WriteNumberValue(NumberOfEvaluationPeriods.Value);
            }
            if (Optional.IsDefined(MinFailingPeriodsToAlert))
            {
                writer.WritePropertyName("minFailingPeriodsToAlert"u8);
                writer.WriteNumberValue(MinFailingPeriodsToAlert.Value);
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

        internal static ConditionFailingPeriods DeserializeConditionFailingPeriods(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> numberOfEvaluationPeriods = default;
            Optional<long> minFailingPeriodsToAlert = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfEvaluationPeriods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfEvaluationPeriods = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minFailingPeriodsToAlert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minFailingPeriodsToAlert = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConditionFailingPeriods(Optional.ToNullable(numberOfEvaluationPeriods), Optional.ToNullable(minFailingPeriodsToAlert), rawData);
        }

        ConditionFailingPeriods IModelJsonSerializable<ConditionFailingPeriods>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConditionFailingPeriods>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConditionFailingPeriods(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConditionFailingPeriods>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConditionFailingPeriods>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConditionFailingPeriods IModelSerializable<ConditionFailingPeriods>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConditionFailingPeriods>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConditionFailingPeriods(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConditionFailingPeriods"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConditionFailingPeriods"/> to convert. </param>
        public static implicit operator RequestContent(ConditionFailingPeriods model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConditionFailingPeriods"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConditionFailingPeriods(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConditionFailingPeriods(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
