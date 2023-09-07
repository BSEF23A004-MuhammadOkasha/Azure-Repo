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

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class ServicePrincipalProperties : IUtf8JsonSerializable, IModelJsonSerializable<ServicePrincipalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServicePrincipalProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServicePrincipalProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePrincipalProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            writer.WritePropertyName("secret"u8);
            writer.WriteStringValue(Secret);
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

        internal static ServicePrincipalProperties DeserializeServicePrincipalProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientId = default;
            string secret = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secret"u8))
                {
                    secret = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServicePrincipalProperties(clientId, secret, serializedAdditionalRawData);
        }

        ServicePrincipalProperties IModelJsonSerializable<ServicePrincipalProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePrincipalProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePrincipalProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServicePrincipalProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePrincipalProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServicePrincipalProperties IModelSerializable<ServicePrincipalProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePrincipalProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServicePrincipalProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServicePrincipalProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServicePrincipalProperties"/> to convert. </param>
        public static implicit operator RequestContent(ServicePrincipalProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServicePrincipalProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServicePrincipalProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServicePrincipalProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
