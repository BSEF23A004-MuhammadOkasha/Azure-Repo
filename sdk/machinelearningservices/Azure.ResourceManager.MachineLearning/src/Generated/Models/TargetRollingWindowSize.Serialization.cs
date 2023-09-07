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
    public partial class TargetRollingWindowSize : IUtf8JsonSerializable, IModelJsonSerializable<TargetRollingWindowSize>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TargetRollingWindowSize>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TargetRollingWindowSize>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetRollingWindowSize>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
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

        internal static TargetRollingWindowSize DeserializeTargetRollingWindowSize(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mode", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Auto": return AutoTargetRollingWindowSize.DeserializeAutoTargetRollingWindowSize(element);
                    case "Custom": return CustomTargetRollingWindowSize.DeserializeCustomTargetRollingWindowSize(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            TargetRollingWindowSizeMode mode = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    mode = new TargetRollingWindowSizeMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownTargetRollingWindowSize(mode, serializedAdditionalRawData);
        }

        TargetRollingWindowSize IModelJsonSerializable<TargetRollingWindowSize>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetRollingWindowSize>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetRollingWindowSize(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TargetRollingWindowSize>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetRollingWindowSize>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TargetRollingWindowSize IModelSerializable<TargetRollingWindowSize>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetRollingWindowSize>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTargetRollingWindowSize(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TargetRollingWindowSize"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TargetRollingWindowSize"/> to convert. </param>
        public static implicit operator RequestContent(TargetRollingWindowSize model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TargetRollingWindowSize"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TargetRollingWindowSize(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTargetRollingWindowSize(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
