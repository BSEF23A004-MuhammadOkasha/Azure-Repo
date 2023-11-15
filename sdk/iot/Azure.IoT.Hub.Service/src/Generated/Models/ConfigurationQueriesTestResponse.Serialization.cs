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

namespace Azure.IoT.Hub.Service.Models
{
    public partial class ConfigurationQueriesTestResponse : IUtf8JsonSerializable, IJsonModel<ConfigurationQueriesTestResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationQueriesTestResponse>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ConfigurationQueriesTestResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ConfigurationQueriesTestResponse>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ConfigurationQueriesTestResponse>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TargetConditionError))
            {
                writer.WritePropertyName("targetConditionError"u8);
                writer.WriteStringValue(TargetConditionError);
            }
            if (Optional.IsCollectionDefined(CustomMetricQueryErrors))
            {
                writer.WritePropertyName("customMetricQueryErrors"u8);
                writer.WriteStartObject();
                foreach (var item in CustomMetricQueryErrors)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        ConfigurationQueriesTestResponse IJsonModel<ConfigurationQueriesTestResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConfigurationQueriesTestResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationQueriesTestResponse(document.RootElement, options);
        }

        internal static ConfigurationQueriesTestResponse DeserializeConfigurationQueriesTestResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> targetConditionError = default;
            Optional<IReadOnlyDictionary<string, string>> customMetricQueryErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetConditionError"u8))
                {
                    targetConditionError = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customMetricQueryErrors"u8))
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
                    customMetricQueryErrors = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfigurationQueriesTestResponse(targetConditionError.Value, Optional.ToDictionary(customMetricQueryErrors), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationQueriesTestResponse>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConfigurationQueriesTestResponse)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ConfigurationQueriesTestResponse IPersistableModel<ConfigurationQueriesTestResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConfigurationQueriesTestResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeConfigurationQueriesTestResponse(document.RootElement, options);
        }

        string IPersistableModel<ConfigurationQueriesTestResponse>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
