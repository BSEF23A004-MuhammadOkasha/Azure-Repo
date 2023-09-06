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

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class V2AnalyzeResult : IUtf8JsonSerializable, IModelJsonSerializable<V2AnalyzeResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<V2AnalyzeResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<V2AnalyzeResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2AnalyzeResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("version"u8);
            writer.WriteStringValue(Version);
            if (Optional.IsCollectionDefined(ReadResults))
            {
                if (ReadResults != null)
                {
                    writer.WritePropertyName("readResults"u8);
                    writer.WriteStartArray();
                    foreach (var item in ReadResults)
                    {
                        if (item is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<ReadResult>)item).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("readResults");
                }
            }
            if (Optional.IsCollectionDefined(PageResults))
            {
                if (PageResults != null)
                {
                    writer.WritePropertyName("pageResults"u8);
                    writer.WriteStartArray();
                    foreach (var item in PageResults)
                    {
                        if (item is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<PageResult>)item).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("pageResults");
                }
            }
            if (Optional.IsCollectionDefined(DocumentResults))
            {
                if (DocumentResults != null)
                {
                    writer.WritePropertyName("documentResults"u8);
                    writer.WriteStartArray();
                    foreach (var item in DocumentResults)
                    {
                        if (item is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<DocumentResult>)item).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("documentResults");
                }
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<FormRecognizerError>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static V2AnalyzeResult DeserializeV2AnalyzeResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string version = default;
            Optional<IReadOnlyList<ReadResult>> readResults = default;
            Optional<IReadOnlyList<PageResult>> pageResults = default;
            Optional<IReadOnlyList<DocumentResult>> documentResults = default;
            Optional<IReadOnlyList<FormRecognizerError>> errors = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readResults = null;
                        continue;
                    }
                    List<ReadResult> array = new List<ReadResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReadResult.DeserializeReadResult(item));
                    }
                    readResults = array;
                    continue;
                }
                if (property.NameEquals("pageResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pageResults = null;
                        continue;
                    }
                    List<PageResult> array = new List<PageResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PageResult.DeserializePageResult(item));
                    }
                    pageResults = array;
                    continue;
                }
                if (property.NameEquals("documentResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        documentResults = null;
                        continue;
                    }
                    List<DocumentResult> array = new List<DocumentResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentResult.DeserializeDocumentResult(item));
                    }
                    documentResults = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new V2AnalyzeResult(version, Optional.ToList(readResults), Optional.ToList(pageResults), Optional.ToList(documentResults), Optional.ToList(errors), rawData);
        }

        V2AnalyzeResult IModelJsonSerializable<V2AnalyzeResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2AnalyzeResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeV2AnalyzeResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<V2AnalyzeResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2AnalyzeResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        V2AnalyzeResult IModelSerializable<V2AnalyzeResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2AnalyzeResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeV2AnalyzeResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="V2AnalyzeResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="V2AnalyzeResult"/> to convert. </param>
        public static implicit operator RequestContent(V2AnalyzeResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="V2AnalyzeResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator V2AnalyzeResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeV2AnalyzeResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
