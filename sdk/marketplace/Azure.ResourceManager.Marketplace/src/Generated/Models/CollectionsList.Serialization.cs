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
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    internal partial class CollectionsList : IUtf8JsonSerializable, IModelJsonSerializable<CollectionsList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CollectionsList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CollectionsList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CollectionsList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
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
                        ((IModelJsonSerializable<PrivateStoreCollectionInfoData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static CollectionsList DeserializeCollectionsList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PrivateStoreCollectionInfoData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionInfoData> array = new List<PrivateStoreCollectionInfoData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(item));
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
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CollectionsList(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        CollectionsList IModelJsonSerializable<CollectionsList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CollectionsList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCollectionsList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CollectionsList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CollectionsList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CollectionsList IModelSerializable<CollectionsList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CollectionsList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCollectionsList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CollectionsList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CollectionsList"/> to convert. </param>
        public static implicit operator RequestContent(CollectionsList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CollectionsList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CollectionsList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCollectionsList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
