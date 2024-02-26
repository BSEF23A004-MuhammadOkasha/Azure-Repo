// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ForecastFilter : IUtf8JsonSerializable, IJsonModel<ForecastFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForecastFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ForecastFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastFilter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(And is ChangeTrackingList<ForecastFilter> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("and"u8);
                writer.WriteStartArray();
                foreach (var item in And)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Or is ChangeTrackingList<ForecastFilter> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("or"u8);
                writer.WriteStartArray();
                foreach (var item in Or)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Dimensions != null)
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteObjectValue(Dimensions);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteObjectValue(Tags);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ForecastFilter IJsonModel<ForecastFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastFilter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastFilter(document.RootElement, options);
        }

        internal static ForecastFilter DeserializeForecastFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ForecastFilter> and = default;
            IList<ForecastFilter> or = default;
            Optional<ForecastComparisonExpression> dimensions = default;
            Optional<ForecastComparisonExpression> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("and"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ForecastFilter> array = new List<ForecastFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeForecastFilter(item, options));
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
                    List<ForecastFilter> array = new List<ForecastFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeForecastFilter(item, options));
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
                    dimensions = ForecastComparisonExpression.DeserializeForecastComparisonExpression(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = ForecastComparisonExpression.DeserializeForecastComparisonExpression(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ForecastFilter(and ?? new ChangeTrackingList<ForecastFilter>(), or ?? new ChangeTrackingList<ForecastFilter>(), dimensions.Value, tags.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ForecastFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ForecastFilter)} does not support '{options.Format}' format.");
            }
        }

        ForecastFilter IPersistableModel<ForecastFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeForecastFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ForecastFilter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForecastFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
