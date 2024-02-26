// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class PriceSheetProperties : IUtf8JsonSerializable, IJsonModel<PriceSheetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PriceSheetProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PriceSheetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PriceSheetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PriceSheetProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && BillingPeriodId != null)
            {
                writer.WritePropertyName("billingPeriodId"u8);
                writer.WriteStringValue(BillingPeriodId);
            }
            if (options.Format != "W" && MeterId.HasValue)
            {
                writer.WritePropertyName("meterId"u8);
                writer.WriteStringValue(MeterId.Value);
            }
            if (options.Format != "W" && MeterDetails != null)
            {
                writer.WritePropertyName("meterDetails"u8);
                writer.WriteObjectValue(MeterDetails);
            }
            if (options.Format != "W" && UnitOfMeasure != null)
            {
                writer.WritePropertyName("unitOfMeasure"u8);
                writer.WriteStringValue(UnitOfMeasure);
            }
            if (options.Format != "W" && IncludedQuantity.HasValue)
            {
                writer.WritePropertyName("includedQuantity"u8);
                writer.WriteNumberValue(IncludedQuantity.Value);
            }
            if (options.Format != "W" && PartNumber != null)
            {
                writer.WritePropertyName("partNumber"u8);
                writer.WriteStringValue(PartNumber);
            }
            if (options.Format != "W" && UnitPrice.HasValue)
            {
                writer.WritePropertyName("unitPrice"u8);
                writer.WriteNumberValue(UnitPrice.Value);
            }
            if (options.Format != "W" && CurrencyCode != null)
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (options.Format != "W" && OfferId != null)
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
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

        PriceSheetProperties IJsonModel<PriceSheetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PriceSheetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PriceSheetProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePriceSheetProperties(document.RootElement, options);
        }

        internal static PriceSheetProperties DeserializePriceSheetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> billingPeriodId = default;
            Optional<Guid> meterId = default;
            Optional<ConsumptionMeterDetails> meterDetails = default;
            Optional<string> unitOfMeasure = default;
            Optional<decimal> includedQuantity = default;
            Optional<string> partNumber = default;
            Optional<decimal> unitPrice = default;
            Optional<string> currencyCode = default;
            Optional<string> offerId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingPeriodId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    billingPeriodId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("meterId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    meterId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("meterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meterDetails = ConsumptionMeterDetails.DeserializeConsumptionMeterDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"u8))
                {
                    unitOfMeasure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includedQuantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedQuantity = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("partNumber"u8))
                {
                    partNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unitPrice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unitPrice = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PriceSheetProperties(billingPeriodId.Value, Optional.ToNullable(meterId), meterDetails.Value, unitOfMeasure.Value, Optional.ToNullable(includedQuantity), partNumber.Value, Optional.ToNullable(unitPrice), currencyCode.Value, offerId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PriceSheetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PriceSheetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PriceSheetProperties)} does not support '{options.Format}' format.");
            }
        }

        PriceSheetProperties IPersistableModel<PriceSheetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PriceSheetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePriceSheetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PriceSheetProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PriceSheetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
