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

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class LoadTestingOutboundEnvironmentEndpoint : IUtf8JsonSerializable, IModelJsonSerializable<LoadTestingOutboundEnvironmentEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadTestingOutboundEnvironmentEndpoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadTestingOutboundEnvironmentEndpoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadTestingOutboundEnvironmentEndpoint>(this, options.Format);

            writer.WriteStartObject();
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

        internal static LoadTestingOutboundEnvironmentEndpoint DeserializeLoadTestingOutboundEnvironmentEndpoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> category = default;
            Optional<IReadOnlyList<LoadTestingEndpointDependency>> endpoints = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadTestingEndpointDependency> array = new List<LoadTestingEndpointDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTestingEndpointDependency.DeserializeLoadTestingEndpointDependency(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoadTestingOutboundEnvironmentEndpoint(category.Value, Optional.ToList(endpoints), serializedAdditionalRawData);
        }

        LoadTestingOutboundEnvironmentEndpoint IModelJsonSerializable<LoadTestingOutboundEnvironmentEndpoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadTestingOutboundEnvironmentEndpoint>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestingOutboundEnvironmentEndpoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadTestingOutboundEnvironmentEndpoint>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadTestingOutboundEnvironmentEndpoint>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadTestingOutboundEnvironmentEndpoint IModelSerializable<LoadTestingOutboundEnvironmentEndpoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadTestingOutboundEnvironmentEndpoint>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadTestingOutboundEnvironmentEndpoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoadTestingOutboundEnvironmentEndpoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoadTestingOutboundEnvironmentEndpoint"/> to convert. </param>
        public static implicit operator RequestContent(LoadTestingOutboundEnvironmentEndpoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoadTestingOutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoadTestingOutboundEnvironmentEndpoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadTestingOutboundEnvironmentEndpoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
