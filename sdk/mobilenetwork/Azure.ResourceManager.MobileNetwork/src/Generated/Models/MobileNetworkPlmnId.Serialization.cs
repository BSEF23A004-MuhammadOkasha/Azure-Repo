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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPlmnId : IUtf8JsonSerializable, IModelJsonSerializable<MobileNetworkPlmnId>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MobileNetworkPlmnId>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MobileNetworkPlmnId>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPlmnId>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("mcc"u8);
            writer.WriteStringValue(Mcc);
            writer.WritePropertyName("mnc"u8);
            writer.WriteStringValue(Mnc);
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

        internal static MobileNetworkPlmnId DeserializeMobileNetworkPlmnId(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mcc = default;
            string mnc = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mcc"u8))
                {
                    mcc = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mnc"u8))
                {
                    mnc = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MobileNetworkPlmnId(mcc, mnc, rawData);
        }

        MobileNetworkPlmnId IModelJsonSerializable<MobileNetworkPlmnId>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPlmnId>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPlmnId(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MobileNetworkPlmnId>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPlmnId>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MobileNetworkPlmnId IModelSerializable<MobileNetworkPlmnId>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPlmnId>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMobileNetworkPlmnId(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MobileNetworkPlmnId"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MobileNetworkPlmnId"/> to convert. </param>
        public static implicit operator RequestContent(MobileNetworkPlmnId model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MobileNetworkPlmnId"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MobileNetworkPlmnId(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMobileNetworkPlmnId(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
