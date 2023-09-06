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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    internal partial class PredefinedUrlCategoryListResult : IUtf8JsonSerializable, IModelJsonSerializable<PredefinedUrlCategoryListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PredefinedUrlCategoryListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PredefinedUrlCategoryListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredefinedUrlCategoryListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PredefinedUrlCategory>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static PredefinedUrlCategoryListResult DeserializePredefinedUrlCategoryListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PredefinedUrlCategory> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<PredefinedUrlCategory> array = new List<PredefinedUrlCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredefinedUrlCategory.DeserializePredefinedUrlCategory(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PredefinedUrlCategoryListResult(value, nextLink.Value, rawData);
        }

        PredefinedUrlCategoryListResult IModelJsonSerializable<PredefinedUrlCategoryListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredefinedUrlCategoryListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePredefinedUrlCategoryListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PredefinedUrlCategoryListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredefinedUrlCategoryListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PredefinedUrlCategoryListResult IModelSerializable<PredefinedUrlCategoryListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredefinedUrlCategoryListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePredefinedUrlCategoryListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PredefinedUrlCategoryListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PredefinedUrlCategoryListResult"/> to convert. </param>
        public static implicit operator RequestContent(PredefinedUrlCategoryListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PredefinedUrlCategoryListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PredefinedUrlCategoryListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePredefinedUrlCategoryListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
