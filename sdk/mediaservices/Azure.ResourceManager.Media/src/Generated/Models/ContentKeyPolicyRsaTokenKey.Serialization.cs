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

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyRsaTokenKey : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyRsaTokenKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyRsaTokenKey>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ContentKeyPolicyRsaTokenKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ContentKeyPolicyRsaTokenKey>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ContentKeyPolicyRsaTokenKey>)} interface");
            }

            writer.WriteStartObject();
            if (Exponent != null)
            {
                writer.WritePropertyName("exponent"u8);
                writer.WriteBase64StringValue(Exponent, "D");
            }
            else
            {
                writer.WriteNull("exponent");
            }
            if (Modulus != null)
            {
                writer.WritePropertyName("modulus"u8);
                writer.WriteBase64StringValue(Modulus, "D");
            }
            else
            {
                writer.WriteNull("modulus");
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyRsaTokenKey IJsonModel<ContentKeyPolicyRsaTokenKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRsaTokenKey)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyRsaTokenKey(document.RootElement, options);
        }

        internal static ContentKeyPolicyRsaTokenKey DeserializeContentKeyPolicyRsaTokenKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            byte[] exponent = default;
            byte[] modulus = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exponent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        exponent = null;
                        continue;
                    }
                    exponent = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("modulus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modulus = null;
                        continue;
                    }
                    modulus = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicyRsaTokenKey(odataType, serializedAdditionalRawData, exponent, modulus);
        }

        BinaryData IPersistableModel<ContentKeyPolicyRsaTokenKey>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRsaTokenKey)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContentKeyPolicyRsaTokenKey IPersistableModel<ContentKeyPolicyRsaTokenKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRsaTokenKey)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyRsaTokenKey(document.RootElement, options);
        }

        string IPersistableModel<ContentKeyPolicyRsaTokenKey>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
