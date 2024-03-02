// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ImageStorageProfile : IUtf8JsonSerializable, IJsonModel<ImageStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageStorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageStorageProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OSDisk != null)
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OSDisk);
            }
            if (!(DataDisks is ChangeTrackingList<ImageDataDisk> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ZoneResilient.HasValue)
            {
                writer.WritePropertyName("zoneResilient"u8);
                writer.WriteBooleanValue(ZoneResilient.Value);
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

        ImageStorageProfile IJsonModel<ImageStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageStorageProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageStorageProfile(document.RootElement, options);
        }

        internal static ImageStorageProfile DeserializeImageStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageOSDisk osDisk = default;
            IList<ImageDataDisk> dataDisks = default;
            bool? zoneResilient = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = ImageOSDisk.DeserializeImageOSDisk(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImageDataDisk> array = new List<ImageDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageDataDisk.DeserializeImageDataDisk(item, options));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("zoneResilient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneResilient = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageStorageProfile(osDisk, dataDisks ?? new ChangeTrackingList<ImageDataDisk>(), zoneResilient, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        ImageStorageProfile IPersistableModel<ImageStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
