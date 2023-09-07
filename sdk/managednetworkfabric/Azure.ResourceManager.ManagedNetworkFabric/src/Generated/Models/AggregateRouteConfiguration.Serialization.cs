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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class AggregateRouteConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<AggregateRouteConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AggregateRouteConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AggregateRouteConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateRouteConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPv4Routes))
            {
                writer.WritePropertyName("ipv4Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4Routes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AggregateRoute>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6Routes))
            {
                writer.WritePropertyName("ipv6Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6Routes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AggregateRoute>)item).Serialize(writer, options);
                    }
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

        internal static AggregateRouteConfiguration DeserializeAggregateRouteConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AggregateRoute>> ipv4Routes = default;
            Optional<IList<AggregateRoute>> ipv6Routes = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipv4Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AggregateRoute> array = new List<AggregateRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AggregateRoute.DeserializeAggregateRoute(item));
                    }
                    ipv4Routes = array;
                    continue;
                }
                if (property.NameEquals("ipv6Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AggregateRoute> array = new List<AggregateRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AggregateRoute.DeserializeAggregateRoute(item));
                    }
                    ipv6Routes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AggregateRouteConfiguration(Optional.ToList(ipv4Routes), Optional.ToList(ipv6Routes), serializedAdditionalRawData);
        }

        AggregateRouteConfiguration IModelJsonSerializable<AggregateRouteConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateRouteConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAggregateRouteConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AggregateRouteConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateRouteConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AggregateRouteConfiguration IModelSerializable<AggregateRouteConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateRouteConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAggregateRouteConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AggregateRouteConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AggregateRouteConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(AggregateRouteConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AggregateRouteConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AggregateRouteConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAggregateRouteConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
