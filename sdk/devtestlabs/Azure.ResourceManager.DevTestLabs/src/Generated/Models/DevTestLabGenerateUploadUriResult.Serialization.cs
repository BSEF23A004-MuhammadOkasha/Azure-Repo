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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabGenerateUploadUriResult : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabGenerateUploadUriResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabGenerateUploadUriResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabGenerateUploadUriResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabGenerateUploadUriResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UploadUri))
            {
                writer.WritePropertyName("uploadUri"u8);
                writer.WriteStringValue(UploadUri.AbsoluteUri);
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

        internal static DevTestLabGenerateUploadUriResult DeserializeDevTestLabGenerateUploadUriResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> uploadUri = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uploadUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabGenerateUploadUriResult(uploadUri.Value, rawData);
        }

        DevTestLabGenerateUploadUriResult IModelJsonSerializable<DevTestLabGenerateUploadUriResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabGenerateUploadUriResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabGenerateUploadUriResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabGenerateUploadUriResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabGenerateUploadUriResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabGenerateUploadUriResult IModelSerializable<DevTestLabGenerateUploadUriResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabGenerateUploadUriResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabGenerateUploadUriResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabGenerateUploadUriResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabGenerateUploadUriResult"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabGenerateUploadUriResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabGenerateUploadUriResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabGenerateUploadUriResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabGenerateUploadUriResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
