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

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ScaleSettingsInformation : IUtf8JsonSerializable, IModelJsonSerializable<ScaleSettingsInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScaleSettingsInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScaleSettingsInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleSettingsInformation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings"u8);
                if (ScaleSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AmlComputeScaleSettings>)ScaleSettings).Serialize(writer, options);
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

        internal static ScaleSettingsInformation DeserializeScaleSettingsInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AmlComputeScaleSettings> scaleSettings = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleSettings = AmlComputeScaleSettings.DeserializeAmlComputeScaleSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScaleSettingsInformation(scaleSettings.Value, serializedAdditionalRawData);
        }

        ScaleSettingsInformation IModelJsonSerializable<ScaleSettingsInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleSettingsInformation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScaleSettingsInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScaleSettingsInformation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleSettingsInformation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScaleSettingsInformation IModelSerializable<ScaleSettingsInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleSettingsInformation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScaleSettingsInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScaleSettingsInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScaleSettingsInformation"/> to convert. </param>
        public static implicit operator RequestContent(ScaleSettingsInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScaleSettingsInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScaleSettingsInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScaleSettingsInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
