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

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class ScriptActivityTypePropertiesLogSettings : IUtf8JsonSerializable, IJsonModel<ScriptActivityTypePropertiesLogSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScriptActivityTypePropertiesLogSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ScriptActivityTypePropertiesLogSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ScriptActivityTypePropertiesLogSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ScriptActivityTypePropertiesLogSettings>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("logDestination"u8);
            writer.WriteStringValue(LogDestination.ToString());
            if (Optional.IsDefined(LogLocationSettings))
            {
                writer.WritePropertyName("logLocationSettings"u8);
                writer.WriteObjectValue(LogLocationSettings);
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

        ScriptActivityTypePropertiesLogSettings IJsonModel<ScriptActivityTypePropertiesLogSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ScriptActivityTypePropertiesLogSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptActivityTypePropertiesLogSettings(document.RootElement, options);
        }

        internal static ScriptActivityTypePropertiesLogSettings DeserializeScriptActivityTypePropertiesLogSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScriptActivityLogDestination logDestination = default;
            Optional<LogLocationSettings> logLocationSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logDestination"u8))
                {
                    logDestination = new ScriptActivityLogDestination(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logLocationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logLocationSettings = LogLocationSettings.DeserializeLogLocationSettings(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScriptActivityTypePropertiesLogSettings(logDestination, logLocationSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScriptActivityTypePropertiesLogSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ScriptActivityTypePropertiesLogSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ScriptActivityTypePropertiesLogSettings IPersistableModel<ScriptActivityTypePropertiesLogSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ScriptActivityTypePropertiesLogSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeScriptActivityTypePropertiesLogSettings(document.RootElement, options);
        }

        string IPersistableModel<ScriptActivityTypePropertiesLogSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
