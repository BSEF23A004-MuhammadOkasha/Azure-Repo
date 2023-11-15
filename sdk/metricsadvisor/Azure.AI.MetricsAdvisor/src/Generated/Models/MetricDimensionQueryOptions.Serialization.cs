// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class MetricDimensionQueryOptions : IUtf8JsonSerializable, IJsonModel<MetricDimensionQueryOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricDimensionQueryOptions>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MetricDimensionQueryOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MetricDimensionQueryOptions>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MetricDimensionQueryOptions>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dimensionName"u8);
            writer.WriteStringValue(DimensionName);
            if (Optional.IsDefined(DimensionValueFilter))
            {
                writer.WritePropertyName("dimensionValueFilter"u8);
                writer.WriteStringValue(DimensionValueFilter);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        MetricDimensionQueryOptions IJsonModel<MetricDimensionQueryOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricDimensionQueryOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricDimensionQueryOptions(document.RootElement, options);
        }

        internal static MetricDimensionQueryOptions DeserializeMetricDimensionQueryOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dimensionName = default;
            Optional<string> dimensionValueFilter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionValueFilter"u8))
                {
                    dimensionValueFilter = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricDimensionQueryOptions(dimensionName, dimensionValueFilter.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricDimensionQueryOptions>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricDimensionQueryOptions)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MetricDimensionQueryOptions IPersistableModel<MetricDimensionQueryOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricDimensionQueryOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMetricDimensionQueryOptions(document.RootElement, options);
        }

        string IPersistableModel<MetricDimensionQueryOptions>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
