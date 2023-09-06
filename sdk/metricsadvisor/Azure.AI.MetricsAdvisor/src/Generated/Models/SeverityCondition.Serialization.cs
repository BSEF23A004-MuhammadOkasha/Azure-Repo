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
    public partial class SeverityCondition : IUtf8JsonSerializable, IModelJsonSerializable<SeverityCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SeverityCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SeverityCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SeverityCondition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("minAlertSeverity"u8);
            writer.WriteStringValue(MinimumAlertSeverity.ToString());
            writer.WritePropertyName("maxAlertSeverity"u8);
            writer.WriteStringValue(MaximumAlertSeverity.ToString());
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

        internal static SeverityCondition DeserializeSeverityCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AnomalySeverity minAlertSeverity = default;
            AnomalySeverity maxAlertSeverity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minAlertSeverity"u8))
                {
                    minAlertSeverity = new AnomalySeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxAlertSeverity"u8))
                {
                    maxAlertSeverity = new AnomalySeverity(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SeverityCondition(minAlertSeverity, maxAlertSeverity, rawData);
        }

        SeverityCondition IModelJsonSerializable<SeverityCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SeverityCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSeverityCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SeverityCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SeverityCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SeverityCondition IModelSerializable<SeverityCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SeverityCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSeverityCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SeverityCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SeverityCondition"/> to convert. </param>
        public static implicit operator RequestContent(SeverityCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SeverityCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SeverityCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSeverityCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
