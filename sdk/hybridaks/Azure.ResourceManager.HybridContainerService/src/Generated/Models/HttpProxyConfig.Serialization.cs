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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class HttpProxyConfig : IUtf8JsonSerializable, IModelJsonSerializable<HttpProxyConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HttpProxyConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HttpProxyConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpProxyConfig>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(HttpProxy))
            {
                writer.WritePropertyName("httpProxy"u8);
                writer.WriteStringValue(HttpProxy);
            }
            if (Optional.IsDefined(HttpsProxy))
            {
                writer.WritePropertyName("httpsProxy"u8);
                writer.WriteStringValue(HttpsProxy);
            }
            if (Optional.IsCollectionDefined(NoProxy))
            {
                writer.WritePropertyName("noProxy"u8);
                writer.WriteStartArray();
                foreach (var item in NoProxy)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedCa))
            {
                writer.WritePropertyName("trustedCa"u8);
                writer.WriteStringValue(TrustedCa);
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
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

        internal static HttpProxyConfig DeserializeHttpProxyConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> password = default;
            Optional<string> httpProxy = default;
            Optional<string> httpsProxy = default;
            Optional<IList<string>> noProxy = default;
            Optional<string> trustedCa = default;
            Optional<string> username = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpProxy"u8))
                {
                    httpProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsProxy"u8))
                {
                    httpsProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("noProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    noProxy = array;
                    continue;
                }
                if (property.NameEquals("trustedCa"u8))
                {
                    trustedCa = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HttpProxyConfig(httpProxy.Value, httpsProxy.Value, Optional.ToList(noProxy), trustedCa.Value, username.Value, password.Value, serializedAdditionalRawData);
        }

        HttpProxyConfig IModelJsonSerializable<HttpProxyConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpProxyConfig>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHttpProxyConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HttpProxyConfig>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpProxyConfig>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HttpProxyConfig IModelSerializable<HttpProxyConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpProxyConfig>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHttpProxyConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HttpProxyConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HttpProxyConfig"/> to convert. </param>
        public static implicit operator RequestContent(HttpProxyConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HttpProxyConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HttpProxyConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHttpProxyConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
