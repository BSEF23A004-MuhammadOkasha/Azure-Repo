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
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class DatastoreResourceArmPaginatedResult : IUtf8JsonSerializable, IModelJsonSerializable<DatastoreResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatastoreResourceArmPaginatedResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatastoreResourceArmPaginatedResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreResourceArmPaginatedResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
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
                        ((IModelJsonSerializable<MachineLearningDatastoreData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static DatastoreResourceArmPaginatedResult DeserializeDatastoreResourceArmPaginatedResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningDatastoreData>> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningDatastoreData> array = new List<MachineLearningDatastoreData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningDatastoreData.DeserializeMachineLearningDatastoreData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DatastoreResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value), serializedAdditionalRawData);
        }

        DatastoreResourceArmPaginatedResult IModelJsonSerializable<DatastoreResourceArmPaginatedResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreResourceArmPaginatedResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatastoreResourceArmPaginatedResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatastoreResourceArmPaginatedResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreResourceArmPaginatedResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatastoreResourceArmPaginatedResult IModelSerializable<DatastoreResourceArmPaginatedResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatastoreResourceArmPaginatedResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatastoreResourceArmPaginatedResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DatastoreResourceArmPaginatedResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DatastoreResourceArmPaginatedResult"/> to convert. </param>
        public static implicit operator RequestContent(DatastoreResourceArmPaginatedResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DatastoreResourceArmPaginatedResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DatastoreResourceArmPaginatedResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatastoreResourceArmPaginatedResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
