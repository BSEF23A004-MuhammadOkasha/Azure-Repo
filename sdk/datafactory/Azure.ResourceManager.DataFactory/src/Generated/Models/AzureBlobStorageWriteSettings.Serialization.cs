// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureBlobStorageWriteSettings : IUtf8JsonSerializable, IJsonModel<AzureBlobStorageWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureBlobStorageWriteSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureBlobStorageWriteSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlobStorageWriteSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BlockSizeInMB != null)
            {
                writer.WritePropertyName("blockSizeInMB"u8);
                JsonSerializer.Serialize(writer, BlockSizeInMB);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StoreWriteSettingsType);
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            if (CopyBehavior != null)
            {
                writer.WritePropertyName("copyBehavior"u8);
                JsonSerializer.Serialize(writer, CopyBehavior);
            }
            if (!(Metadata is ChangeTrackingList<DataFactoryMetadataItemInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        AzureBlobStorageWriteSettings IJsonModel<AzureBlobStorageWriteSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlobStorageWriteSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureBlobStorageWriteSettings(document.RootElement, options);
        }

        internal static AzureBlobStorageWriteSettings DeserializeAzureBlobStorageWriteSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<int> blockSizeInMB = default;
            string type = default;
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            DataFactoryElement<string> copyBehavior = default;
            IList<DataFactoryMetadataItemInfo> metadata = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blockSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blockSizeInMB = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("copyBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyBehavior = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFactoryMetadataItemInfo> array = new List<DataFactoryMetadataItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryMetadataItemInfo.DeserializeDataFactoryMetadataItemInfo(item, options));
                    }
                    metadata = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBlobStorageWriteSettings(
                type,
                maxConcurrentConnections,
                disableMetricsCollection,
                copyBehavior,
                metadata ?? new ChangeTrackingList<DataFactoryMetadataItemInfo>(),
                additionalProperties,
                blockSizeInMB);
        }

        BinaryData IPersistableModel<AzureBlobStorageWriteSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureBlobStorageWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        AzureBlobStorageWriteSettings IPersistableModel<AzureBlobStorageWriteSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureBlobStorageWriteSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureBlobStorageWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureBlobStorageWriteSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
