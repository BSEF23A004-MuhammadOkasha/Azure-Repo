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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeShippingAddress : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeShippingAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeShippingAddress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeShippingAddress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AddressLine1))
            {
                writer.WritePropertyName("addressLine1"u8);
                writer.WriteStringValue(AddressLine1);
            }
            if (Optional.IsDefined(AddressLine2))
            {
                writer.WritePropertyName("addressLine2"u8);
                writer.WriteStringValue(AddressLine2);
            }
            if (Optional.IsDefined(AddressLine3))
            {
                writer.WritePropertyName("addressLine3"u8);
                writer.WriteStringValue(AddressLine3);
            }
            if (Optional.IsDefined(PostalCode))
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
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

        internal static DataBoxEdgeShippingAddress DeserializeDataBoxEdgeShippingAddress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addressLine1 = default;
            Optional<string> addressLine2 = default;
            Optional<string> addressLine3 = default;
            Optional<string> postalCode = default;
            Optional<string> city = default;
            Optional<string> state = default;
            string country = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressLine1"u8))
                {
                    addressLine1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressLine2"u8))
                {
                    addressLine2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressLine3"u8))
                {
                    addressLine3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxEdgeShippingAddress(addressLine1.Value, addressLine2.Value, addressLine3.Value, postalCode.Value, city.Value, state.Value, country, rawData);
        }

        DataBoxEdgeShippingAddress IModelJsonSerializable<DataBoxEdgeShippingAddress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeShippingAddress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeShippingAddress>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeShippingAddress IModelSerializable<DataBoxEdgeShippingAddress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeShippingAddress(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataBoxEdgeShippingAddress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataBoxEdgeShippingAddress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeShippingAddress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
