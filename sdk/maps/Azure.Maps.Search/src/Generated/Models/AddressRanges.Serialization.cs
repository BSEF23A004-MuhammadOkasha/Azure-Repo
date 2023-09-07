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
    public partial class AddressRanges : IUtf8JsonSerializable, IModelJsonSerializable<AddressRanges>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AddressRanges>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AddressRanges>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressRanges>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RangeLeft))
            {
                writer.WritePropertyName("rangeLeft"u8);
                writer.WriteStringValue(RangeLeft);
            }
            if (Optional.IsDefined(RangeRight))
            {
                writer.WritePropertyName("rangeRight"u8);
                writer.WriteStringValue(RangeRight);
            }
            if (Optional.IsDefined(FromInternal))
            {
                writer.WritePropertyName("from"u8);
                if (FromInternal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LatLongPairAbbreviated>)FromInternal).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ToInternal))
            {
                writer.WritePropertyName("to"u8);
                if (ToInternal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LatLongPairAbbreviated>)ToInternal).Serialize(writer, options);
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

        internal static AddressRanges DeserializeAddressRanges(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rangeLeft = default;
            Optional<string> rangeRight = default;
            Optional<LatLongPairAbbreviated> @from = default;
            Optional<LatLongPairAbbreviated> to = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rangeLeft"u8))
                {
                    rangeLeft = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rangeRight"u8))
                {
                    rangeRight = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @from = LatLongPairAbbreviated.DeserializeLatLongPairAbbreviated(property.Value);
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    to = LatLongPairAbbreviated.DeserializeLatLongPairAbbreviated(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AddressRanges(rangeLeft.Value, rangeRight.Value, @from.Value, to.Value, serializedAdditionalRawData);
        }

        AddressRanges IModelJsonSerializable<AddressRanges>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressRanges>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAddressRanges(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AddressRanges>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressRanges>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AddressRanges IModelSerializable<AddressRanges>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressRanges>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAddressRanges(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AddressRanges"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AddressRanges"/> to convert. </param>
        public static implicit operator RequestContent(AddressRanges model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AddressRanges"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AddressRanges(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAddressRanges(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
