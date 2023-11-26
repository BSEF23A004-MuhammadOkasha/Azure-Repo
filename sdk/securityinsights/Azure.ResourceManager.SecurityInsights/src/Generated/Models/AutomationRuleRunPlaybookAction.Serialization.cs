// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRuleRunPlaybookAction : IUtf8JsonSerializable, IJsonModel<AutomationRuleRunPlaybookAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationRuleRunPlaybookAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationRuleRunPlaybookAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleRunPlaybookAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AutomationRuleRunPlaybookAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionConfiguration))
            {
                writer.WritePropertyName("actionConfiguration"u8);
                writer.WriteObjectValue(ActionConfiguration);
            }
            writer.WritePropertyName("order"u8);
            writer.WriteNumberValue(Order);
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        AutomationRuleRunPlaybookAction IJsonModel<AutomationRuleRunPlaybookAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleRunPlaybookAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AutomationRuleRunPlaybookAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRuleRunPlaybookAction(document.RootElement, options);
        }

        internal static AutomationRuleRunPlaybookAction DeserializeAutomationRuleRunPlaybookAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationRuleRunPlaybookActionProperties> actionConfiguration = default;
            int order = default;
            ActionType actionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionConfiguration = AutomationRuleRunPlaybookActionProperties.DeserializeAutomationRuleRunPlaybookActionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationRuleRunPlaybookAction(order, actionType, serializedAdditionalRawData, actionConfiguration.Value);
        }

        BinaryData IPersistableModel<AutomationRuleRunPlaybookAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleRunPlaybookAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AutomationRuleRunPlaybookAction)} does not support '{options.Format}' format.");
            }
        }

        AutomationRuleRunPlaybookAction IPersistableModel<AutomationRuleRunPlaybookAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleRunPlaybookAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationRuleRunPlaybookAction(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AutomationRuleRunPlaybookAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationRuleRunPlaybookAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
