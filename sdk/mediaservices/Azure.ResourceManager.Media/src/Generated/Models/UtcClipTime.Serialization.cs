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

namespace Azure.ResourceManager.Media.Models
{
    public partial class UtcClipTime : IUtf8JsonSerializable, IModelJsonSerializable<UtcClipTime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UtcClipTime>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UtcClipTime>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UtcClipTime>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("time"u8);
            writer.WriteStringValue(Time, "O");
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static UtcClipTime DeserializeUtcClipTime(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset time = default;
            string odataType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"u8))
                {
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UtcClipTime(odataType, time, serializedAdditionalRawData);
        }

        UtcClipTime IModelJsonSerializable<UtcClipTime>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UtcClipTime>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUtcClipTime(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UtcClipTime>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UtcClipTime>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UtcClipTime IModelSerializable<UtcClipTime>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UtcClipTime>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUtcClipTime(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UtcClipTime"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UtcClipTime"/> to convert. </param>
        public static implicit operator RequestContent(UtcClipTime model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UtcClipTime"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UtcClipTime(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUtcClipTime(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
