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

namespace Azure.ResourceManager.HealthBot.Models
{
    public partial class HealthBotSku : IUtf8JsonSerializable, IModelJsonSerializable<HealthBotSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthBotSku>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthBotSku>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthBotSku>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToSerialString());
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

        internal static HealthBotSku DeserializeHealthBotSku(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthBotSkuName name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString().ToHealthBotSkuName();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthBotSku(name, rawData);
        }

        HealthBotSku IModelJsonSerializable<HealthBotSku>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthBotSku>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthBotSku(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthBotSku>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthBotSku>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthBotSku IModelSerializable<HealthBotSku>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthBotSku>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthBotSku(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthBotSku"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthBotSku"/> to convert. </param>
        public static implicit operator RequestContent(HealthBotSku model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthBotSku"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthBotSku(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthBotSku(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
