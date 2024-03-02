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
    public partial class SharedGalleryImageVersionStorageProfile : IUtf8JsonSerializable, IJsonModel<SharedGalleryImageVersionStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharedGalleryImageVersionStorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SharedGalleryImageVersionStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryImageVersionStorageProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OSDiskImage != null)
            {
                writer.WritePropertyName("osDiskImage"u8);
                writer.WriteObjectValue(OSDiskImage);
            }
            if (!(DataDiskImages is ChangeTrackingList<SharedGalleryDataDiskImage> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataDiskImages"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SharedGalleryImageVersionStorageProfile IJsonModel<SharedGalleryImageVersionStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedGalleryImageVersionStorageProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedGalleryImageVersionStorageProfile(document.RootElement, options);
        }

        internal static SharedGalleryImageVersionStorageProfile DeserializeSharedGalleryImageVersionStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SharedGalleryOSDiskImage osDiskImage = default;
            IReadOnlyList<SharedGalleryDataDiskImage> dataDiskImages = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDiskImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDiskImage = SharedGalleryOSDiskImage.DeserializeSharedGalleryOSDiskImage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataDiskImages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SharedGalleryDataDiskImage> array = new List<SharedGalleryDataDiskImage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SharedGalleryDataDiskImage.DeserializeSharedGalleryDataDiskImage(item, options));
                    }
                    dataDiskImages = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SharedGalleryImageVersionStorageProfile(osDiskImage, dataDiskImages ?? new ChangeTrackingList<SharedGalleryDataDiskImage>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SharedGalleryImageVersionStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryImageVersionStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        SharedGalleryImageVersionStorageProfile IPersistableModel<SharedGalleryImageVersionStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedGalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSharedGalleryImageVersionStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SharedGalleryImageVersionStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharedGalleryImageVersionStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
