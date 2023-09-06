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

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class HealthCheckStepProperties : IUtf8JsonSerializable, IModelJsonSerializable<HealthCheckStepProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthCheckStepProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthCheckStepProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthCheckStepProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("attributes"u8);
            if (Attributes is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<HealthCheckStepAttributes>)Attributes).Serialize(writer, options);
            }
            writer.WritePropertyName("stepType"u8);
            writer.WriteStringValue(StepType.ToSerialString());
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

        internal static HealthCheckStepProperties DeserializeHealthCheckStepProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthCheckStepAttributes attributes = default;
            StepType stepType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attributes"u8))
                {
                    attributes = HealthCheckStepAttributes.DeserializeHealthCheckStepAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("stepType"u8))
                {
                    stepType = property.Value.GetString().ToStepType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthCheckStepProperties(stepType, attributes, rawData);
        }

        HealthCheckStepProperties IModelJsonSerializable<HealthCheckStepProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthCheckStepProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthCheckStepProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthCheckStepProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthCheckStepProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthCheckStepProperties IModelSerializable<HealthCheckStepProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthCheckStepProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthCheckStepProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthCheckStepProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthCheckStepProperties"/> to convert. </param>
        public static implicit operator RequestContent(HealthCheckStepProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthCheckStepProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthCheckStepProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthCheckStepProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
