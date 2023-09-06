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

namespace Azure.ResourceManager.PrivateDns.Models
{
    public partial class PrivateDnsMXRecordInfo : IUtf8JsonSerializable, IModelJsonSerializable<PrivateDnsMXRecordInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateDnsMXRecordInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateDnsMXRecordInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateDnsMXRecordInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Preference))
            {
                writer.WritePropertyName("preference"u8);
                writer.WriteNumberValue(Preference.Value);
            }
            if (Optional.IsDefined(Exchange))
            {
                writer.WritePropertyName("exchange"u8);
                writer.WriteStringValue(Exchange);
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

        internal static PrivateDnsMXRecordInfo DeserializePrivateDnsMXRecordInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> preference = default;
            Optional<string> exchange = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preference = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exchange"u8))
                {
                    exchange = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateDnsMXRecordInfo(Optional.ToNullable(preference), exchange.Value, rawData);
        }

        PrivateDnsMXRecordInfo IModelJsonSerializable<PrivateDnsMXRecordInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateDnsMXRecordInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateDnsMXRecordInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateDnsMXRecordInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateDnsMXRecordInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateDnsMXRecordInfo IModelSerializable<PrivateDnsMXRecordInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateDnsMXRecordInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateDnsMXRecordInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateDnsMXRecordInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateDnsMXRecordInfo"/> to convert. </param>
        public static implicit operator RequestContent(PrivateDnsMXRecordInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateDnsMXRecordInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateDnsMXRecordInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateDnsMXRecordInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
