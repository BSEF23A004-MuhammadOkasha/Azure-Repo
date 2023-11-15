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
    public partial class RegistryAcrDetails : IUtf8JsonSerializable, IJsonModel<RegistryAcrDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegistryAcrDetails>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RegistryAcrDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RegistryAcrDetails>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RegistryAcrDetails>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SystemCreatedAcrAccount))
            {
                if (SystemCreatedAcrAccount != null)
                {
                    writer.WritePropertyName("systemCreatedAcrAccount"u8);
                    writer.WriteObjectValue(SystemCreatedAcrAccount);
                }
                else
                {
                    writer.WriteNull("systemCreatedAcrAccount");
                }
            }
            if (Optional.IsDefined(UserCreatedAcrAccount))
            {
                if (UserCreatedAcrAccount != null)
                {
                    writer.WritePropertyName("userCreatedAcrAccount"u8);
                    writer.WriteObjectValue(UserCreatedAcrAccount);
                }
                else
                {
                    writer.WriteNull("userCreatedAcrAccount");
                }
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

        RegistryAcrDetails IJsonModel<RegistryAcrDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RegistryAcrDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegistryAcrDetails(document.RootElement, options);
        }

        internal static RegistryAcrDetails DeserializeRegistryAcrDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SystemCreatedAcrAccount> systemCreatedAcrAccount = default;
            Optional<UserCreatedAcrAccount> userCreatedAcrAccount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemCreatedAcrAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        systemCreatedAcrAccount = null;
                        continue;
                    }
                    systemCreatedAcrAccount = SystemCreatedAcrAccount.DeserializeSystemCreatedAcrAccount(property.Value);
                    continue;
                }
                if (property.NameEquals("userCreatedAcrAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userCreatedAcrAccount = null;
                        continue;
                    }
                    userCreatedAcrAccount = UserCreatedAcrAccount.DeserializeUserCreatedAcrAccount(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegistryAcrDetails(systemCreatedAcrAccount.Value, userCreatedAcrAccount.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegistryAcrDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RegistryAcrDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RegistryAcrDetails IPersistableModel<RegistryAcrDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RegistryAcrDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRegistryAcrDetails(document.RootElement, options);
        }

        string IPersistableModel<RegistryAcrDetails>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
