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
    public partial class DataFeedDimension : IUtf8JsonSerializable, IModelJsonSerializable<DataFeedDimension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFeedDimension>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFeedDimension>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFeedDimension>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("dimensionName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("dimensionDisplayName"u8);
                writer.WriteStringValue(DisplayName);
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

        internal static DataFeedDimension DeserializeDataFeedDimension(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dimensionName = default;
            Optional<string> dimensionDisplayName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionDisplayName"u8))
                {
                    dimensionDisplayName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataFeedDimension(dimensionName, dimensionDisplayName.Value, rawData);
        }

        DataFeedDimension IModelJsonSerializable<DataFeedDimension>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFeedDimension>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFeedDimension(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFeedDimension>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFeedDimension>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFeedDimension IModelSerializable<DataFeedDimension>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFeedDimension>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFeedDimension(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFeedDimension"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFeedDimension"/> to convert. </param>
        public static implicit operator RequestContent(DataFeedDimension model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFeedDimension"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFeedDimension(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFeedDimension(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
