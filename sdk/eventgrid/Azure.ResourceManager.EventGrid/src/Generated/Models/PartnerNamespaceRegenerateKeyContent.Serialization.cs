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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerNamespaceRegenerateKeyContent : IUtf8JsonSerializable, IModelJsonSerializable<PartnerNamespaceRegenerateKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PartnerNamespaceRegenerateKeyContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PartnerNamespaceRegenerateKeyContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerNamespaceRegenerateKeyContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
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

        internal static PartnerNamespaceRegenerateKeyContent DeserializePartnerNamespaceRegenerateKeyContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PartnerNamespaceRegenerateKeyContent(keyName, rawData);
        }

        PartnerNamespaceRegenerateKeyContent IModelJsonSerializable<PartnerNamespaceRegenerateKeyContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerNamespaceRegenerateKeyContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerNamespaceRegenerateKeyContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PartnerNamespaceRegenerateKeyContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerNamespaceRegenerateKeyContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PartnerNamespaceRegenerateKeyContent IModelSerializable<PartnerNamespaceRegenerateKeyContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerNamespaceRegenerateKeyContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePartnerNamespaceRegenerateKeyContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PartnerNamespaceRegenerateKeyContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PartnerNamespaceRegenerateKeyContent"/> to convert. </param>
        public static implicit operator RequestContent(PartnerNamespaceRegenerateKeyContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PartnerNamespaceRegenerateKeyContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PartnerNamespaceRegenerateKeyContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePartnerNamespaceRegenerateKeyContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
