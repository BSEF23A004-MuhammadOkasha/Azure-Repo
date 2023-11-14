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

namespace Azure.Monitor.Query.Models
{
    public partial class MetricResult : IUtf8JsonSerializable, IJsonModel<MetricResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MetricResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MetricResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MetricResult>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceType);
            writer.WritePropertyName("name"u8);
            writer.WriteObjectValue(LocalizedName);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("displayDescription"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            writer.WritePropertyName("unit"u8);
            writer.WriteStringValue(Unit.ToString());
            writer.WritePropertyName("timeseries"u8);
            writer.WriteStartArray();
            foreach (var item in TimeSeries)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        MetricResult IJsonModel<MetricResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricResult(document.RootElement, options);
        }

        internal static MetricResult DeserializeMetricResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string type = default;
            LocalizableString name = default;
            Optional<string> displayDescription = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            MetricUnit unit = default;
            IReadOnlyList<MetricTimeSeriesElement> timeseries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = LocalizableString.DeserializeLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("displayDescription"u8))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = new MetricUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeseries"u8))
                {
                    List<MetricTimeSeriesElement> array = new List<MetricTimeSeriesElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricTimeSeriesElement.DeserializeMetricTimeSeriesElement(item));
                    }
                    timeseries = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricResult(id, type, name, displayDescription.Value, errorCode.Value, errorMessage.Value, unit, timeseries, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MetricResult IPersistableModel<MetricResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMetricResult(document.RootElement, options);
        }

        string IPersistableModel<MetricResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
