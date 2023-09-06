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
    public partial class Ambr : IUtf8JsonSerializable, IModelJsonSerializable<Ambr>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<Ambr>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<Ambr>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Ambr>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("uplink"u8);
            writer.WriteStringValue(Uplink);
            writer.WritePropertyName("downlink"u8);
            writer.WriteStringValue(Downlink);
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

        internal static Ambr DeserializeAmbr(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string uplink = default;
            string downlink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uplink"u8))
                {
                    uplink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("downlink"u8))
                {
                    downlink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new Ambr(uplink, downlink, rawData);
        }

        Ambr IModelJsonSerializable<Ambr>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Ambr>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmbr(doc.RootElement, options);
        }

        BinaryData IModelSerializable<Ambr>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Ambr>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        Ambr IModelSerializable<Ambr>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Ambr>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmbr(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="Ambr"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="Ambr"/> to convert. </param>
        public static implicit operator RequestContent(Ambr model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="Ambr"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator Ambr(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmbr(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
