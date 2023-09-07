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
    public partial class MachineLearningInstanceTypeSchema : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningInstanceTypeSchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningInstanceTypeSchema>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningInstanceTypeSchema>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchema>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NodeSelector))
            {
                if (NodeSelector != null)
                {
                    writer.WritePropertyName("nodeSelector"u8);
                    writer.WriteStartObject();
                    foreach (var item in NodeSelector)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("nodeSelector");
                }
            }
            if (Optional.IsDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                if (Resources is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MachineLearningInstanceTypeSchemaResources>)Resources).Serialize(writer, options);
                }
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

        internal static MachineLearningInstanceTypeSchema DeserializeMachineLearningInstanceTypeSchema(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> nodeSelector = default;
            Optional<MachineLearningInstanceTypeSchemaResources> resources = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeSelector"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nodeSelector = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    nodeSelector = dictionary;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resources = MachineLearningInstanceTypeSchemaResources.DeserializeMachineLearningInstanceTypeSchemaResources(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningInstanceTypeSchema(Optional.ToDictionary(nodeSelector), resources.Value, serializedAdditionalRawData);
        }

        MachineLearningInstanceTypeSchema IModelJsonSerializable<MachineLearningInstanceTypeSchema>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchema>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningInstanceTypeSchema(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningInstanceTypeSchema>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchema>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningInstanceTypeSchema IModelSerializable<MachineLearningInstanceTypeSchema>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningInstanceTypeSchema>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningInstanceTypeSchema(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningInstanceTypeSchema"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningInstanceTypeSchema"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningInstanceTypeSchema model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningInstanceTypeSchema"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningInstanceTypeSchema(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningInstanceTypeSchema(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
