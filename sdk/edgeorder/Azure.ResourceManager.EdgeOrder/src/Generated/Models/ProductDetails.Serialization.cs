// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductDetails : IUtf8JsonSerializable, IJsonModel<ProductDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProductDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProductDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayInfo))
            {
                writer.WritePropertyName("displayInfo"u8);
                writer.WriteObjectValue<ProductDisplayInfo>(DisplayInfo, options);
            }
            writer.WritePropertyName("hierarchyInformation"u8);
            writer.WriteObjectValue<HierarchyInformation>(HierarchyInformation, options);
            if (options.Format != "W" && Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductDoubleEncryptionStatus))
            {
                writer.WritePropertyName("productDoubleEncryptionStatus"u8);
                writer.WriteStringValue(ProductDoubleEncryptionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DeviceDetails))
            {
                writer.WritePropertyName("deviceDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DeviceDetails)
                {
                    writer.WriteObjectValue<EdgeOrderProductDeviceDetails>(item, options);
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

        ProductDetails IJsonModel<ProductDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProductDetails(document.RootElement, options);
        }

        internal static ProductDetails DeserializeProductDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProductDisplayInfo displayInfo = default;
            HierarchyInformation hierarchyInformation = default;
            int? count = default;
            DoubleEncryptionStatus? productDoubleEncryptionStatus = default;
            IReadOnlyList<EdgeOrderProductDeviceDetails> deviceDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayInfo = ProductDisplayInfo.DeserializeProductDisplayInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hierarchyInformation"u8))
                {
                    hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("productDoubleEncryptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    productDoubleEncryptionStatus = new DoubleEncryptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deviceDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdgeOrderProductDeviceDetails> array = new List<EdgeOrderProductDeviceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeOrderProductDeviceDetails.DeserializeEdgeOrderProductDeviceDetails(item, options));
                    }
                    deviceDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProductDetails(
                displayInfo,
                hierarchyInformation,
                count,
                productDoubleEncryptionStatus,
                deviceDetails ?? new ChangeTrackingList<EdgeOrderProductDeviceDetails>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProductDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProductDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ProductDetails IPersistableModel<ProductDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProductDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProductDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProductDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
