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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorAutomationRunbookReceiver : IUtf8JsonSerializable, IJsonModel<MonitorAutomationRunbookReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorAutomationRunbookReceiver>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MonitorAutomationRunbookReceiver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("automationAccountId"u8);
            writer.WriteStringValue(AutomationAccountId);
            writer.WritePropertyName("runbookName"u8);
            writer.WriteStringValue(RunbookName);
            writer.WritePropertyName("webhookResourceId"u8);
            writer.WriteStringValue(WebhookResourceId);
            writer.WritePropertyName("isGlobalRunbook"u8);
            writer.WriteBooleanValue(IsGlobalRunbook);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUri"u8);
                writer.WriteStringValue(ServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MonitorAutomationRunbookReceiver IJsonModel<MonitorAutomationRunbookReceiver>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorAutomationRunbookReceiver)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorAutomationRunbookReceiver(document.RootElement, options);
        }

        internal static MonitorAutomationRunbookReceiver DeserializeMonitorAutomationRunbookReceiver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier automationAccountId = default;
            string runbookName = default;
            ResourceIdentifier webhookResourceId = default;
            bool isGlobalRunbook = default;
            Optional<string> name = default;
            Optional<Uri> serviceUri = default;
            Optional<bool> useCommonAlertSchema = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automationAccountId"u8))
                {
                    automationAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runbookName"u8))
                {
                    runbookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webhookResourceId"u8))
                {
                    webhookResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isGlobalRunbook"u8))
                {
                    isGlobalRunbook = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorAutomationRunbookReceiver(automationAccountId, runbookName, webhookResourceId, isGlobalRunbook, name.Value, serviceUri.Value, Optional.ToNullable(useCommonAlertSchema), serializedAdditionalRawData);
        }

        BinaryData IModel<MonitorAutomationRunbookReceiver>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorAutomationRunbookReceiver)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MonitorAutomationRunbookReceiver IModel<MonitorAutomationRunbookReceiver>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorAutomationRunbookReceiver)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMonitorAutomationRunbookReceiver(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MonitorAutomationRunbookReceiver>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
