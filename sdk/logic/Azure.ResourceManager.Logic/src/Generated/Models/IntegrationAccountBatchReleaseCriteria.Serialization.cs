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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountBatchReleaseCriteria : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationAccountBatchReleaseCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationAccountBatchReleaseCriteria>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationAccountBatchReleaseCriteria>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationAccountBatchReleaseCriteria>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MessageCount))
            {
                writer.WritePropertyName("messageCount"u8);
                writer.WriteNumberValue(MessageCount.Value);
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence"u8);
                if (Recurrence is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LogicWorkflowTriggerRecurrence>)Recurrence).Serialize(writer, options);
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

        internal static IntegrationAccountBatchReleaseCriteria DeserializeIntegrationAccountBatchReleaseCriteria(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> messageCount = default;
            Optional<int> batchSize = default;
            Optional<LogicWorkflowTriggerRecurrence> recurrence = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("batchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = LogicWorkflowTriggerRecurrence.DeserializeLogicWorkflowTriggerRecurrence(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationAccountBatchReleaseCriteria(Optional.ToNullable(messageCount), Optional.ToNullable(batchSize), recurrence.Value, serializedAdditionalRawData);
        }

        IntegrationAccountBatchReleaseCriteria IModelJsonSerializable<IntegrationAccountBatchReleaseCriteria>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationAccountBatchReleaseCriteria>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountBatchReleaseCriteria(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationAccountBatchReleaseCriteria>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationAccountBatchReleaseCriteria>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationAccountBatchReleaseCriteria IModelSerializable<IntegrationAccountBatchReleaseCriteria>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationAccountBatchReleaseCriteria>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationAccountBatchReleaseCriteria(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IntegrationAccountBatchReleaseCriteria"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IntegrationAccountBatchReleaseCriteria"/> to convert. </param>
        public static implicit operator RequestContent(IntegrationAccountBatchReleaseCriteria model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IntegrationAccountBatchReleaseCriteria"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IntegrationAccountBatchReleaseCriteria(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationAccountBatchReleaseCriteria(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
