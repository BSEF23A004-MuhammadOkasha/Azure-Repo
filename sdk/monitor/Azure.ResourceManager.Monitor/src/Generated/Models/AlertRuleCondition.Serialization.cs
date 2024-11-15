// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    [PersistableModelProxy(typeof(UnknownRuleCondition))]
    public partial class AlertRuleCondition : IUtf8JsonSerializable, IJsonModel<AlertRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertRuleCondition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AlertRuleCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertRuleCondition)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource"u8);
                writer.WriteObjectValue(DataSource, options);
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

        AlertRuleCondition IJsonModel<AlertRuleCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertRuleCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertRuleCondition(document.RootElement, options);
        }

        internal static AlertRuleCondition DeserializeAlertRuleCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Management.Insights.Models.LocationThresholdRuleCondition": return LocationThresholdRuleCondition.DeserializeLocationThresholdRuleCondition(element, options);
                    case "Microsoft.Azure.Management.Insights.Models.ManagementEventRuleCondition": return ManagementEventRuleCondition.DeserializeManagementEventRuleCondition(element, options);
                    case "Microsoft.Azure.Management.Insights.Models.ThresholdRuleCondition": return ThresholdRuleCondition.DeserializeThresholdRuleCondition(element, options);
                }
            }
            return UnknownRuleCondition.DeserializeUnknownRuleCondition(element, options);
        }

        BinaryData IPersistableModel<AlertRuleCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlertRuleCondition)} does not support writing '{options.Format}' format.");
            }
        }

        AlertRuleCondition IPersistableModel<AlertRuleCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertRuleCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlertRuleCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertRuleCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
