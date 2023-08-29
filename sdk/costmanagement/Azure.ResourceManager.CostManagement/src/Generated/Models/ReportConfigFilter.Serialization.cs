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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ReportConfigFilter : IUtf8JsonSerializable, IModelJsonSerializable<ReportConfigFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReportConfigFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReportConfigFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(And))
            {
                writer.WritePropertyName("and"u8);
                writer.WriteStartArray();
                foreach (var item in And)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Or))
            {
                writer.WritePropertyName("or"u8);
                writer.WriteStartArray();
                foreach (var item in Or)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteObjectValue(Dimensions);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteObjectValue(Tags);
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

        internal static ReportConfigFilter DeserializeReportConfigFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ReportConfigFilter>> and = default;
            Optional<IList<ReportConfigFilter>> or = default;
            Optional<ReportConfigComparisonExpression> dimensions = default;
            Optional<ReportConfigComparisonExpression> tags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("and"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportConfigFilter> array = new List<ReportConfigFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeReportConfigFilter(item));
                    }
                    and = array;
                    continue;
                }
                if (property.NameEquals("or"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportConfigFilter> array = new List<ReportConfigFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeReportConfigFilter(item));
                    }
                    or = array;
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dimensions = ReportConfigComparisonExpression.DeserializeReportConfigComparisonExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = ReportConfigComparisonExpression.DeserializeReportConfigComparisonExpression(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReportConfigFilter(Optional.ToList(and), Optional.ToList(or), dimensions.Value, tags.Value, rawData);
        }

        ReportConfigFilter IModelJsonSerializable<ReportConfigFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReportConfigFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReportConfigFilter>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReportConfigFilter IModelSerializable<ReportConfigFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReportConfigFilter(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ReportConfigFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ReportConfigFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReportConfigFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
