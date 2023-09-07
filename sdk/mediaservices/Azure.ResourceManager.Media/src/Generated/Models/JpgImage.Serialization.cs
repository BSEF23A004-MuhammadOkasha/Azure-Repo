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
    public partial class JpgImage : IUtf8JsonSerializable, IModelJsonSerializable<JpgImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JpgImage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JpgImage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JpgImage>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<JpgLayer>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SpriteColumn))
            {
                writer.WritePropertyName("spriteColumn"u8);
                writer.WriteNumberValue(SpriteColumn.Value);
            }
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(Start);
            if (Optional.IsDefined(Step))
            {
                writer.WritePropertyName("step"u8);
                writer.WriteStringValue(Step);
            }
            if (Optional.IsDefined(Range))
            {
                writer.WritePropertyName("range"u8);
                writer.WriteStringValue(Range);
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                writer.WritePropertyName("keyFrameInterval"u8);
                writer.WriteStringValue(KeyFrameInterval.Value, "P");
            }
            if (Optional.IsDefined(StretchMode))
            {
                writer.WritePropertyName("stretchMode"u8);
                writer.WriteStringValue(StretchMode.Value.ToString());
            }
            if (Optional.IsDefined(SyncMode))
            {
                writer.WritePropertyName("syncMode"u8);
                writer.WriteStringValue(SyncMode.Value.ToString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        internal static JpgImage DeserializeJpgImage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<JpgLayer>> layers = default;
            Optional<int> spriteColumn = default;
            string start = default;
            Optional<string> step = default;
            Optional<string> range = default;
            Optional<TimeSpan> keyFrameInterval = default;
            Optional<InputVideoStretchMode> stretchMode = default;
            Optional<VideoSyncMode> syncMode = default;
            string odataType = default;
            Optional<string> label = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JpgLayer> array = new List<JpgLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JpgLayer.DeserializeJpgLayer(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("spriteColumn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spriteColumn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("step"u8))
                {
                    step = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("range"u8))
                {
                    range = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stretchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncMode = new VideoSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JpgImage(odataType, label.Value, Optional.ToNullable(keyFrameInterval), Optional.ToNullable(stretchMode), Optional.ToNullable(syncMode), start, step.Value, range.Value, Optional.ToList(layers), Optional.ToNullable(spriteColumn), serializedAdditionalRawData);
        }

        JpgImage IModelJsonSerializable<JpgImage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JpgImage>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJpgImage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JpgImage>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JpgImage>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JpgImage IModelSerializable<JpgImage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JpgImage>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJpgImage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JpgImage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JpgImage"/> to convert. </param>
        public static implicit operator RequestContent(JpgImage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JpgImage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JpgImage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJpgImage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
