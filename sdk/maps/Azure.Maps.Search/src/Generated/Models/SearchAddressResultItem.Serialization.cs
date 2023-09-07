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
using Azure.Maps.Search;

namespace Azure.Maps.Search.Models
{
    public partial class SearchAddressResultItem : IUtf8JsonSerializable, IModelJsonSerializable<SearchAddressResultItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchAddressResultItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchAddressResultItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressResultItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType.Value.ToString());
            }
            if (Optional.IsDefined(PositionInternal))
            {
                writer.WritePropertyName("position"u8);
                if (PositionInternal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LatLongPairAbbreviated>)PositionInternal).Serialize(writer, options);
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

        internal static SearchAddressResultItem DeserializeSearchAddressResultItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SearchAddressResultType> type = default;
            Optional<string> id = default;
            Optional<double> score = default;
            Optional<double> dist = default;
            Optional<string> info = default;
            Optional<GeographicEntity> entityType = default;
            Optional<PointOfInterest> poi = default;
            Optional<MapsAddress> address = default;
            Optional<LatLongPairAbbreviated> position = default;
            Optional<BoundingBox> viewport = default;
            Optional<IReadOnlyList<FacilityEntryPoint>> entryPoints = default;
            Optional<AddressRanges> addressRanges = default;
            Optional<MapsDataSource> dataSources = default;
            Optional<MapsSearchMatchType> matchType = default;
            Optional<int> detourTime = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SearchAddressResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("score"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    score = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dist"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dist = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("info"u8))
                {
                    info = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    entityType = new GeographicEntity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("poi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    poi = PointOfInterest.DeserializePointOfInterest(property.Value);
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    address = MapsAddress.DeserializeMapsAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    position = LatLongPairAbbreviated.DeserializeLatLongPairAbbreviated(property.Value);
                    continue;
                }
                if (property.NameEquals("viewport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    viewport = BoundingBox.DeserializeBoundingBox(property.Value);
                    continue;
                }
                if (property.NameEquals("entryPoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FacilityEntryPoint> array = new List<FacilityEntryPoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FacilityEntryPoint.DeserializeFacilityEntryPoint(item));
                    }
                    entryPoints = array;
                    continue;
                }
                if (property.NameEquals("addressRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressRanges = AddressRanges.DeserializeAddressRanges(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSources = MapsDataSource.DeserializeMapsDataSource(property.Value);
                    continue;
                }
                if (property.NameEquals("matchType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchType = new MapsSearchMatchType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("detourTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detourTime = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchAddressResultItem(Optional.ToNullable(type), id.Value, Optional.ToNullable(score), Optional.ToNullable(dist), info.Value, Optional.ToNullable(entityType), poi.Value, address.Value, position.Value, viewport.Value, Optional.ToList(entryPoints), addressRanges.Value, dataSources.Value, Optional.ToNullable(matchType), Optional.ToNullable(detourTime), serializedAdditionalRawData);
        }

        SearchAddressResultItem IModelJsonSerializable<SearchAddressResultItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressResultItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchAddressResultItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchAddressResultItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressResultItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchAddressResultItem IModelSerializable<SearchAddressResultItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressResultItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchAddressResultItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchAddressResultItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchAddressResultItem"/> to convert. </param>
        public static implicit operator RequestContent(SearchAddressResultItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchAddressResultItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchAddressResultItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchAddressResultItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
