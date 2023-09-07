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
    internal partial class JobBaseResourceArmPaginatedResult : IUtf8JsonSerializable, IModelJsonSerializable<JobBaseResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JobBaseResourceArmPaginatedResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JobBaseResourceArmPaginatedResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JobBaseResourceArmPaginatedResult>(this, options.Format);

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
                        ((IModelJsonSerializable<MachineLearningJobData>)item).Serialize(writer, options);
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

        internal static JobBaseResourceArmPaginatedResult DeserializeJobBaseResourceArmPaginatedResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningJobData>> value = default;
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
                    List<MachineLearningJobData> array = new List<MachineLearningJobData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningJobData.DeserializeMachineLearningJobData(item));
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
            return new JobBaseResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value), serializedAdditionalRawData);
        }

        JobBaseResourceArmPaginatedResult IModelJsonSerializable<JobBaseResourceArmPaginatedResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JobBaseResourceArmPaginatedResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJobBaseResourceArmPaginatedResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JobBaseResourceArmPaginatedResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JobBaseResourceArmPaginatedResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JobBaseResourceArmPaginatedResult IModelSerializable<JobBaseResourceArmPaginatedResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<JobBaseResourceArmPaginatedResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJobBaseResourceArmPaginatedResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JobBaseResourceArmPaginatedResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JobBaseResourceArmPaginatedResult"/> to convert. </param>
        public static implicit operator RequestContent(JobBaseResourceArmPaginatedResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JobBaseResourceArmPaginatedResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JobBaseResourceArmPaginatedResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJobBaseResourceArmPaginatedResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
