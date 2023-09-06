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

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class ConfigurationAccessEndpointSpec : IUtf8JsonSerializable, IModelJsonSerializable<ConfigurationAccessEndpointSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConfigurationAccessEndpointSpec>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConfigurationAccessEndpointSpec>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigurationAccessEndpointSpec>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ConfigurationAccessEndpointSpec DeserializeConfigurationAccessEndpointSpec(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> endpoint = default;
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
            return new ConfigurationAccessEndpointSpec(endpoint.Value, rawData);
        }

        ConfigurationAccessEndpointSpec IModelJsonSerializable<ConfigurationAccessEndpointSpec>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigurationAccessEndpointSpec>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationAccessEndpointSpec(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConfigurationAccessEndpointSpec>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigurationAccessEndpointSpec>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConfigurationAccessEndpointSpec IModelSerializable<ConfigurationAccessEndpointSpec>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigurationAccessEndpointSpec>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConfigurationAccessEndpointSpec(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConfigurationAccessEndpointSpec"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConfigurationAccessEndpointSpec"/> to convert. </param>
        public static implicit operator RequestContent(ConfigurationAccessEndpointSpec model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConfigurationAccessEndpointSpec"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConfigurationAccessEndpointSpec(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConfigurationAccessEndpointSpec(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
