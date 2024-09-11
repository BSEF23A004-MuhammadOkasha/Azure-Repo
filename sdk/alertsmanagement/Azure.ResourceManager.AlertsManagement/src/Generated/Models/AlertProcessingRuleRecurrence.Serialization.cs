// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    [PersistableModelProxy(typeof(UnknownRecurrence))]
    public partial class AlertProcessingRuleRecurrence : IUtf8JsonSerializable, IJsonModel<AlertProcessingRuleRecurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertProcessingRuleRecurrence>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AlertProcessingRuleRecurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleRecurrence)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("recurrenceType"u8);
            writer.WriteStringValue(RecurrenceType.ToString());
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "T");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "T");
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
        }

        AlertProcessingRuleRecurrence IJsonModel<AlertProcessingRuleRecurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleRecurrence)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertProcessingRuleRecurrence(document.RootElement, options);
        }

        internal static AlertProcessingRuleRecurrence DeserializeAlertProcessingRuleRecurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("recurrenceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Daily": return DailyRecurrence.DeserializeDailyRecurrence(element, options);
                    case "Monthly": return AlertProcessingRuleMonthlyRecurrence.DeserializeAlertProcessingRuleMonthlyRecurrence(element, options);
                    case "Weekly": return AlertProcessingRuleWeeklyRecurrence.DeserializeAlertProcessingRuleWeeklyRecurrence(element, options);
                }
            }
            return UnknownRecurrence.DeserializeUnknownRecurrence(element, options);
        }

        BinaryData IPersistableModel<AlertProcessingRuleRecurrence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleRecurrence)} does not support writing '{options.Format}' format.");
            }
        }

        AlertProcessingRuleRecurrence IPersistableModel<AlertProcessingRuleRecurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertProcessingRuleRecurrence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleRecurrence)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertProcessingRuleRecurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
