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
    internal partial class UnknownJobInput : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobInputBasicProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobInputBasicProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobInputBasicProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputBasicProperties>(this, options.Format);

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

        internal static MediaJobInputBasicProperties DeserializeUnknownJobInput(JsonElement element, ModelSerializerOptions options = default) => DeserializeMediaJobInputBasicProperties(element, options);

        MediaJobInputBasicProperties IModelJsonSerializable<MediaJobInputBasicProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputBasicProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownJobInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobInputBasicProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputBasicProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobInputBasicProperties IModelSerializable<MediaJobInputBasicProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobInputBasicProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobInputBasicProperties(doc.RootElement, options);
        }
    }
}
