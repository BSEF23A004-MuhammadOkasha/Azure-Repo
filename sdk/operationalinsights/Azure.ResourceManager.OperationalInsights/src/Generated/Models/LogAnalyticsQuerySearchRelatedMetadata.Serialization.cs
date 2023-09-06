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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class LogAnalyticsQuerySearchRelatedMetadata : IUtf8JsonSerializable, IModelJsonSerializable<LogAnalyticsQuerySearchRelatedMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogAnalyticsQuerySearchRelatedMetadata>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogAnalyticsQuerySearchRelatedMetadata>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogAnalyticsQuerySearchRelatedMetadata>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Solutions))
            {
                writer.WritePropertyName("solutions"u8);
                writer.WriteStartArray();
                foreach (var item in Solutions)
                {
                    writer.WriteStringValue(item);
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

        internal static LogAnalyticsQuerySearchRelatedMetadata DeserializeLogAnalyticsQuerySearchRelatedMetadata(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> categories = default;
            Optional<IList<string>> resourceTypes = default;
            Optional<IList<string>> solutions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("resourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("solutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    solutions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogAnalyticsQuerySearchRelatedMetadata(Optional.ToList(categories), Optional.ToList(resourceTypes), Optional.ToList(solutions), rawData);
        }

        LogAnalyticsQuerySearchRelatedMetadata IModelJsonSerializable<LogAnalyticsQuerySearchRelatedMetadata>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogAnalyticsQuerySearchRelatedMetadata>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogAnalyticsQuerySearchRelatedMetadata(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogAnalyticsQuerySearchRelatedMetadata>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogAnalyticsQuerySearchRelatedMetadata>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogAnalyticsQuerySearchRelatedMetadata IModelSerializable<LogAnalyticsQuerySearchRelatedMetadata>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogAnalyticsQuerySearchRelatedMetadata>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogAnalyticsQuerySearchRelatedMetadata(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogAnalyticsQuerySearchRelatedMetadata"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogAnalyticsQuerySearchRelatedMetadata"/> to convert. </param>
        public static implicit operator RequestContent(LogAnalyticsQuerySearchRelatedMetadata model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogAnalyticsQuerySearchRelatedMetadata"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogAnalyticsQuerySearchRelatedMetadata(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogAnalyticsQuerySearchRelatedMetadata(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
