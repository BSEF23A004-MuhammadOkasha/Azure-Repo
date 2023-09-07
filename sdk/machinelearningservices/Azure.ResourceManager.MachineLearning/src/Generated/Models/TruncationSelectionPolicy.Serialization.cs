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
    public partial class TruncationSelectionPolicy : IUtf8JsonSerializable, IModelJsonSerializable<TruncationSelectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TruncationSelectionPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TruncationSelectionPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TruncationSelectionPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TruncationPercentage))
            {
                writer.WritePropertyName("truncationPercentage"u8);
                writer.WriteNumberValue(TruncationPercentage.Value);
            }
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

        internal static TruncationSelectionPolicy DeserializeTruncationSelectionPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> truncationPercentage = default;
            Optional<int> delayEvaluation = default;
            Optional<int> evaluationInterval = default;
            EarlyTerminationPolicyType policyType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("truncationPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    truncationPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("delayEvaluation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delayEvaluation = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("evaluationInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyType"u8))
                {
                    policyType = new EarlyTerminationPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TruncationSelectionPolicy(Optional.ToNullable(delayEvaluation), Optional.ToNullable(evaluationInterval), policyType, Optional.ToNullable(truncationPercentage), serializedAdditionalRawData);
        }

        TruncationSelectionPolicy IModelJsonSerializable<TruncationSelectionPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TruncationSelectionPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTruncationSelectionPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TruncationSelectionPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TruncationSelectionPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TruncationSelectionPolicy IModelSerializable<TruncationSelectionPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TruncationSelectionPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTruncationSelectionPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TruncationSelectionPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TruncationSelectionPolicy"/> to convert. </param>
        public static implicit operator RequestContent(TruncationSelectionPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TruncationSelectionPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TruncationSelectionPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTruncationSelectionPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
