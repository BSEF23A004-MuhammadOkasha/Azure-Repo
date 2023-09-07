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
    internal partial class GeoJsonGeometryCollectionData : IUtf8JsonSerializable, IModelJsonSerializable<GeoJsonGeometryCollectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GeoJsonGeometryCollectionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GeoJsonGeometryCollectionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonGeometryCollectionData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("geometries"u8);
            writer.WriteStartArray();
            foreach (var item in Geometries)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GeoJsonGeometry>)item).Serialize(writer, options);
                }
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

        internal static GeoJsonGeometryCollectionData DeserializeGeoJsonGeometryCollectionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<GeoJsonGeometry> geometries = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("geometries"u8))
                {
                    List<GeoJsonGeometry> array = new List<GeoJsonGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoJsonGeometry.DeserializeGeoJsonGeometry(item));
                    }
                    geometries = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GeoJsonGeometryCollectionData(geometries, serializedAdditionalRawData);
        }

        GeoJsonGeometryCollectionData IModelJsonSerializable<GeoJsonGeometryCollectionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonGeometryCollectionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGeoJsonGeometryCollectionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GeoJsonGeometryCollectionData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonGeometryCollectionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GeoJsonGeometryCollectionData IModelSerializable<GeoJsonGeometryCollectionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonGeometryCollectionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGeoJsonGeometryCollectionData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GeoJsonGeometryCollectionData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GeoJsonGeometryCollectionData"/> to convert. </param>
        public static implicit operator RequestContent(GeoJsonGeometryCollectionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GeoJsonGeometryCollectionData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GeoJsonGeometryCollectionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGeoJsonGeometryCollectionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
