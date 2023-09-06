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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    internal partial class AnalyzeDocumentRequest : IUtf8JsonSerializable, IModelJsonSerializable<AnalyzeDocumentRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnalyzeDocumentRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnalyzeDocumentRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeDocumentRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UrlSource))
            {
                writer.WritePropertyName("urlSource"u8);
                writer.WriteStringValue(UrlSource.AbsoluteUri);
            }
            if (Optional.IsDefined(Base64Source))
            {
                writer.WritePropertyName("base64Source"u8);
                writer.WriteBase64StringValue(Base64Source, "D");
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

        internal static AnalyzeDocumentRequest DeserializeAnalyzeDocumentRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> urlSource = default;
            Optional<byte[]> base64Source = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("urlSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    urlSource = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("base64Source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    base64Source = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AnalyzeDocumentRequest(urlSource.Value, base64Source.Value, rawData);
        }

        AnalyzeDocumentRequest IModelJsonSerializable<AnalyzeDocumentRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeDocumentRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeDocumentRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnalyzeDocumentRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeDocumentRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnalyzeDocumentRequest IModelSerializable<AnalyzeDocumentRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyzeDocumentRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnalyzeDocumentRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AnalyzeDocumentRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AnalyzeDocumentRequest"/> to convert. </param>
        public static implicit operator RequestContent(AnalyzeDocumentRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AnalyzeDocumentRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AnalyzeDocumentRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnalyzeDocumentRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
