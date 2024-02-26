// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountPartnerContent : IUtf8JsonSerializable, IJsonModel<IntegrationAccountPartnerContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountPartnerContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationAccountPartnerContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountPartnerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountPartnerContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (B2B != null)
            {
                writer.WritePropertyName("b2b"u8);
                writer.WriteObjectValue(B2B);
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
            writer.WriteEndObject();
        }

        IntegrationAccountPartnerContent IJsonModel<IntegrationAccountPartnerContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountPartnerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountPartnerContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountPartnerContent(document.RootElement, options);
        }

        internal static IntegrationAccountPartnerContent DeserializeIntegrationAccountPartnerContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<B2BPartnerContent> b2b = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("b2b"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    b2b = B2BPartnerContent.DeserializeB2BPartnerContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationAccountPartnerContent(b2b.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationAccountPartnerContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountPartnerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountPartnerContent)} does not support '{options.Format}' format.");
            }
        }

        IntegrationAccountPartnerContent IPersistableModel<IntegrationAccountPartnerContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountPartnerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationAccountPartnerContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountPartnerContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationAccountPartnerContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
