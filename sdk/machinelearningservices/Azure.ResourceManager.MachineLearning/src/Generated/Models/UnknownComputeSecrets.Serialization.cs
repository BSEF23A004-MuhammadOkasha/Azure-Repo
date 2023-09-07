// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownComputeSecrets : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningComputeSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningComputeSecrets>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningComputeSecrets>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeSecrets>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
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

        internal static MachineLearningComputeSecrets DeserializeUnknownComputeSecrets(JsonElement element, ModelSerializerOptions options = default) => DeserializeMachineLearningComputeSecrets(element, options);

        MachineLearningComputeSecrets IModelJsonSerializable<MachineLearningComputeSecrets>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeSecrets>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownComputeSecrets(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningComputeSecrets>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeSecrets>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningComputeSecrets IModelSerializable<MachineLearningComputeSecrets>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeSecrets>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningComputeSecrets(doc.RootElement, options);
        }
    }
}
