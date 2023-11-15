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
    internal partial class PeriodFeedbackValue : IUtf8JsonSerializable, IJsonModel<PeriodFeedbackValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeriodFeedbackValue>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PeriodFeedbackValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PeriodFeedbackValue>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PeriodFeedbackValue>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("periodType"u8);
            writer.WriteStringValue(PeriodType.ToString());
            writer.WritePropertyName("periodValue"u8);
            writer.WriteNumberValue(PeriodValue);
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

        PeriodFeedbackValue IJsonModel<PeriodFeedbackValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PeriodFeedbackValue)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeriodFeedbackValue(document.RootElement, options);
        }

        internal static PeriodFeedbackValue DeserializePeriodFeedbackValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MetricPeriodType periodType = default;
            int periodValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("periodType"u8))
                {
                    periodType = new MetricPeriodType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("periodValue"u8))
                {
                    periodValue = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeriodFeedbackValue(periodType, periodValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeriodFeedbackValue>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PeriodFeedbackValue)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PeriodFeedbackValue IPersistableModel<PeriodFeedbackValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PeriodFeedbackValue)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePeriodFeedbackValue(document.RootElement, options);
        }

        string IPersistableModel<PeriodFeedbackValue>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
