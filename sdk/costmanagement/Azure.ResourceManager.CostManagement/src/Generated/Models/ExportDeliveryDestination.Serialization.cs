// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ExportDeliveryDestination : IUtf8JsonSerializable, IJsonModel<ExportDeliveryDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportDeliveryDestination>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExportDeliveryDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDeliveryDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDeliveryDestination)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            writer.WritePropertyName("container"u8);
            writer.WriteStringValue(Container);
            if (RootFolderPath != null)
            {
                writer.WritePropertyName("rootFolderPath"u8);
                writer.WriteStringValue(RootFolderPath);
            }
            if (SasToken != null)
            {
                writer.WritePropertyName("sasToken"u8);
                writer.WriteStringValue(SasToken);
            }
            if (StorageAccount != null)
            {
                writer.WritePropertyName("storageAccount"u8);
                writer.WriteStringValue(StorageAccount);
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

        ExportDeliveryDestination IJsonModel<ExportDeliveryDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDeliveryDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDeliveryDestination)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportDeliveryDestination(document.RootElement, options);
        }

        internal static ExportDeliveryDestination DeserializeExportDeliveryDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            string container = default;
            Optional<string> rootFolderPath = default;
            Optional<string> sasToken = default;
            Optional<string> storageAccount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("container"u8))
                {
                    container = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolderPath"u8))
                {
                    rootFolderPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccount"u8))
                {
                    storageAccount = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExportDeliveryDestination(resourceId.Value, container, rootFolderPath.Value, sasToken.Value, storageAccount.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportDeliveryDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDeliveryDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportDeliveryDestination)} does not support '{options.Format}' format.");
            }
        }

        ExportDeliveryDestination IPersistableModel<ExportDeliveryDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDeliveryDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExportDeliveryDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportDeliveryDestination)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportDeliveryDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
