// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeOrderData : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeOrderData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeOrderData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeOrderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeOrderData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(OrderId))
            {
                writer.WritePropertyName("orderId"u8);
                writer.WriteStringValue(OrderId);
            }
            if (Optional.IsDefined(ContactInformation))
            {
                writer.WritePropertyName("contactInformation"u8);
                writer.WriteObjectValue(ContactInformation);
            }
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentStatus))
            {
                writer.WritePropertyName("currentStatus"u8);
                writer.WriteObjectValue(CurrentStatus);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(OrderHistory))
            {
                writer.WritePropertyName("orderHistory"u8);
                writer.WriteStartArray();
                foreach (var item in OrderHistory)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DeliveryTrackingInfo))
            {
                writer.WritePropertyName("deliveryTrackingInfo"u8);
                writer.WriteStartArray();
                foreach (var item in DeliveryTrackingInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReturnTrackingInfo))
            {
                writer.WritePropertyName("returnTrackingInfo"u8);
                writer.WriteStartArray();
                foreach (var item in ReturnTrackingInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ShipmentType))
            {
                writer.WritePropertyName("shipmentType"u8);
                writer.WriteStringValue(ShipmentType.Value.ToString());
            }
            writer.WriteEndObject();
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

        DataBoxEdgeOrderData IJsonModel<DataBoxEdgeOrderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeOrderData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeOrderData(document.RootElement, options);
        }

        internal static DataBoxEdgeOrderData DeserializeDataBoxEdgeOrderData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> orderId = default;
            Optional<DataBoxEdgeContactDetails> contactInformation = default;
            Optional<DataBoxEdgeShippingAddress> shippingAddress = default;
            Optional<DataBoxEdgeOrderStatus> currentStatus = default;
            Optional<IReadOnlyList<DataBoxEdgeOrderStatus>> orderHistory = default;
            Optional<string> serialNumber = default;
            Optional<IReadOnlyList<DataBoxEdgeTrackingInfo>> deliveryTrackingInfo = default;
            Optional<IReadOnlyList<DataBoxEdgeTrackingInfo>> returnTrackingInfo = default;
            Optional<DataBoxEdgeShipmentType> shipmentType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("orderId"u8))
                        {
                            orderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contactInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactInformation = DataBoxEdgeContactDetails.DeserializeDataBoxEdgeContactDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("shippingAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shippingAddress = DataBoxEdgeShippingAddress.DeserializeDataBoxEdgeShippingAddress(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("currentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentStatus = DataBoxEdgeOrderStatus.DeserializeDataBoxEdgeOrderStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("orderHistory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeOrderStatus> array = new List<DataBoxEdgeOrderStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeOrderStatus.DeserializeDataBoxEdgeOrderStatus(item, options));
                            }
                            orderHistory = array;
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deliveryTrackingInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeTrackingInfo> array = new List<DataBoxEdgeTrackingInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeTrackingInfo.DeserializeDataBoxEdgeTrackingInfo(item, options));
                            }
                            deliveryTrackingInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("returnTrackingInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeTrackingInfo> array = new List<DataBoxEdgeTrackingInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeTrackingInfo.DeserializeDataBoxEdgeTrackingInfo(item, options));
                            }
                            returnTrackingInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("shipmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shipmentType = new DataBoxEdgeShipmentType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeOrderData(id, name, type, systemData.Value, kind.Value, orderId.Value, contactInformation.Value, shippingAddress.Value, currentStatus.Value, Optional.ToList(orderHistory), serialNumber.Value, Optional.ToList(deliveryTrackingInfo), Optional.ToList(returnTrackingInfo), Optional.ToNullable(shipmentType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeOrderData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeOrderData)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeOrderData IPersistableModel<DataBoxEdgeOrderData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeOrderData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeOrderData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeOrderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
