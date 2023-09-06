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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class SshConnectivityEndpoint : IUtf8JsonSerializable, IModelJsonSerializable<SshConnectivityEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SshConnectivityEndpoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SshConnectivityEndpoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SshConnectivityEndpoint>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(Endpoint);
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

        internal static SshConnectivityEndpoint DeserializeSshConnectivityEndpoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SshConnectivityEndpoint(endpoint, rawData);
        }

        SshConnectivityEndpoint IModelJsonSerializable<SshConnectivityEndpoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SshConnectivityEndpoint>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSshConnectivityEndpoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SshConnectivityEndpoint>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SshConnectivityEndpoint>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SshConnectivityEndpoint IModelSerializable<SshConnectivityEndpoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SshConnectivityEndpoint>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSshConnectivityEndpoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SshConnectivityEndpoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SshConnectivityEndpoint"/> to convert. </param>
        public static implicit operator RequestContent(SshConnectivityEndpoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SshConnectivityEndpoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SshConnectivityEndpoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSshConnectivityEndpoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
