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
    internal partial class AmlComputeNodesInformation : IUtf8JsonSerializable, IModelJsonSerializable<AmlComputeNodesInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AmlComputeNodesInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AmlComputeNodesInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlComputeNodesInformation>(this, options.Format);

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

        internal static AmlComputeNodesInformation DeserializeAmlComputeNodesInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AmlComputeNodeInformation>> nodes = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AmlComputeNodeInformation> array = new List<AmlComputeNodeInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AmlComputeNodeInformation.DeserializeAmlComputeNodeInformation(item));
                    }
                    nodes = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AmlComputeNodesInformation(Optional.ToList(nodes), nextLink.Value, serializedAdditionalRawData);
        }

        AmlComputeNodesInformation IModelJsonSerializable<AmlComputeNodesInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlComputeNodesInformation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlComputeNodesInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AmlComputeNodesInformation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlComputeNodesInformation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AmlComputeNodesInformation IModelSerializable<AmlComputeNodesInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlComputeNodesInformation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmlComputeNodesInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AmlComputeNodesInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AmlComputeNodesInformation"/> to convert. </param>
        public static implicit operator RequestContent(AmlComputeNodesInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AmlComputeNodesInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AmlComputeNodesInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmlComputeNodesInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
