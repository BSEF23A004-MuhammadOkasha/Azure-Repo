// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TriggerRunConverter))]
    public partial class TriggerRun : IUtf8JsonSerializable, IJsonModel<TriggerRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TriggerRun>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<TriggerRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TriggerRun>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TriggerRun>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TriggerRunId))
                {
                    writer.WritePropertyName("triggerRunId"u8);
                    writer.WriteStringValue(TriggerRunId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TriggerName))
                {
                    writer.WritePropertyName("triggerName"u8);
                    writer.WriteStringValue(TriggerName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TriggerType))
                {
                    writer.WritePropertyName("triggerType"u8);
                    writer.WriteStringValue(TriggerType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TriggerRunTimestamp))
                {
                    writer.WritePropertyName("triggerRunTimestamp"u8);
                    writer.WriteStringValue(TriggerRunTimestamp.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Message))
                {
                    writer.WritePropertyName("message"u8);
                    writer.WriteStringValue(Message);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Properties))
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(TriggeredPipelines))
                {
                    writer.WritePropertyName("triggeredPipelines"u8);
                    writer.WriteStartObject();
                    foreach (var item in TriggeredPipelines)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        TriggerRun IJsonModel<TriggerRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TriggerRun)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerRun(document.RootElement, options);
        }

        internal static TriggerRun DeserializeTriggerRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> triggerRunId = default;
            Optional<string> triggerName = default;
            Optional<string> triggerType = default;
            Optional<DateTimeOffset> triggerRunTimestamp = default;
            Optional<TriggerRunStatus> status = default;
            Optional<string> message = default;
            Optional<IReadOnlyDictionary<string, string>> properties = default;
            Optional<IReadOnlyDictionary<string, string>> triggeredPipelines = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerRunId"u8))
                {
                    triggerRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerName"u8))
                {
                    triggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    triggerType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerRunTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerRunTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new TriggerRunStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("triggeredPipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    triggeredPipelines = dictionary;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TriggerRun(triggerRunId.Value, triggerName.Value, triggerType.Value, Optional.ToNullable(triggerRunTimestamp), Optional.ToNullable(status), message.Value, Optional.ToDictionary(properties), Optional.ToDictionary(triggeredPipelines), additionalProperties);
        }

        BinaryData IPersistableModel<TriggerRun>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TriggerRun)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TriggerRun IPersistableModel<TriggerRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TriggerRun)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTriggerRun(document.RootElement, options);
        }

        string IPersistableModel<TriggerRun>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class TriggerRunConverter : JsonConverter<TriggerRun>
        {
            public override void Write(Utf8JsonWriter writer, TriggerRun model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TriggerRun Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerRun(document.RootElement);
            }
        }
    }
}
