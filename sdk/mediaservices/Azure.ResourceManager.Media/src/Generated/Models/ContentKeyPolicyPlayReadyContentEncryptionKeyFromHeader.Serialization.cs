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
    public partial class ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(odataType, serializedAdditionalRawData);
        }

        ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader IModelSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> to convert. </param>
        public static implicit operator RequestContent(ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
