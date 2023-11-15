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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountAgreementContent : IUtf8JsonSerializable, IJsonModel<IntegrationAccountAgreementContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountAgreementContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IntegrationAccountAgreementContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IntegrationAccountAgreementContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IntegrationAccountAgreementContent>)} interface");
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

        IntegrationAccountAgreementContent IJsonModel<IntegrationAccountAgreementContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAgreementContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountAgreementContent(document.RootElement, options);
        }

        internal static IntegrationAccountAgreementContent DeserializeIntegrationAccountAgreementContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AS2AgreementContent> aS2 = default;
            Optional<X12AgreementContent> x12 = default;
            Optional<EdifactAgreementContent> edifact = default;
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
                    aS2 = AS2AgreementContent.DeserializeAS2AgreementContent(property.Value);
                    continue;
                }
                if (property.NameEquals("x12"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x12 = X12AgreementContent.DeserializeX12AgreementContent(property.Value);
                    continue;
                }
                if (property.NameEquals("edifact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    edifact = EdifactAgreementContent.DeserializeEdifactAgreementContent(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationAccountAgreementContent(aS2.Value, x12.Value, edifact.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationAccountAgreementContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAgreementContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IntegrationAccountAgreementContent IPersistableModel<IntegrationAccountAgreementContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAgreementContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIntegrationAccountAgreementContent(document.RootElement, options);
        }

        string IPersistableModel<IntegrationAccountAgreementContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
