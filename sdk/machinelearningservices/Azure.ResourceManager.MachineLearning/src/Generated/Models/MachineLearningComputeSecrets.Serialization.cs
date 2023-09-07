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
    public partial class MachineLearningComputeSecrets : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningComputeSecrets>
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

        internal static MachineLearningComputeSecrets DeserializeMachineLearningComputeSecrets(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("computeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AKS": return MachineLearningAksComputeSecrets.DeserializeMachineLearningAksComputeSecrets(element);
                    case "Databricks": return MachineLearningDatabricksComputeSecrets.DeserializeMachineLearningDatabricksComputeSecrets(element);
                    case "VirtualMachine": return MachineLearningVirtualMachineSecrets.DeserializeMachineLearningVirtualMachineSecrets(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            ComputeType computeType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownComputeSecrets(computeType, serializedAdditionalRawData);
        }

        MachineLearningComputeSecrets IModelJsonSerializable<MachineLearningComputeSecrets>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeSecrets>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeSecrets(doc.RootElement, options);
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

        /// <summary> Converts a <see cref="MachineLearningComputeSecrets"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningComputeSecrets"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningComputeSecrets model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningComputeSecrets"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningComputeSecrets(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningComputeSecrets(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
