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
    public partial class CbcsDrmConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<CbcsDrmConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CbcsDrmConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CbcsDrmConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CbcsDrmConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FairPlay))
            {
                writer.WritePropertyName("fairPlay"u8);
                if (FairPlay is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StreamingPolicyFairPlayConfiguration>)FairPlay).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PlayReady))
            {
                writer.WritePropertyName("playReady"u8);
                if (PlayReady is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StreamingPolicyPlayReadyConfiguration>)PlayReady).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Widevine))
            {
                writer.WritePropertyName("widevine"u8);
                if (Widevine is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StreamingPolicyWidevineConfiguration>)Widevine).Serialize(writer, options);
                }
            }
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

        internal static CbcsDrmConfiguration DeserializeCbcsDrmConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StreamingPolicyFairPlayConfiguration> fairPlay = default;
            Optional<StreamingPolicyPlayReadyConfiguration> playReady = default;
            Optional<StreamingPolicyWidevineConfiguration> widevine = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fairPlay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fairPlay = StreamingPolicyFairPlayConfiguration.DeserializeStreamingPolicyFairPlayConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("playReady"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playReady = StreamingPolicyPlayReadyConfiguration.DeserializeStreamingPolicyPlayReadyConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("widevine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    widevine = StreamingPolicyWidevineConfiguration.DeserializeStreamingPolicyWidevineConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CbcsDrmConfiguration(fairPlay.Value, playReady.Value, widevine.Value, serializedAdditionalRawData);
        }

        CbcsDrmConfiguration IModelJsonSerializable<CbcsDrmConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CbcsDrmConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCbcsDrmConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CbcsDrmConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CbcsDrmConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CbcsDrmConfiguration IModelSerializable<CbcsDrmConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CbcsDrmConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCbcsDrmConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CbcsDrmConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CbcsDrmConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(CbcsDrmConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CbcsDrmConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CbcsDrmConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCbcsDrmConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
