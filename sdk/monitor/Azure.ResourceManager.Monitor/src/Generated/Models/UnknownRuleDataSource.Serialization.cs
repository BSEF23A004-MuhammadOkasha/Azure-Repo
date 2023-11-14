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
    internal partial class UnknownRuleDataSource : IUtf8JsonSerializable, IJsonModel<RuleDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuleDataSource>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RuleDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RuleDataSource>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RuleDataSource>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(LegacyResourceId))
            {
                writer.WritePropertyName("legacyResourceId"u8);
                writer.WriteStringValue(LegacyResourceId);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation);
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
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

        RuleDataSource IJsonModel<RuleDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RuleDataSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownRuleDataSource(document.RootElement, options);
        }

        internal static UnknownRuleDataSource DeserializeUnknownRuleDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = "Unknown";
            Optional<ResourceIdentifier> resourceUri = default;
            Optional<ResourceIdentifier> legacyResourceId = default;
            Optional<string> resourceLocation = default;
            Optional<string> metricNamespace = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceUri = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("legacyResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    legacyResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownRuleDataSource(odataType, resourceUri.Value, legacyResourceId.Value, resourceLocation.Value, metricNamespace.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RuleDataSource>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RuleDataSource)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RuleDataSource IPersistableModel<RuleDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RuleDataSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUnknownRuleDataSource(document.RootElement, options);
        }

        string IPersistableModel<RuleDataSource>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
