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
    public partial class ReverseSearchAddressItem : IUtf8JsonSerializable, IModelJsonSerializable<ReverseSearchAddressItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReverseSearchAddressItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReverseSearchAddressItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchAddressItem>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ReverseSearchAddressItem DeserializeReverseSearchAddressItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MapsAddress> address = default;
            Optional<string> position = default;
            Optional<IReadOnlyList<RoadKind>> roadUse = default;
            Optional<MapsSearchMatchType> matchType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    position = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roadUse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoadKind> array = new List<RoadKind>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RoadKind(item.GetString()));
                    }
                    roadUse = array;
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReverseSearchAddressItem(address.Value, position.Value, Optional.ToList(roadUse), Optional.ToNullable(matchType), serializedAdditionalRawData);
        }

        ReverseSearchAddressItem IModelJsonSerializable<ReverseSearchAddressItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchAddressItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseSearchAddressItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReverseSearchAddressItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchAddressItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReverseSearchAddressItem IModelSerializable<ReverseSearchAddressItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchAddressItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReverseSearchAddressItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReverseSearchAddressItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReverseSearchAddressItem"/> to convert. </param>
        public static implicit operator RequestContent(ReverseSearchAddressItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReverseSearchAddressItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReverseSearchAddressItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReverseSearchAddressItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
