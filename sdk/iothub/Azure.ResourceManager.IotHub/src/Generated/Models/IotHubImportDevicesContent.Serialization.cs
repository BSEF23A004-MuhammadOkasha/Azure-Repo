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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubImportDevicesContent : IUtf8JsonSerializable, IJsonModel<IotHubImportDevicesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubImportDevicesContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IotHubImportDevicesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IotHubImportDevicesContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IotHubImportDevicesContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("inputBlobContainerUri"u8);
            writer.WriteStringValue(InputBlobContainerUri.AbsoluteUri);
            writer.WritePropertyName("outputBlobContainerUri"u8);
            writer.WriteStringValue(OutputBlobContainerUri.AbsoluteUri);
            if (Optional.IsDefined(InputBlobName))
            {
                writer.WritePropertyName("inputBlobName"u8);
                writer.WriteStringValue(InputBlobName);
            }
            if (Optional.IsDefined(OutputBlobName))
            {
                writer.WritePropertyName("outputBlobName"u8);
                writer.WriteStringValue(OutputBlobName);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(IncludeConfigurations))
            {
                writer.WritePropertyName("includeConfigurations"u8);
                writer.WriteBooleanValue(IncludeConfigurations.Value);
            }
            if (Optional.IsDefined(ConfigurationsBlobName))
            {
                writer.WritePropertyName("configurationsBlobName"u8);
                writer.WriteStringValue(ConfigurationsBlobName);
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

        IotHubImportDevicesContent IJsonModel<IotHubImportDevicesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubImportDevicesContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubImportDevicesContent(document.RootElement, options);
        }

        internal static IotHubImportDevicesContent DeserializeIotHubImportDevicesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri inputBlobContainerUri = default;
            Uri outputBlobContainerUri = default;
            Optional<string> inputBlobName = default;
            Optional<string> outputBlobName = default;
            Optional<IotHubAuthenticationType> authenticationType = default;
            Optional<ManagedIdentity> identity = default;
            Optional<bool> includeConfigurations = default;
            Optional<string> configurationsBlobName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputBlobContainerUri"u8))
                {
                    inputBlobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputBlobContainerUri"u8))
                {
                    outputBlobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inputBlobName"u8))
                {
                    inputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputBlobName"u8))
                {
                    outputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new IotHubAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("includeConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeConfigurations = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationsBlobName"u8))
                {
                    configurationsBlobName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubImportDevicesContent(inputBlobContainerUri, outputBlobContainerUri, inputBlobName.Value, outputBlobName.Value, Optional.ToNullable(authenticationType), identity.Value, Optional.ToNullable(includeConfigurations), configurationsBlobName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubImportDevicesContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubImportDevicesContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IotHubImportDevicesContent IPersistableModel<IotHubImportDevicesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubImportDevicesContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIotHubImportDevicesContent(document.RootElement, options);
        }

        string IPersistableModel<IotHubImportDevicesContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
