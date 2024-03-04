// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountAgreementContent : IUtf8JsonSerializable, IJsonModel<IntegrationAccountAgreementContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountAgreementContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationAccountAgreementContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAgreementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAgreementContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AS2))
            {
                writer.WritePropertyName("aS2"u8);
                writer.WriteObjectValue(AS2);
            }
            if (Optional.IsDefined(X12))
            {
                writer.WritePropertyName("x12"u8);
                writer.WriteObjectValue(X12);
            }
            if (Optional.IsDefined(Edifact))
            {
                writer.WritePropertyName("edifact"u8);
                writer.WriteObjectValue(Edifact);
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

        IntegrationAccountAgreementContent IJsonModel<IntegrationAccountAgreementContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAgreementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAgreementContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountAgreementContent(document.RootElement, options);
        }

        internal static IntegrationAccountAgreementContent DeserializeIntegrationAccountAgreementContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AS2AgreementContent aS2 = default;
            X12AgreementContent x12 = default;
            EdifactAgreementContent edifact = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aS2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aS2 = AS2AgreementContent.DeserializeAS2AgreementContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("x12"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x12 = X12AgreementContent.DeserializeX12AgreementContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("edifact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    edifact = EdifactAgreementContent.DeserializeEdifactAgreementContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationAccountAgreementContent(aS2, x12, edifact, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationAccountAgreementContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAgreementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountAgreementContent)} does not support '{options.Format}' format.");
            }
        }

        IntegrationAccountAgreementContent IPersistableModel<IntegrationAccountAgreementContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAgreementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationAccountAgreementContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountAgreementContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationAccountAgreementContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
