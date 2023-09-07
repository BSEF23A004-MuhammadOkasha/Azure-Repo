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
    internal partial class UnknownEarlyTerminationPolicy : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningEarlyTerminationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningEarlyTerminationPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningEarlyTerminationPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEarlyTerminationPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DelayEvaluation))
            {
                writer.WritePropertyName("delayEvaluation"u8);
                writer.WriteNumberValue(DelayEvaluation.Value);
            }
            if (Optional.IsDefined(EvaluationInterval))
            {
                writer.WritePropertyName("evaluationInterval"u8);
                writer.WriteNumberValue(EvaluationInterval.Value);
            }
            writer.WritePropertyName("policyType"u8);
            writer.WriteStringValue(PolicyType.ToString());
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

        internal static MachineLearningEarlyTerminationPolicy DeserializeUnknownEarlyTerminationPolicy(JsonElement element, ModelSerializerOptions options = default) => DeserializeMachineLearningEarlyTerminationPolicy(element, options);

        MachineLearningEarlyTerminationPolicy IModelJsonSerializable<MachineLearningEarlyTerminationPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEarlyTerminationPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownEarlyTerminationPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningEarlyTerminationPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEarlyTerminationPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningEarlyTerminationPolicy IModelSerializable<MachineLearningEarlyTerminationPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEarlyTerminationPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningEarlyTerminationPolicy(doc.RootElement, options);
        }
    }
}
