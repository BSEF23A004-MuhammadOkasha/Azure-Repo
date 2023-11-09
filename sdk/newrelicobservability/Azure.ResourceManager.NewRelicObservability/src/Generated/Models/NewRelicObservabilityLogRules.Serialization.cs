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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityLogRules : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityLogRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityLogRules>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NewRelicObservabilityLogRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs"u8);
                writer.WriteStringValue(SendAadLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs"u8);
                writer.WriteStringValue(SendSubscriptionLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendActivityLogs))
            {
                writer.WritePropertyName("sendActivityLogs"u8);
                writer.WriteStringValue(SendActivityLogs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        NewRelicObservabilityLogRules IJsonModel<NewRelicObservabilityLogRules>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityLogRules(document.RootElement, options);
        }

        internal static NewRelicObservabilityLogRules DeserializeNewRelicObservabilityLogRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NewRelicObservabilitySendAadLogsStatus> sendAadLogs = default;
            Optional<NewRelicObservabilitySendSubscriptionLogsStatus> sendSubscriptionLogs = default;
            Optional<NewRelicObservabilitySendActivityLogsStatus> sendActivityLogs = default;
            Optional<IList<NewRelicObservabilityFilteringTag>> filteringTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendAadLogs = new NewRelicObservabilitySendAadLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendSubscriptionLogs = new NewRelicObservabilitySendSubscriptionLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendActivityLogs = new NewRelicObservabilitySendActivityLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewRelicObservabilityFilteringTag> array = new List<NewRelicObservabilityFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicObservabilityFilteringTag.DeserializeNewRelicObservabilityFilteringTag(item));
                    }
                    filteringTags = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRelicObservabilityLogRules(Optional.ToNullable(sendAadLogs), Optional.ToNullable(sendSubscriptionLogs), Optional.ToNullable(sendActivityLogs), Optional.ToList(filteringTags), serializedAdditionalRawData);
        }

        BinaryData IModel<NewRelicObservabilityLogRules>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NewRelicObservabilityLogRules IModel<NewRelicObservabilityLogRules>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNewRelicObservabilityLogRules(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NewRelicObservabilityLogRules>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
