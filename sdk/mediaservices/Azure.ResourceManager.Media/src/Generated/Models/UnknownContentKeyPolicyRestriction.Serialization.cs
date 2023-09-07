// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class UnknownContentKeyPolicyRestriction : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyRestriction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyRestriction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyRestriction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyRestriction>(this, options.Format);

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

        internal static ContentKeyPolicyRestriction DeserializeUnknownContentKeyPolicyRestriction(JsonElement element, ModelSerializerOptions options = default) => DeserializeContentKeyPolicyRestriction(element, options);

        ContentKeyPolicyRestriction IModelJsonSerializable<ContentKeyPolicyRestriction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyRestriction>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownContentKeyPolicyRestriction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyRestriction>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyRestriction>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyRestriction IModelSerializable<ContentKeyPolicyRestriction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyRestriction>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyRestriction(doc.RootElement, options);
        }
    }
}
