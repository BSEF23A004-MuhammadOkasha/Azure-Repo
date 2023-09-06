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

namespace Azure.ResourceManager.Network.Models
{
    public partial class HubRoute : IUtf8JsonSerializable, IModelJsonSerializable<HubRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HubRoute>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HubRoute>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubRoute>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("destinationType"u8);
            writer.WriteStringValue(DestinationType);
            writer.WritePropertyName("destinations"u8);
            writer.WriteStartArray();
            foreach (var item in Destinations)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("nextHopType"u8);
            writer.WriteStringValue(NextHopType);
            writer.WritePropertyName("nextHop"u8);
            writer.WriteStringValue(NextHop);
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

        internal static HubRoute DeserializeHubRoute(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string destinationType = default;
            IList<string> destinations = default;
            string nextHopType = default;
            string nextHop = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationType"u8))
                {
                    destinationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinations"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinations = array;
                    continue;
                }
                if (property.NameEquals("nextHopType"u8))
                {
                    nextHopType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHop"u8))
                {
                    nextHop = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HubRoute(name, destinationType, destinations, nextHopType, nextHop, rawData);
        }

        HubRoute IModelJsonSerializable<HubRoute>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubRoute>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHubRoute(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HubRoute>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubRoute>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HubRoute IModelSerializable<HubRoute>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubRoute>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHubRoute(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HubRoute"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HubRoute"/> to convert. </param>
        public static implicit operator RequestContent(HubRoute model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HubRoute"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HubRoute(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHubRoute(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
