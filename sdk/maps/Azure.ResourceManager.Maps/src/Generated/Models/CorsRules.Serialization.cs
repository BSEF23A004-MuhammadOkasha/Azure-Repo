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

namespace Azure.ResourceManager.Maps.Models
{
    internal partial class CorsRules : IUtf8JsonSerializable, IModelJsonSerializable<CorsRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CorsRules>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CorsRules>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CorsRules>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CorsRulesValue))
            {
                writer.WritePropertyName("corsRules"u8);
                writer.WriteStartArray();
                foreach (var item in CorsRulesValue)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MapsCorsRule>)item).Serialize(writer, options);
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

        internal static CorsRules DeserializeCorsRules(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MapsCorsRule>> corsRules = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("corsRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapsCorsRule> array = new List<MapsCorsRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsCorsRule.DeserializeMapsCorsRule(item));
                    }
                    corsRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CorsRules(Optional.ToList(corsRules), serializedAdditionalRawData);
        }

        CorsRules IModelJsonSerializable<CorsRules>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CorsRules>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCorsRules(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CorsRules>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CorsRules>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CorsRules IModelSerializable<CorsRules>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CorsRules>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCorsRules(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CorsRules"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CorsRules"/> to convert. </param>
        public static implicit operator RequestContent(CorsRules model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CorsRules"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CorsRules(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCorsRules(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
