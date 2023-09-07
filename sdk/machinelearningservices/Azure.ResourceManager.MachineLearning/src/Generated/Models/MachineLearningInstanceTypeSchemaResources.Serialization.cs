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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningInstanceTypeSchemaResources : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningInstanceTypeSchemaResources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningInstanceTypeSchemaResources>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningInstanceTypeSchemaResources>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchemaResources>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Requests))
            {
                writer.WritePropertyName("requests"u8);
                writer.WriteStartObject();
                foreach (var item in Requests)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Limits))
            {
                writer.WritePropertyName("limits"u8);
                writer.WriteStartObject();
                foreach (var item in Limits)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static MachineLearningInstanceTypeSchemaResources DeserializeMachineLearningInstanceTypeSchemaResources(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> requests = default;
            Optional<IDictionary<string, string>> limits = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    requests = dictionary;
                    continue;
                }
                if (property.NameEquals("limits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    limits = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningInstanceTypeSchemaResources(Optional.ToDictionary(requests), Optional.ToDictionary(limits), serializedAdditionalRawData);
        }

        MachineLearningInstanceTypeSchemaResources IModelJsonSerializable<MachineLearningInstanceTypeSchemaResources>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchemaResources>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningInstanceTypeSchemaResources(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningInstanceTypeSchemaResources>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchemaResources>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningInstanceTypeSchemaResources IModelSerializable<MachineLearningInstanceTypeSchemaResources>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchemaResources>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningInstanceTypeSchemaResources(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningInstanceTypeSchemaResources"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningInstanceTypeSchemaResources"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningInstanceTypeSchemaResources model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningInstanceTypeSchemaResources"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningInstanceTypeSchemaResources(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningInstanceTypeSchemaResources(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
