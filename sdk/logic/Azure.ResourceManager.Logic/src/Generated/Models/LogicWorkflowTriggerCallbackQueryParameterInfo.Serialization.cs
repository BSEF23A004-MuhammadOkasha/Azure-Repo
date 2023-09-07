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
    public partial class LogicWorkflowTriggerCallbackQueryParameterInfo : IUtf8JsonSerializable, IModelJsonSerializable<LogicWorkflowTriggerCallbackQueryParameterInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicWorkflowTriggerCallbackQueryParameterInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicWorkflowTriggerCallbackQueryParameterInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowTriggerCallbackQueryParameterInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("api-version"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(Sp))
            {
                writer.WritePropertyName("sp"u8);
                writer.WriteStringValue(Sp);
            }
            if (Optional.IsDefined(Sv))
            {
                writer.WritePropertyName("sv"u8);
                writer.WriteStringValue(Sv);
            }
            if (Optional.IsDefined(Sig))
            {
                writer.WritePropertyName("sig"u8);
                writer.WriteStringValue(Sig);
            }
            if (Optional.IsDefined(Se))
            {
                writer.WritePropertyName("se"u8);
                writer.WriteStringValue(Se);
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

        internal static LogicWorkflowTriggerCallbackQueryParameterInfo DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> apiVersion = default;
            Optional<string> sp = default;
            Optional<string> sv = default;
            Optional<string> sig = default;
            Optional<string> se = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api-version"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sp"u8))
                {
                    sp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sv"u8))
                {
                    sv = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sig"u8))
                {
                    sig = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("se"u8))
                {
                    se = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicWorkflowTriggerCallbackQueryParameterInfo(apiVersion.Value, sp.Value, sv.Value, sig.Value, se.Value, serializedAdditionalRawData);
        }

        LogicWorkflowTriggerCallbackQueryParameterInfo IModelJsonSerializable<LogicWorkflowTriggerCallbackQueryParameterInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowTriggerCallbackQueryParameterInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicWorkflowTriggerCallbackQueryParameterInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowTriggerCallbackQueryParameterInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicWorkflowTriggerCallbackQueryParameterInfo IModelSerializable<LogicWorkflowTriggerCallbackQueryParameterInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowTriggerCallbackQueryParameterInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogicWorkflowTriggerCallbackQueryParameterInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogicWorkflowTriggerCallbackQueryParameterInfo"/> to convert. </param>
        public static implicit operator RequestContent(LogicWorkflowTriggerCallbackQueryParameterInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogicWorkflowTriggerCallbackQueryParameterInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogicWorkflowTriggerCallbackQueryParameterInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
