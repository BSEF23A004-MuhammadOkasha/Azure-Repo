// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class AutomationRunbookTaskDetails : IUtf8JsonSerializable, IJsonModel<AutomationRunbookTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationRunbookTaskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationRunbookTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (CloudServiceName != null)
            {
                writer.WritePropertyName("cloudServiceName"u8);
                writer.WriteStringValue(CloudServiceName);
            }
            if (SubscriptionId != null)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (AccountName != null)
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (RunbookId != null)
            {
                writer.WritePropertyName("runbookId"u8);
                writer.WriteStringValue(RunbookId);
            }
            if (RunbookName != null)
            {
                writer.WritePropertyName("runbookName"u8);
                writer.WriteStringValue(RunbookName);
            }
            if (JobId != null)
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (JobOutput != null)
            {
                writer.WritePropertyName("jobOutput"u8);
                writer.WriteStringValue(JobOutput);
            }
            if (IsPrimarySideScript.HasValue)
            {
                writer.WritePropertyName("isPrimarySideScript"u8);
                writer.WriteBooleanValue(IsPrimarySideScript.Value);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        AutomationRunbookTaskDetails IJsonModel<AutomationRunbookTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRunbookTaskDetails(document.RootElement, options);
        }

        internal static AutomationRunbookTaskDetails DeserializeAutomationRunbookTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> cloudServiceName = default;
            Optional<string> subscriptionId = default;
            Optional<string> accountName = default;
            Optional<string> runbookId = default;
            Optional<string> runbookName = default;
            Optional<ResourceIdentifier> jobId = default;
            Optional<string> jobOutput = default;
            Optional<bool> isPrimarySideScript = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudServiceName"u8))
                {
                    cloudServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookId"u8))
                {
                    runbookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookName"u8))
                {
                    runbookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobOutput"u8))
                {
                    jobOutput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimarySideScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimarySideScript = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationRunbookTaskDetails(instanceType, serializedAdditionalRawData, name.Value, cloudServiceName.Value, subscriptionId.Value, accountName.Value, runbookId.Value, runbookName.Value, jobId.Value, jobOutput.Value, Optional.ToNullable(isPrimarySideScript));
        }

        BinaryData IPersistableModel<AutomationRunbookTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        AutomationRunbookTaskDetails IPersistableModel<AutomationRunbookTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationRunbookTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationRunbookTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
