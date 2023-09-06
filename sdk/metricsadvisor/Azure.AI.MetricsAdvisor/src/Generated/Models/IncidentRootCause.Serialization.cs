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

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class IncidentRootCause : IUtf8JsonSerializable, IModelJsonSerializable<IncidentRootCause>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IncidentRootCause>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IncidentRootCause>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IncidentRootCause>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("rootCause"u8);
            if (SeriesKey is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DimensionKey>)SeriesKey).Serialize(writer, options);
            }
            writer.WritePropertyName("path"u8);
            writer.WriteStartArray();
            foreach (var item in Paths)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("score"u8);
            writer.WriteNumberValue(ContributionScore);
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
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

        internal static IncidentRootCause DeserializeIncidentRootCause(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DimensionKey rootCause = default;
            IReadOnlyList<string> path = default;
            double score = default;
            string description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rootCause"u8))
                {
                    rootCause = DimensionKey.DeserializeDimensionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    path = array;
                    continue;
                }
                if (property.NameEquals("score"u8))
                {
                    score = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IncidentRootCause(rootCause, path, score, description, rawData);
        }

        IncidentRootCause IModelJsonSerializable<IncidentRootCause>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IncidentRootCause>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIncidentRootCause(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IncidentRootCause>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IncidentRootCause>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IncidentRootCause IModelSerializable<IncidentRootCause>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IncidentRootCause>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIncidentRootCause(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IncidentRootCause"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IncidentRootCause"/> to convert. </param>
        public static implicit operator RequestContent(IncidentRootCause model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IncidentRootCause"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IncidentRootCause(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIncidentRootCause(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
