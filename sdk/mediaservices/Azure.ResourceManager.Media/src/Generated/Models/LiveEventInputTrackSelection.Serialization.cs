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

namespace Azure.ResourceManager.Media.Models
{
    public partial class LiveEventInputTrackSelection : IUtf8JsonSerializable, IModelJsonSerializable<LiveEventInputTrackSelection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LiveEventInputTrackSelection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LiveEventInputTrackSelection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveEventInputTrackSelection>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Property))
            {
                writer.WritePropertyName("property"u8);
                writer.WriteStringValue(Property);
            }
            if (Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
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

        internal static LiveEventInputTrackSelection DeserializeLiveEventInputTrackSelection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> property = default;
            Optional<string> operation = default;
            Optional<string> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"u8))
                {
                    property = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("operation"u8))
                {
                    operation = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("value"u8))
                {
                    value = property0.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                    continue;
                }
            }
            return new LiveEventInputTrackSelection(property.Value, operation.Value, value.Value, serializedAdditionalRawData);
        }

        LiveEventInputTrackSelection IModelJsonSerializable<LiveEventInputTrackSelection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveEventInputTrackSelection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLiveEventInputTrackSelection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LiveEventInputTrackSelection>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveEventInputTrackSelection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LiveEventInputTrackSelection IModelSerializable<LiveEventInputTrackSelection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LiveEventInputTrackSelection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLiveEventInputTrackSelection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LiveEventInputTrackSelection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LiveEventInputTrackSelection"/> to convert. </param>
        public static implicit operator RequestContent(LiveEventInputTrackSelection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LiveEventInputTrackSelection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LiveEventInputTrackSelection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLiveEventInputTrackSelection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
