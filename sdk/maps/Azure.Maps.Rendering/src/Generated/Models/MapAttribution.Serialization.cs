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

namespace Azure.Maps.Rendering
{
    internal partial class MapAttribution : IUtf8JsonSerializable, IModelJsonSerializable<MapAttribution>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MapAttribution>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MapAttribution>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapAttribution>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Copyrights))
            {
                writer.WritePropertyName("copyrights"u8);
                writer.WriteStartArray();
                foreach (var item in Copyrights)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static MapAttribution DeserializeMapAttribution(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> copyrights = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyrights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    copyrights = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MapAttribution(Optional.ToList(copyrights), serializedAdditionalRawData);
        }

        MapAttribution IModelJsonSerializable<MapAttribution>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapAttribution>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMapAttribution(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MapAttribution>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapAttribution>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MapAttribution IModelSerializable<MapAttribution>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapAttribution>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMapAttribution(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MapAttribution"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MapAttribution"/> to convert. </param>
        public static implicit operator RequestContent(MapAttribution model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MapAttribution"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MapAttribution(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMapAttribution(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
