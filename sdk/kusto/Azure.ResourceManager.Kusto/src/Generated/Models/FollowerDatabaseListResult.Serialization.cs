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

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class FollowerDatabaseListResult : IUtf8JsonSerializable, IModelJsonSerializable<FollowerDatabaseListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FollowerDatabaseListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FollowerDatabaseListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FollowerDatabaseListResult>(this, options.Format);

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
                        ((IModelJsonSerializable<KustoFollowerDatabaseDefinition>)item).Serialize(writer, options);
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

        internal static FollowerDatabaseListResult DeserializeFollowerDatabaseListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<KustoFollowerDatabaseDefinition>> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KustoFollowerDatabaseDefinition> array = new List<KustoFollowerDatabaseDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoFollowerDatabaseDefinition.DeserializeKustoFollowerDatabaseDefinition(item));
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
            return new FollowerDatabaseListResult(Optional.ToList(value), serializedAdditionalRawData);
        }

        FollowerDatabaseListResult IModelJsonSerializable<FollowerDatabaseListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FollowerDatabaseListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFollowerDatabaseListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FollowerDatabaseListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FollowerDatabaseListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FollowerDatabaseListResult IModelSerializable<FollowerDatabaseListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FollowerDatabaseListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFollowerDatabaseListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FollowerDatabaseListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FollowerDatabaseListResult"/> to convert. </param>
        public static implicit operator RequestContent(FollowerDatabaseListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FollowerDatabaseListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FollowerDatabaseListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFollowerDatabaseListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
