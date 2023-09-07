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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class AgentPoolProvisioningStatusStatusProvisioningStatus : IUtf8JsonSerializable, IModelJsonSerializable<AgentPoolProvisioningStatusStatusProvisioningStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AgentPoolProvisioningStatusStatusProvisioningStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AgentPoolProvisioningStatusStatusProvisioningStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentPoolProvisioningStatusStatusProvisioningStatus>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                if (Error is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AgentPoolProvisioningStatusError>)Error).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(Phase))
            {
                writer.WritePropertyName("phase"u8);
                writer.WriteStringValue(Phase);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        internal static AgentPoolProvisioningStatusStatusProvisioningStatus DeserializeAgentPoolProvisioningStatusStatusProvisioningStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AgentPoolProvisioningStatusError> error = default;
            Optional<string> operationId = default;
            Optional<string> phase = default;
            Optional<string> status = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = AgentPoolProvisioningStatusError.DeserializeAgentPoolProvisioningStatusError(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phase"u8))
                {
                    phase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AgentPoolProvisioningStatusStatusProvisioningStatus(error.Value, operationId.Value, phase.Value, status.Value, serializedAdditionalRawData);
        }

        AgentPoolProvisioningStatusStatusProvisioningStatus IModelJsonSerializable<AgentPoolProvisioningStatusStatusProvisioningStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentPoolProvisioningStatusStatusProvisioningStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolProvisioningStatusStatusProvisioningStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AgentPoolProvisioningStatusStatusProvisioningStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentPoolProvisioningStatusStatusProvisioningStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AgentPoolProvisioningStatusStatusProvisioningStatus IModelSerializable<AgentPoolProvisioningStatusStatusProvisioningStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AgentPoolProvisioningStatusStatusProvisioningStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAgentPoolProvisioningStatusStatusProvisioningStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AgentPoolProvisioningStatusStatusProvisioningStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AgentPoolProvisioningStatusStatusProvisioningStatus"/> to convert. </param>
        public static implicit operator RequestContent(AgentPoolProvisioningStatusStatusProvisioningStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AgentPoolProvisioningStatusStatusProvisioningStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AgentPoolProvisioningStatusStatusProvisioningStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAgentPoolProvisioningStatusStatusProvisioningStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
