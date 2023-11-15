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

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class AzureStorageBlobContainerEndpointUpdateProperties : IUtf8JsonSerializable, IJsonModel<AzureStorageBlobContainerEndpointUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureStorageBlobContainerEndpointUpdateProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureStorageBlobContainerEndpointUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureStorageBlobContainerEndpointUpdateProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureStorageBlobContainerEndpointUpdateProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        AzureStorageBlobContainerEndpointUpdateProperties IJsonModel<AzureStorageBlobContainerEndpointUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureStorageBlobContainerEndpointUpdateProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureStorageBlobContainerEndpointUpdateProperties(document.RootElement, options);
        }

        internal static AzureStorageBlobContainerEndpointUpdateProperties DeserializeAzureStorageBlobContainerEndpointUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointType endpointType = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureStorageBlobContainerEndpointUpdateProperties(endpointType, description.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureStorageBlobContainerEndpointUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureStorageBlobContainerEndpointUpdateProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureStorageBlobContainerEndpointUpdateProperties IPersistableModel<AzureStorageBlobContainerEndpointUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureStorageBlobContainerEndpointUpdateProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureStorageBlobContainerEndpointUpdateProperties(document.RootElement, options);
        }

        string IPersistableModel<AzureStorageBlobContainerEndpointUpdateProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
