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

namespace Azure.Maps.Search.Models
{
    public partial class SearchAddressBatchResult : IUtf8JsonSerializable, IModelJsonSerializable<SearchAddressBatchResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchAddressBatchResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchAddressBatchResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static SearchAddressBatchResult DeserializeSearchAddressBatchResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SearchAddressBatchItem>> batchItems = default;
            Optional<BatchResultSummary> summary = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchAddressBatchItem> array = new List<SearchAddressBatchItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchAddressBatchItem.DeserializeSearchAddressBatchItem(item));
                    }
                    batchItems = array;
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = BatchResultSummary.DeserializeBatchResultSummary(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchAddressBatchResult(summary.Value, Optional.ToList(batchItems), serializedAdditionalRawData);
        }

        SearchAddressBatchResult IModelJsonSerializable<SearchAddressBatchResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchAddressBatchResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchAddressBatchResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchAddressBatchResult IModelSerializable<SearchAddressBatchResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchAddressBatchResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchAddressBatchResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchAddressBatchResult"/> to convert. </param>
        public static implicit operator RequestContent(SearchAddressBatchResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchAddressBatchResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchAddressBatchResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchAddressBatchResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
