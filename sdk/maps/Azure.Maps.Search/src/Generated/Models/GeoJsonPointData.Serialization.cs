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

namespace Azure.Maps.Search.Models
{
    public partial class GeoJsonPointData : IUtf8JsonSerializable, IModelJsonSerializable<GeoJsonPointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GeoJsonPointData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GeoJsonPointData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonPointData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("coordinates"u8);
            writer.WriteStartArray();
            foreach (var item in Coordinates)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
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

        internal static GeoJsonPointData DeserializeGeoJsonPointData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<double> coordinates = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    coordinates = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GeoJsonPointData(coordinates, serializedAdditionalRawData);
        }

        GeoJsonPointData IModelJsonSerializable<GeoJsonPointData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonPointData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGeoJsonPointData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GeoJsonPointData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonPointData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GeoJsonPointData IModelSerializable<GeoJsonPointData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonPointData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGeoJsonPointData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GeoJsonPointData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GeoJsonPointData"/> to convert. </param>
        public static implicit operator RequestContent(GeoJsonPointData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GeoJsonPointData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GeoJsonPointData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGeoJsonPointData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
