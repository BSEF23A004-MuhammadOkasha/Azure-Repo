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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsSmsEventBaseProperties : IUtf8JsonSerializable, IModelJsonSerializable<AcsSmsEventBaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsSmsEventBaseProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsSmsEventBaseProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsSmsEventBaseProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            if (Optional.IsDefined(From))
            {
                writer.WritePropertyName("from"u8);
                writer.WriteStringValue(From);
            }
            if (Optional.IsDefined(To))
            {
                writer.WritePropertyName("to"u8);
                writer.WriteStringValue(To);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static AcsSmsEventBaseProperties DeserializeAcsSmsEventBaseProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> messageId = default;
            Optional<string> @from = default;
            Optional<string> to = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AcsSmsEventBaseProperties(messageId.Value, @from.Value, to.Value, rawData);
        }

        AcsSmsEventBaseProperties IModelJsonSerializable<AcsSmsEventBaseProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsSmsEventBaseProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsSmsEventBaseProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsSmsEventBaseProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsSmsEventBaseProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsSmsEventBaseProperties IModelSerializable<AcsSmsEventBaseProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsSmsEventBaseProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsSmsEventBaseProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AcsSmsEventBaseProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AcsSmsEventBaseProperties"/> to convert. </param>
        public static implicit operator RequestContent(AcsSmsEventBaseProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AcsSmsEventBaseProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AcsSmsEventBaseProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsSmsEventBaseProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
