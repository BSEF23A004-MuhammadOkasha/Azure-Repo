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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsUsageMetric : IUtf8JsonSerializable, IModelJsonSerializable<OperationalInsightsUsageMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OperationalInsightsUsageMetric>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OperationalInsightsUsageMetric>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsUsageMetric>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                if (Name is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OperationalInsightsMetricName>)Name).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(CurrentValue))
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteNumberValue(CurrentValue.Value);
            }
            if (Optional.IsDefined(Limit))
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (Optional.IsDefined(NextResetOn))
            {
                writer.WritePropertyName("nextResetTime"u8);
                writer.WriteStringValue(NextResetOn.Value, "O");
            }
            if (Optional.IsDefined(QuotaPeriod))
            {
                writer.WritePropertyName("quotaPeriod"u8);
                writer.WriteStringValue(QuotaPeriod);
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

        internal static OperationalInsightsUsageMetric DeserializeOperationalInsightsUsageMetric(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OperationalInsightsMetricName> name = default;
            Optional<string> unit = default;
            Optional<double> currentValue = default;
            Optional<double> limit = default;
            Optional<DateTimeOffset> nextResetTime = default;
            Optional<string> quotaPeriod = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = OperationalInsightsMetricName.DeserializeOperationalInsightsMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("nextResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextResetTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("quotaPeriod"u8))
                {
                    quotaPeriod = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OperationalInsightsUsageMetric(name.Value, unit.Value, Optional.ToNullable(currentValue), Optional.ToNullable(limit), Optional.ToNullable(nextResetTime), quotaPeriod.Value, rawData);
        }

        OperationalInsightsUsageMetric IModelJsonSerializable<OperationalInsightsUsageMetric>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsUsageMetric>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsUsageMetric(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OperationalInsightsUsageMetric>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsUsageMetric>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OperationalInsightsUsageMetric IModelSerializable<OperationalInsightsUsageMetric>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsUsageMetric>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsUsageMetric(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OperationalInsightsUsageMetric"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OperationalInsightsUsageMetric"/> to convert. </param>
        public static implicit operator RequestContent(OperationalInsightsUsageMetric model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OperationalInsightsUsageMetric"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OperationalInsightsUsageMetric(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOperationalInsightsUsageMetric(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
