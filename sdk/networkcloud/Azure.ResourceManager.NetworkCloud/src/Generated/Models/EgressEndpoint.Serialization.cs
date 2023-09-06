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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class EgressEndpoint : IUtf8JsonSerializable, IModelJsonSerializable<EgressEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EgressEndpoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EgressEndpoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EgressEndpoint>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("category"u8);
            writer.WriteStringValue(Category);
            writer.WritePropertyName("endpoints"u8);
            writer.WriteStartArray();
            foreach (var item in Endpoints)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EndpointDependency>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static EgressEndpoint DeserializeEgressEndpoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string category = default;
            IList<EndpointDependency> endpoints = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    List<EndpointDependency> array = new List<EndpointDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EndpointDependency.DeserializeEndpointDependency(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EgressEndpoint(category, endpoints, rawData);
        }

        EgressEndpoint IModelJsonSerializable<EgressEndpoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EgressEndpoint>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEgressEndpoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EgressEndpoint>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EgressEndpoint>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EgressEndpoint IModelSerializable<EgressEndpoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EgressEndpoint>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEgressEndpoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EgressEndpoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EgressEndpoint"/> to convert. </param>
        public static implicit operator RequestContent(EgressEndpoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EgressEndpoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EgressEndpoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEgressEndpoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
