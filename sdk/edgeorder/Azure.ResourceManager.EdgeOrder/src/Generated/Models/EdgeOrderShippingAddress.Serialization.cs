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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderShippingAddress : IUtf8JsonSerializable, IModelJsonSerializable<EdgeOrderShippingAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeOrderShippingAddress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeOrderShippingAddress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderShippingAddress>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("streetAddress1"u8);
            writer.WriteStringValue(StreetAddress1);
            if (Optional.IsDefined(StreetAddress2))
            {
                writer.WritePropertyName("streetAddress2"u8);
                writer.WriteStringValue(StreetAddress2);
            }
            if (Optional.IsDefined(StreetAddress3))
            {
                writer.WritePropertyName("streetAddress3"u8);
                writer.WriteStringValue(StreetAddress3);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(StateOrProvince))
            {
                writer.WritePropertyName("stateOrProvince"u8);
                writer.WriteStringValue(StateOrProvince);
            }
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            if (Optional.IsDefined(PostalCode))
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (Optional.IsDefined(ZipExtendedCode))
            {
                writer.WritePropertyName("zipExtendedCode"u8);
                writer.WriteStringValue(ZipExtendedCode);
            }
            if (Optional.IsDefined(CompanyName))
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
            }
            if (Optional.IsDefined(AddressType))
            {
                writer.WritePropertyName("addressType"u8);
                writer.WriteStringValue(AddressType.Value.ToString());
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static EdgeOrderShippingAddress DeserializeEdgeOrderShippingAddress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string streetAddress1 = default;
            Optional<string> streetAddress2 = default;
            Optional<string> streetAddress3 = default;
            Optional<string> city = default;
            Optional<string> stateOrProvince = default;
            string country = default;
            Optional<string> postalCode = default;
            Optional<string> zipExtendedCode = default;
            Optional<string> companyName = default;
            Optional<EdgeOrderAddressType> addressType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streetAddress1"u8))
                {
                    streetAddress1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress2"u8))
                {
                    streetAddress2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress3"u8))
                {
                    streetAddress3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateOrProvince"u8))
                {
                    stateOrProvince = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zipExtendedCode"u8))
                {
                    zipExtendedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressType = new EdgeOrderAddressType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdgeOrderShippingAddress(streetAddress1, streetAddress2.Value, streetAddress3.Value, city.Value, stateOrProvince.Value, country, postalCode.Value, zipExtendedCode.Value, companyName.Value, Optional.ToNullable(addressType), rawData);
        }

        EdgeOrderShippingAddress IModelJsonSerializable<EdgeOrderShippingAddress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderShippingAddress>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderShippingAddress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeOrderShippingAddress>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderShippingAddress>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeOrderShippingAddress IModelSerializable<EdgeOrderShippingAddress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderShippingAddress>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeOrderShippingAddress(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdgeOrderShippingAddress"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdgeOrderShippingAddress"/> to convert. </param>
        public static implicit operator RequestContent(EdgeOrderShippingAddress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdgeOrderShippingAddress"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdgeOrderShippingAddress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeOrderShippingAddress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
