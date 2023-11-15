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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class KerberosPasswordSecrets : IUtf8JsonSerializable, IJsonModel<KerberosPasswordSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KerberosPasswordSecrets>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<KerberosPasswordSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<KerberosPasswordSecrets>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<KerberosPasswordSecrets>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KerberosPassword))
            {
                if (KerberosPassword != null)
                {
                    writer.WritePropertyName("kerberosPassword"u8);
                    writer.WriteStringValue(KerberosPassword);
                }
                else
                {
                    writer.WriteNull("kerberosPassword");
                }
            }
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
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

        KerberosPasswordSecrets IJsonModel<KerberosPasswordSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KerberosPasswordSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKerberosPasswordSecrets(document.RootElement, options);
        }

        internal static KerberosPasswordSecrets DeserializeKerberosPasswordSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kerberosPassword = default;
            SecretsType secretsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kerberosPassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        kerberosPassword = null;
                        continue;
                    }
                    kerberosPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KerberosPasswordSecrets(secretsType, serializedAdditionalRawData, kerberosPassword.Value);
        }

        BinaryData IPersistableModel<KerberosPasswordSecrets>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KerberosPasswordSecrets)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        KerberosPasswordSecrets IPersistableModel<KerberosPasswordSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KerberosPasswordSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKerberosPasswordSecrets(document.RootElement, options);
        }

        string IPersistableModel<KerberosPasswordSecrets>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
