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
    public partial class X12DelimiterOverrides : IUtf8JsonSerializable, IModelJsonSerializable<X12DelimiterOverrides>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<X12DelimiterOverrides>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<X12DelimiterOverrides>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<X12DelimiterOverrides>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ProtocolVersion))
            {
                writer.WritePropertyName("protocolVersion"u8);
                writer.WriteStringValue(ProtocolVersion);
            }
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            writer.WritePropertyName("dataElementSeparator"u8);
            writer.WriteNumberValue(DataElementSeparator);
            writer.WritePropertyName("componentSeparator"u8);
            writer.WriteNumberValue(ComponentSeparator);
            writer.WritePropertyName("segmentTerminator"u8);
            writer.WriteNumberValue(SegmentTerminator);
            writer.WritePropertyName("segmentTerminatorSuffix"u8);
            writer.WriteStringValue(SegmentTerminatorSuffix.ToSerialString());
            writer.WritePropertyName("replaceCharacter"u8);
            writer.WriteNumberValue(ReplaceCharacter);
            writer.WritePropertyName("replaceSeparatorsInPayload"u8);
            writer.WriteBooleanValue(ReplaceSeparatorsInPayload);
            if (Optional.IsDefined(TargetNamespace))
            {
                writer.WritePropertyName("targetNamespace"u8);
                writer.WriteStringValue(TargetNamespace);
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

        internal static X12DelimiterOverrides DeserializeX12DelimiterOverrides(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> protocolVersion = default;
            Optional<string> messageId = default;
            int dataElementSeparator = default;
            int componentSeparator = default;
            int segmentTerminator = default;
            SegmentTerminatorSuffix segmentTerminatorSuffix = default;
            int replaceCharacter = default;
            bool replaceSeparatorsInPayload = default;
            Optional<string> targetNamespace = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocolVersion"u8))
                {
                    protocolVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataElementSeparator"u8))
                {
                    dataElementSeparator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("componentSeparator"u8))
                {
                    componentSeparator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("segmentTerminator"u8))
                {
                    segmentTerminator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("segmentTerminatorSuffix"u8))
                {
                    segmentTerminatorSuffix = property.Value.GetString().ToSegmentTerminatorSuffix();
                    continue;
                }
                if (property.NameEquals("replaceCharacter"u8))
                {
                    replaceCharacter = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replaceSeparatorsInPayload"u8))
                {
                    replaceSeparatorsInPayload = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetNamespace"u8))
                {
                    targetNamespace = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new X12DelimiterOverrides(protocolVersion.Value, messageId.Value, dataElementSeparator, componentSeparator, segmentTerminator, segmentTerminatorSuffix, replaceCharacter, replaceSeparatorsInPayload, targetNamespace.Value, serializedAdditionalRawData);
        }

        X12DelimiterOverrides IModelJsonSerializable<X12DelimiterOverrides>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<X12DelimiterOverrides>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeX12DelimiterOverrides(doc.RootElement, options);
        }

        BinaryData IModelSerializable<X12DelimiterOverrides>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<X12DelimiterOverrides>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        X12DelimiterOverrides IModelSerializable<X12DelimiterOverrides>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<X12DelimiterOverrides>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeX12DelimiterOverrides(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="X12DelimiterOverrides"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="X12DelimiterOverrides"/> to convert. </param>
        public static implicit operator RequestContent(X12DelimiterOverrides model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="X12DelimiterOverrides"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator X12DelimiterOverrides(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeX12DelimiterOverrides(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
