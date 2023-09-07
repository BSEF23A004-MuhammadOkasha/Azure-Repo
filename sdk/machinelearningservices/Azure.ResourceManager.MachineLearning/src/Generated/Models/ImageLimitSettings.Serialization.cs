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
    public partial class ImageLimitSettings : IUtf8JsonSerializable, IModelJsonSerializable<ImageLimitSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ImageLimitSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ImageLimitSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageLimitSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxConcurrentTrials))
            {
                writer.WritePropertyName("maxConcurrentTrials"u8);
                writer.WriteNumberValue(MaxConcurrentTrials.Value);
            }
            if (Optional.IsDefined(MaxTrials))
            {
                writer.WritePropertyName("maxTrials"u8);
                writer.WriteNumberValue(MaxTrials.Value);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
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

        internal static ImageLimitSettings DeserializeImageLimitSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxConcurrentTrials = default;
            Optional<int> maxTrials = default;
            Optional<TimeSpan> timeout = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ImageLimitSettings(Optional.ToNullable(maxConcurrentTrials), Optional.ToNullable(maxTrials), Optional.ToNullable(timeout), serializedAdditionalRawData);
        }

        ImageLimitSettings IModelJsonSerializable<ImageLimitSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageLimitSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeImageLimitSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ImageLimitSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageLimitSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ImageLimitSettings IModelSerializable<ImageLimitSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageLimitSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeImageLimitSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ImageLimitSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ImageLimitSettings"/> to convert. </param>
        public static implicit operator RequestContent(ImageLimitSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ImageLimitSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ImageLimitSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeImageLimitSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
