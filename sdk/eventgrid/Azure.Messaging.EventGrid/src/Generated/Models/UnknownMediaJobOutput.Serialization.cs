// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.Messaging.EventGrid.SystemEvents;

namespace Azure.Messaging.EventGrid.Models
{
    internal partial class UnknownMediaJobOutput : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutput>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                if (Error is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaJobError>)Error).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            writer.WritePropertyName("progress"u8);
            writer.WriteNumberValue(Progress);
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToSerialString());
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

        internal static MediaJobOutput DeserializeUnknownMediaJobOutput(JsonElement element, ModelSerializerOptions options = default) => DeserializeMediaJobOutput(element, options);

        MediaJobOutput IModelJsonSerializable<MediaJobOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownMediaJobOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobOutput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobOutput IModelSerializable<MediaJobOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobOutput(doc.RootElement, options);
        }
    }
}
