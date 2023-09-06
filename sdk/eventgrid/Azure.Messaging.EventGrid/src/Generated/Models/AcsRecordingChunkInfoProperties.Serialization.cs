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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRecordingChunkInfoProperties : IUtf8JsonSerializable, IModelJsonSerializable<AcsRecordingChunkInfoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsRecordingChunkInfoProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsRecordingChunkInfoProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsRecordingChunkInfoProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DocumentId))
            {
                writer.WritePropertyName("documentId"u8);
                writer.WriteStringValue(DocumentId);
            }
            if (Optional.IsDefined(Index))
            {
                writer.WritePropertyName("index"u8);
                writer.WriteNumberValue(Index.Value);
            }
            if (Optional.IsDefined(EndReason))
            {
                writer.WritePropertyName("endReason"u8);
                writer.WriteStringValue(EndReason);
            }
            if (Optional.IsDefined(MetadataLocation))
            {
                writer.WritePropertyName("metadataLocation"u8);
                writer.WriteStringValue(MetadataLocation);
            }
            if (Optional.IsDefined(ContentLocation))
            {
                writer.WritePropertyName("contentLocation"u8);
                writer.WriteStringValue(ContentLocation);
            }
            if (Optional.IsDefined(DeleteLocation))
            {
                writer.WritePropertyName("deleteLocation"u8);
                writer.WriteStringValue(DeleteLocation);
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

        internal static AcsRecordingChunkInfoProperties DeserializeAcsRecordingChunkInfoProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> documentId = default;
            Optional<long> index = default;
            Optional<string> endReason = default;
            Optional<string> metadataLocation = default;
            Optional<string> contentLocation = default;
            Optional<string> deleteLocation = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentId"u8))
                {
                    documentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    index = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("endReason"u8))
                {
                    endReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadataLocation"u8))
                {
                    metadataLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentLocation"u8))
                {
                    contentLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deleteLocation"u8))
                {
                    deleteLocation = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AcsRecordingChunkInfoProperties(documentId.Value, Optional.ToNullable(index), endReason.Value, metadataLocation.Value, contentLocation.Value, deleteLocation.Value, rawData);
        }

        AcsRecordingChunkInfoProperties IModelJsonSerializable<AcsRecordingChunkInfoProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsRecordingChunkInfoProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRecordingChunkInfoProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsRecordingChunkInfoProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsRecordingChunkInfoProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsRecordingChunkInfoProperties IModelSerializable<AcsRecordingChunkInfoProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsRecordingChunkInfoProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsRecordingChunkInfoProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AcsRecordingChunkInfoProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AcsRecordingChunkInfoProperties"/> to convert. </param>
        public static implicit operator RequestContent(AcsRecordingChunkInfoProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AcsRecordingChunkInfoProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AcsRecordingChunkInfoProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsRecordingChunkInfoProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
