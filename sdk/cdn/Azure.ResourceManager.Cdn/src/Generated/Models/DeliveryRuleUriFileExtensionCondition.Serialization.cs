// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeliveryRuleUriFileExtensionCondition : IUtf8JsonSerializable, IJsonModel<DeliveryRuleUriFileExtensionCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeliveryRuleUriFileExtensionCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeliveryRuleUriFileExtensionCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleUriFileExtensionCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeliveryRuleUriFileExtensionCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue(Properties);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
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

        DeliveryRuleUriFileExtensionCondition IJsonModel<DeliveryRuleUriFileExtensionCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleUriFileExtensionCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeliveryRuleUriFileExtensionCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeliveryRuleUriFileExtensionCondition(document.RootElement, options);
        }

        internal static DeliveryRuleUriFileExtensionCondition DeserializeDeliveryRuleUriFileExtensionCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UriFileExtensionMatchCondition parameters = default;
            MatchVariable name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = UriFileExtensionMatchCondition.DeserializeUriFileExtensionMatchCondition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = new MatchVariable(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeliveryRuleUriFileExtensionCondition(name, serializedAdditionalRawData, parameters);
        }

        BinaryData IPersistableModel<DeliveryRuleUriFileExtensionCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleUriFileExtensionCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeliveryRuleUriFileExtensionCondition)} does not support '{options.Format}' format.");
            }
        }

        DeliveryRuleUriFileExtensionCondition IPersistableModel<DeliveryRuleUriFileExtensionCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleUriFileExtensionCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeliveryRuleUriFileExtensionCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeliveryRuleUriFileExtensionCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeliveryRuleUriFileExtensionCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
